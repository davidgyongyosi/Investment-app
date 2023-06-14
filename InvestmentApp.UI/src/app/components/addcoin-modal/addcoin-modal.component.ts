import { Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { Observable } from 'rxjs';
import { map, startWith } from 'rxjs/operators';
import { MatDialogRef } from '@angular/material/dialog';
import { Coin } from 'src/app/models/coin';
import { CoinService } from 'src/app/services/coin.service';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-addcoin-modal',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <h1 mat-dialog-title>Add a coin</h1>
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <hr class="border-gray-500 w-full">
      <mat-dialog-content>
      <div class="flex justify-center flex-col gap-6 items-center">
        <form>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Find a coin...</mat-label>
            <input type="text" matInput [formControl]="myControl" [matAutocomplete]="auto">
            <mat-autocomplete #auto="matAutocomplete" [displayWith]="displayFn">
              <mat-option *ngFor="let option of filteredOptions | async" [value]="option">
                {{ option?.name }}
              </mat-option>
            </mat-autocomplete>
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Enter amount</mat-label>
            <input matInput type="number" name="amount" [(ngModel)]="amount">
          </mat-form-field>
        </form>
        <hr class="border-gray-500 w-full">
        <button mat-raised-button color="accent" (click)="addCoin()" class="w-1/2">Add Coin</button>
      </div>
      </mat-dialog-content>
    </div>
  `,
  styles: []
})
export class AddcoinModalComponent implements OnInit {
  myControl = new FormControl('');
  options: Coin[] = [];
  filteredOptions?: Observable<(Coin | null)[]>;
  amount!: number

  constructor(
    private dialogRef: MatDialogRef<AddcoinModalComponent>,
    private coinService: CoinService,
    private authService: AuthService
  ) {}

  ngOnInit() {
    this.coinService.getCoins().subscribe((result: Coin[]) => {
      this.options = result;
    });

    this.filteredOptions = this.myControl.valueChanges.pipe(
      startWith(''),
      map((value: string | Coin | null) => {
        const name = typeof value === 'string' ? value : value?.name;
        return name ? this._filter(name as string) : this.options.slice();
      })
    );
  }

  displayFn(coin: Coin | null): string {
    return coin && coin.name ? coin.name : '';
  }

  private _filter(name: string): (Coin | null)[] {
    const filterValue = name.toLowerCase();
    return this.options.filter((option) =>
      option.name.toLowerCase().includes(filterValue)
    );
  }

  addCoin() {
    const selectedCoin: Coin | null = this.myControl.value as Coin | null;
    this.authService.getUserInfo().subscribe((resp) => {
      const userId: string = resp.id;
      if (selectedCoin && selectedCoin.uid && this.amount) {
        this.authService.addCoinToUser(userId, selectedCoin.uid, this.amount)
        .subscribe({
          next: (data) => {
            this.dialogRef.close();
            console.log(data)
          },
          error: (e) => {
            console.error(e)
          }
        });
      }
    });
  }
  
  
}

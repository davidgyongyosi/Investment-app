import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { Coin } from 'src/app/models/coin';
import { CoinService } from 'src/app/services/coin.service';

@Component({
  selector: 'app-edit-coin',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <div class="flex justify-start flex-col pb-3">
          <h1 mat-dialog-title>Edit coin ("name")</h1>
          <button mat-flat-button color="primary" (click)="autoupdateCoin()">Request Coin</button>
        </div>  
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <hr class="border-gray-500 w-full">
      <mat-dialog-content>
      <div class="flex justify-center flex-col gap-6 items-center">
      <form>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's name</mat-label>
            <input matInput type="text" name="name" [(ngModel)]="coin.name">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's rank</mat-label>
            <input matInput type="number" name="rank" [(ngModel)]="coin.rank" disabled>
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Age</mat-label>
            <input matInput type="text" name="age" [(ngModel)]="coin.age">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's picture</mat-label>
            <input matInput type="text" name="picture" [(ngModel)]="coin.png64" disabled>
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's ATH(USD)</mat-label>
            <input matInput type="number" name="ath" [(ngModel)]="coin.allTimeHighUSD">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Code</mat-label>
            <input matInput type="text" name="code" id="liveInput" [(ngModel)]="coin.code">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Rate</mat-label>
            <input matInput type="number" name="rate" [(ngModel)]="coin.rate">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Valume</mat-label>
            <input matInput type="number" name="volume" [(ngModel)]="coin.volume">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Cap</mat-label>
            <input matInput type="number" name="cap" [(ngModel)]="coin.cap">
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's Color</mat-label>
            <input matInput type="number" name="color" [(ngModel)]="coin.color">
          </mat-form-field>
        </form>
        <hr class="border-gray-500 w-full">
        <button mat-raised-button color="accent" (click)="updateCoin()" class="w-1/2">Update Coin</button>
        <button mat-raised-button color="warn" (click)="deleteCoin()" class="w-1/2">Delete Coin</button>
      </div>
      </mat-dialog-content>
    </div>
  `,
  styles: [
  ]
})
export class EditCoinComponent {
  errorMessage = ""

  constructor(
    private dialogRef: MatDialogRef<EditCoinComponent>,
    private coinService: CoinService,
    @Inject(MAT_DIALOG_DATA) public coin: Coin,
  ) {}

  updateCoin() {
    this.coinService.Update(this.coin)
        .subscribe({
          next: (data) => {
            this.dialogRef.close()
        },
        error: (e) => {
          console.error(e);
        }
      });
  }

  autoupdateCoin() {
    const codeInput = document.querySelector('input[id="liveInput"]') as HTMLInputElement;
    const code = codeInput.value.toUpperCase();
  
    this.coinService.getLiveCoinData(code).subscribe(
      (response: any) => {
        console.log(response)
          const coin: Coin = {
            uid: "",
            name: response.name,
            rank: Number(response.rank),
            age: response.age.toString(),
            png64: response.png64,
            allTimeHighUSD: Number(response.allTimeHighUSD),
            code: code,
            rate: Number(response.rate),
            volume: Number(response.volume),
            cap: Number(response.cap),
            color: response.color
          };
  
          this.coin = coin;
          console.log(this.coin);
      },
      (error) => {
        this.errorMessage = 'An error occurred while fetching the coin data';
      }
    );
  }

  deleteCoin() {
    this.coinService.Delete(this.coin)
    .subscribe({
      next: (data) => {
        this.dialogRef.close()
    },
    error: (e) => {
      console.error(e);
    }
  });
  }
}

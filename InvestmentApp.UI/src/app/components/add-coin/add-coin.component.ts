import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { Coin } from 'src/app/models/coin';
import { CoinService } from 'src/app/services/coin.service';

@Component({
  selector: 'app-add-coin',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <div class="flex justify-start flex-col pb-3">
          <h1 mat-dialog-title>Add new coin</h1>
          <button mat-flat-button color="primary" (click)="autoaddCoin()">Request Coin</button>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Coin's code</mat-label>
            <input matInput type="text" id="liveInput">
          </mat-form-field>
        </div>  
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <div *ngIf="errorMessage" class="error-message">
      {{ errorMessage }}
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
            <input matInput type="text" name="code" [(ngModel)]="coin.code">
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
        <button mat-raised-button color="accent" (click)="addCoin()" class="w-1/2">Add Coin</button>
      </div>
      </mat-dialog-content>
    </div>
  `,
  styles: [
  ]
})
export class AddCoinComponent {
  errorMessage?: string;
  coin: Coin;

  constructor(
    private dialogRef: MatDialogRef<AddCoinComponent>,
    private coinService: CoinService
  ) {
    this.coin = new Coin()
  }

  addCoin() {
    this.coinService.Create(this.coin)
        .subscribe({
          next: (data) => {
            this.dialogRef.close()
        },
        error: (e) => {
          console.error(e);
        }
      });
  }

  autoaddCoin() {
    const codeInput = document.querySelector('input[id="liveInput"]') as HTMLInputElement;
    const code = codeInput.value.toUpperCase();
  
    this.coinService.getLiveCoinData(code).subscribe(
      (response: any) => {
        console.log(response)
        if (response) {
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
          this.errorMessage = '';
          console.log(this.coin);
        } else {
          this.errorMessage = 'The coin doesn\'t exist with that code';
        }
      },
      (error) => {
        this.errorMessage = 'An error occurred while fetching the coin data';
      }
    );
  }
  
}

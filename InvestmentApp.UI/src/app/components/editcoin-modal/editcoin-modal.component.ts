import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';
import { UserCoin } from 'src/app/models/usercoin';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-editcoin-modal',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <h1 mat-dialog-title>Edit your coin</h1>
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <hr class="border-gray-500 w-full">
      <mat-dialog-content>
      <div class="flex justify-center flex-col gap-6 items-center">
        <form>
          <mat-form-field class="w-full" appearance="outline">
            <input matInput type="text" name="name" [(ngModel)]="data.coin.name" disabled>
          </mat-form-field>
          <mat-form-field class="w-full" appearance="outline">
            <mat-label>Enter amount</mat-label>
            <input matInput type="number" name="amount" [(ngModel)]="data.coinCount">
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
export class EditcoinModalComponent {

  constructor(
    private dialogRef: MatDialogRef<EditcoinModalComponent>,
    @Inject(MAT_DIALOG_DATA) public data: UserCoin,
    private authService: AuthService
  ) {}

  deleteCoin(){
    this.authService.getUserInfo().subscribe((resp) => {
      const userId: string = resp.id;
        this.authService.deleteUserCoin(userId, this.data.coin.uid )
        .subscribe({
          next: (data) => {
            console.log(data)
            this.dialogRef.close();
          },
          error: (e) => {
            console.error(e)
          }
        });
    })
  }

  updateCoin(){
    this.authService.updateUserCoin(this.data)
          .subscribe({
            next: (data) => {
              console.log(data)
              this.dialogRef.close();
            },
            error: (e) => {
              console.error(e)
            }
          })
  }
}

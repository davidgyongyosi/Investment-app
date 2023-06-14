import { Injectable } from '@angular/core';
import { MatSnackBar, MatSnackBarHorizontalPosition, MatSnackBarVerticalPosition } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard {
  router: Router
  horizontalPosition: MatSnackBarHorizontalPosition = 'center';
  verticalPosition: MatSnackBarVerticalPosition = 'top';

  constructor(router: Router, private _snackBar: MatSnackBar) {
      this.router = router
  }

  public isLoggedIn() : boolean {
      let token = localStorage.getItem('token')
      // TODO check expiration date etc.
      return token !== null
  }

  public canActivate() : boolean {
    if (!this.isLoggedIn()) {
      this.router.navigate(['/home']);
      this.openSnackBar()
      return false;
    }
    return true;
  }

  openSnackBar() {
    this._snackBar.open('User not logged in!', 'Close', {
      horizontalPosition: this.horizontalPosition,
      verticalPosition: this.verticalPosition,
    });
  }
  
}

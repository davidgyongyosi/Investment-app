import { Component, EventEmitter, Output } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { LoginComponent } from '../auth-forms/login.component';
import { RegistrationComponent } from '../auth-forms/registration.component';
import { AuthService } from 'src/app/services/auth.service';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent {
  @Output() toggleSidenav = new EventEmitter();
  loggedIn: boolean;
  router: Router;
  user: User;

  constructor(private dialog: MatDialog, router: Router, private authService: AuthService,) {
    this.router = router;
    this.user = new User();
    this.loggedIn = localStorage.getItem('token') != null ? true : false;
  }

  ngOnInit(): void {
    this.loggedIn = localStorage.getItem('token') != null ? true : false;
    if(this.loggedIn){
      this.authService.getUserInfo()
          .subscribe({
            next: (data) => {
              this.user = data;
          },
          error: (e) => {
            console.error(e);
          }
        });
    }
  }

  openDialog(dialogType: string) {
    let dialogRef;

    if (dialogType === 'login') {
      dialogRef = this.dialog.open(LoginComponent);
    } else if (dialogType === 'register') {
      dialogRef = this.dialog.open(RegistrationComponent);
    }

    dialogRef?.afterClosed().subscribe(result => {
      if (result === 'success') {
        this.loggedIn = true;
        this.authService.getUserInfo()
          .subscribe({
            next: (data) => {
              this.user = data;
          },
          error: (e) => {
            console.error(e);
          }
        });
      }
    })
  }

  profileNavigate(){
    this.router.navigate(['/profile']);
  }

  logout(){
    localStorage.setItem('token', '');
    localStorage.setItem('expiration', '');
    localStorage.clear();
    this.loggedIn = false;
    this.router.navigate(['/home']);
  }


}

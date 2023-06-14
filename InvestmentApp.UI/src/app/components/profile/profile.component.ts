import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { User } from 'src/app/models/user';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.scss']
})
export class ProfileComponent {
  user: User;
  router: Router
  isEditing: boolean = false;

  constructor(private authService: AuthService, router: Router) {
    this.user = new User();
    this.router = router;
  }

  ngOnInit(): void {
    this.getUserInfo();
  }

  getUserInfo(): void {
    this.authService.getUserInfo().subscribe({
      next: (data) => {
        this.user = data;
      },
      error: (e) => {
        console.error(e);
      }
    });
  }

  toggleEdit(): void {
    this.isEditing = !this.isEditing;
  }

  saveChanges(): void {
    this.authService.updateUserInfo(this.user).subscribe({
      next: (response) => {
        console.log('User information updated successfully:', response);
        this.isEditing = false;
      },
      error: (e) => {
        console.error('Error updating user information:', e);
      }
    });
  }

  deleteAccount(){
    this.authService.deleteAccount().subscribe({
      next: (response) => {
        console.log(response)
        localStorage.setItem('token', '');
        localStorage.setItem('expiration', '');
        localStorage.clear();
        window.location.reload();
        this.router.navigate(['/pagenotfound']);
      },
      error: (e) => {
        console.log('Error deleting acount:', e);
      }


    })
  }
}

import { Component, OnInit } from '@angular/core';
import { AuthService } from 'src/app/services/auth.service';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { LoginModel } from 'src/app/models/loginmodel';
import { RegistrationComponent } from './registration.component';

@Component({
  selector: 'app-login',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <h1 mat-dialog-title>Login</h1>
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <mat-dialog-content>
        <div class="flex justify-center flex-col gap-6 items-center">
          <form [formGroup]="loginForm">
            <mat-form-field class="w-full" appearance="outline">
              <mat-label>Username</mat-label>
              <input matInput formControlName="username" required>
            </mat-form-field>
            <mat-form-field appearance="outline" class="w-full">
              <mat-label>Password</mat-label>
              <input matInput [type]="hide ? 'password' : 'text'" formControlName="password" required>
              <button mat-icon-button matSuffix (click)="hide = !hide" [attr.aria-label]="'Hide password'" [attr.aria-pressed]="hide">
                <mat-icon>{{hide ? 'visibility_off' : 'visibility'}}</mat-icon>
              </button>
            </mat-form-field>
            <p *ngIf="loginFailed" style="color: red">Username or password is incorrect</p>
          </form>
          <button mat-raised-button color="accent" (click)="login()" [disabled]="loginForm.invalid" class="w-1/2">Login</button>
          <hr class="border-gray-500 w-full">
          <span>Don't have an account?</span>
          <a class="text-teal-400 underline" (click)="openRegistration()">Sign Up</a>
        </div>
      </mat-dialog-content>
    </div>
  `,
})
export class LoginComponent implements OnInit {
  loginForm!: FormGroup;
  loginModel: LoginModel = new LoginModel();
  loginFailed = false;
  hide = true;

  constructor(
    private authService: AuthService, 
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<LoginComponent>,
    private dialog: MatDialog
  ) { }

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
  }

  login() {
    this.loginModel.username = this.loginForm.value.username;
    this.loginModel.password = this.loginForm.value.password;

    this.authService.login(this.loginModel)
      .subscribe({
        next: (data) => {
          this.dialogRef.close("success");
          const { token, expiration } = JSON.parse(data);
          localStorage.setItem('token', token);
          localStorage.setItem('expiration', expiration);
        },
        error: (e) => {
          console.error(e);
          this.loginFailed = true;
        }
      });
  }

  openRegistration() {
    this.dialogRef.close();
    const dialogRef = this.dialog.open(RegistrationComponent);
  }
}

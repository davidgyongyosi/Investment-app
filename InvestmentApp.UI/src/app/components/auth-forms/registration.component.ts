import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { AuthService } from 'src/app/services/auth.service';
import { LoginComponent } from './login.component';
import { RegisterModel } from 'src/app/models/registermodel';

@Component({
  selector: 'app-registration',
  template: `
    <div class="p-2 max-w-md">
      <div class="flex justify-between items-start">
        <h1 mat-dialog-title>Register</h1>
        <button mat-dialog-close class="p-3"><mat-icon class="text-gray-500">clear</mat-icon></button>
      </div>
      <mat-dialog-content>
        <div class="flex justify-center flex-col gap-6 items-center">
        <form [formGroup]="RegisterForm">
            <mat-form-field class="w-full" appearance="outline">
              <mat-label>First Name</mat-label>
              <input matInput formControlName="firstname" required>
            </mat-form-field>
            <mat-form-field class="w-full" appearance="outline">
              <mat-label>Last Name</mat-label>
              <input matInput formControlName="lastname" required>
            </mat-form-field>
            <mat-form-field class="w-full" appearance="outline">
              <mat-label>Email</mat-label>
              <input matInput formControlName="email" type="email" required>
            </mat-form-field>
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
            <!--<p *ngIf="registrationFailed" style="color: red">Registration failed, please try again</p>-->
          </form>
          <button mat-raised-button color="accent" (click)="register()" class="w-1/2">Register</button>
          <hr class="border-gray-500 w-full">
          <div><a class="text-teal-400 underline" (click)="openLogin()">I already have an account</a></div>
        </div>
      </mat-dialog-content>
    </div>
  `,
})
export class RegistrationComponent {
  registerModel: RegisterModel = new RegisterModel();
  RegisterForm!: FormGroup;
  hide = true;
  
  constructor(private authService: AuthService, 
    private fb: FormBuilder,
    private dialogRef: MatDialogRef<RegistrationComponent>,
    private dialog: MatDialog) {
  }

  ngOnInit(): void {
    this.RegisterForm = this.fb.group({
      email: ['', Validators.required],
      username: ['', Validators.required],
      firstname: ['', Validators.required],
      lastname: ['', Validators.required],
      password: ['', Validators.required]
    });
  }
  

  register() {
    this.registerModel.email = this.RegisterForm.value.email;
    this.registerModel.firstname = this.RegisterForm.value.firstname;
    this.registerModel.lastname = this.RegisterForm.value.lastname;
    this.registerModel.username = this.RegisterForm.value.username;
    this.registerModel.PictureData = "";
    this.registerModel.PictureContentType = "";
    this.registerModel.password = this.RegisterForm.value.password;
  
    this.authService.register(this.registerModel)
      .subscribe({
        next: (data) => {
          this.dialogRef.close();
        },
        error: (e) => {
          console.error(e);
        }
      });
  }
  
  openLogin() {
    this.dialogRef.close();
    const dialogRef = this.dialog.open(LoginComponent);
  }
}

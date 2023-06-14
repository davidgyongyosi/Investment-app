import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { of } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { LoginComponent } from '../auth-forms/login.component';
import { RegistrationComponent } from '../auth-forms/registration.component';
import { NavbarComponent } from './navbar.component';

describe('NavbarComponent', () => {
  let component: NavbarComponent;
  let fixture: ComponentFixture<NavbarComponent>;
  let mockMatDialog: jasmine.SpyObj<MatDialog>;
  let mockRouter: jasmine.SpyObj<Router>;
  let mockAuthService: jasmine.SpyObj<AuthService>;

  beforeEach(() => {
    mockMatDialog = jasmine.createSpyObj('MatDialog', ['open']);
    mockRouter = jasmine.createSpyObj('Router', ['navigate']);
    mockAuthService = jasmine.createSpyObj('AuthService', ['getUserInfo']);

    TestBed.configureTestingModule({
      declarations: [NavbarComponent],
      providers: [
        { provide: MatDialog, useValue: mockMatDialog },
        { provide: Router, useValue: mockRouter },
        { provide: AuthService, useValue: mockAuthService }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(NavbarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the component', () => {
    expect(component).toBeTruthy();
  });

  it('should open login dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of('success'));

    component.openDialog('login');

    expect(mockMatDialog.open).toHaveBeenCalledWith(LoginComponent);
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(component.loggedIn).toBeTrue();
    expect(mockAuthService.getUserInfo).toHaveBeenCalled();
  });

  it('should open registration dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of('success'));

    component.openDialog('register');

    expect(mockMatDialog.open).toHaveBeenCalledWith(RegistrationComponent);
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(component.loggedIn).toBeTrue();
    expect(mockAuthService.getUserInfo).toHaveBeenCalled();
  });

  it('should navigate to profile', () => {
    component.profileNavigate();

    expect(mockRouter.navigate).toHaveBeenCalledWith(['/profile']);
  });

  it('should log out', () => {
    component.logout();

    expect(localStorage.getItem('token')).toBe('');
    expect(localStorage.getItem('expiration')).toBe('');
    expect(localStorage.clear).toHaveBeenCalled();
    expect(component.loggedIn).toBeFalse();
    expect(mockRouter.navigate).toHaveBeenCalledWith(['/home']);
  });
});

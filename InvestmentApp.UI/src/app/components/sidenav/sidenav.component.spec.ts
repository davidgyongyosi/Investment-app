import { ComponentFixture, TestBed } from '@angular/core/testing';
import { BreakpointObserver, BreakpointState } from '@angular/cdk/layout';
import { RouterTestingModule } from '@angular/router/testing';
import { SidenavComponent } from './sidenav.component';

describe('SidenavComponent', () => {
  let component: SidenavComponent;
  let fixture: ComponentFixture<SidenavComponent>;
  let mockBreakpointObserver: jasmine.SpyObj<BreakpointObserver>;
  let mockBreakpointState: BreakpointState;

  beforeEach(() => {
    mockBreakpointObserver = jasmine.createSpyObj<BreakpointObserver>(['observe']);

    mockBreakpointState = {
      matches: true,
      breakpoints: {}
    };

    TestBed.configureTestingModule({
      imports: [RouterTestingModule],
      declarations: [SidenavComponent],
      providers: [
        { provide: BreakpointObserver, useValue: mockBreakpointObserver }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(SidenavComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

});
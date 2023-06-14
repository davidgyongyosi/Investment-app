import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MatDialog } from '@angular/material/dialog';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { of } from 'rxjs';
import { AuthService } from 'src/app/services/auth.service';
import { CoinService } from 'src/app/services/coin.service';
import { Coin } from 'src/app/models/coin';
import { UserCoin } from 'src/app/models/usercoin';
import { DashboardComponent } from './dashboard.component';
import { AddcoinModalComponent } from '../addcoin-modal/addcoin-modal.component';
import { EditcoinModalComponent } from '../editcoin-modal/editcoin-modal.component';

describe('DashboardComponent', () => {
  let component: DashboardComponent;
  let fixture: ComponentFixture<DashboardComponent>;
  let mockAuthService: jasmine.SpyObj<AuthService>;
  let mockCoinService: jasmine.SpyObj<CoinService>;
  let mockMatDialog: jasmine.SpyObj<MatDialog>;

  const mockUserCoins: UserCoin[] = [
    {
      userId: '1',
      coinId: '1',
      coinCount: 123,
      coin: new Coin
    },
    {
      userId: '1',
      coinId: '2',
      coinCount: 1233,
      coin: new Coin
    },
    {
      userId: '1',
      coinId: '3',
      coinCount: 12345,
      coin: new Coin
    }
  ];

  const mockCoins: Coin[] = [
    {
      uid: '1',
      name: 'Crypto1',
      rank: 1235,
      age: '12',
      png64: 'png.jpg',
      allTimeHighUSD: 123525,
      code: 'CTY',
      rate: 124,
      volume: 2453453453,
      cap: 234,
      color: '1a1f16'
    },
    {
      uid: '2',
      name: 'Crypto2',
      rank: 1235,
      age: '12',
      png64: 'png.jpg',
      allTimeHighUSD: 123525,
      code: 'CTY',
      rate: 124,
      volume: 2453453453,
      cap: 234,
      color: '1a1f16'
    },
    {
      uid: '3',
      name: 'Crypto3',
      rank: 1235,
      age: '12',
      png64: 'png.jpg',
      allTimeHighUSD: 123525,
      code: 'CTY',
      rate: 124,
      volume: 2453453453,
      cap: 234,
      color: '11f16'
    }
  ];

  beforeEach(() => {
    mockAuthService = jasmine.createSpyObj('AuthService', ['getUserCoins']);
    mockCoinService = jasmine.createSpyObj('CoinService', ['getCoins']);
    mockMatDialog = jasmine.createSpyObj('MatDialog', ['open']);

    TestBed.configureTestingModule({
      declarations: [DashboardComponent],
      providers: [
        { provide: AuthService, useValue: mockAuthService },
        { provide: CoinService, useValue: mockCoinService },
        { provide: MatDialog, useValue: mockMatDialog }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(DashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the component', () => {
    expect(component).toBeTruthy();
  });

  it('should fetch user coins and coins on initialization', () => {
    mockAuthService.getUserCoins.and.returnValue(of(mockUserCoins));
    mockCoinService.getCoins.and.returnValue(of(mockCoins));

    component.ngOnInit();

    expect(mockAuthService.getUserCoins).toHaveBeenCalled();
    expect(mockCoinService.getCoins).toHaveBeenCalled();
    expect(component.coinstable.data).toEqual(mockUserCoins);
    expect(component.coins).toEqual(mockCoins);
  });

  it('should open add coin dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of(undefined));
    mockAuthService.getUserCoins.and.returnValue(of(mockUserCoins));

    component.openDialog('addusercoin', null);

    expect(mockMatDialog.open).toHaveBeenCalledWith(AddcoinModalComponent);
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(mockAuthService.getUserCoins).toHaveBeenCalled();
  });

  it('should open edit coin dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of(undefined));
    mockAuthService.getUserCoins.and.returnValue(of(mockUserCoins));

    const mockUserCoin: UserCoin = {
      userId: '1',
      coinId: '1',
      coinCount: 123,
      coin: new Coin
    };

    component.openDialog('editusercoin', mockUserCoin);

    expect(mockMatDialog.open).toHaveBeenCalledWith(EditcoinModalComponent, {
      data: mockUserCoin
    });
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(mockAuthService.getUserCoins).toHaveBeenCalled();
  });
});

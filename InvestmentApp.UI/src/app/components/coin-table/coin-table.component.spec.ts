import { ComponentFixture, TestBed } from '@angular/core/testing';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { of } from 'rxjs';
import { Coin } from 'src/app/models/coin';
import { CoinService } from 'src/app/services/coin.service';
import { CoinTableComponent } from './coin-table.component';
import { AddCoinComponent } from '../add-coin/add-coin.component';
import { EditCoinComponent } from '../edit-coin/edit-coin.component';

describe('CoinTableComponent', () => {
  let component: CoinTableComponent;
  let fixture: ComponentFixture<CoinTableComponent>;
  let mockCoinService: jasmine.SpyObj<CoinService>;
  let mockMatDialog: jasmine.SpyObj<MatDialog>;

  const mockCoins: Coin[] = [
    {
      uid: '123daf-g5qwjkhgv-asewr234512v',
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
      uid: '123daf-g5qwjkhgv-14sfdfs412',
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
      uid: '123daf-g5qwjkhgv-o8927z6359',
      name: 'Crypto3',
      rank: 1235,
      age: '12',
      png64: 'png.jpg',
      allTimeHighUSD: 123525,
      code: 'CTY',
      rate: 124,
      volume: 2453453453,
      cap: 234,
      color: '1a1f16'
    }
  ];

  beforeEach(() => {
    mockCoinService = jasmine.createSpyObj('CoinService', ['getCoins']);
    mockMatDialog = jasmine.createSpyObj('MatDialog', ['open']);

    TestBed.configureTestingModule({
      declarations: [CoinTableComponent],
      providers: [
        { provide: CoinService, useValue: mockCoinService },
        { provide: MatDialog, useValue: mockMatDialog }
      ]
    }).compileComponents();

    fixture = TestBed.createComponent(CoinTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create the component', () => {
    expect(component).toBeTruthy();
  });

  it('should fetch coins on initialization', () => {
    mockCoinService.getCoins.and.returnValue(of(mockCoins));

    component.ngOnInit();

    expect(mockCoinService.getCoins).toHaveBeenCalled();
    expect(component.coins.data).toEqual(mockCoins);
  });

  it('should open add coin dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of(undefined));

    component.openDialog('addcoin', null);

    expect(mockMatDialog.open).toHaveBeenCalledWith(AddCoinComponent);
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(mockCoinService.getCoins).toHaveBeenCalled();
  });

  it('should open edit coin dialog', () => {
    const mockDialogRef = jasmine.createSpyObj('DialogRef', ['afterClosed']);
    mockMatDialog.open.and.returnValue(mockDialogRef);
    mockDialogRef.afterClosed.and.returnValue(of(undefined));

    const mockCoin: Coin = {
      uid: '123daf-g5qwjkhgv-o8927z6359',
      name: 'Crypto',
      rank: 1235,
      age: '12',
      png64: 'png.jpg',
      allTimeHighUSD: 123525,
      code: 'CTY',
      rate: 124,
      volume: 2453453453,
      cap: 234,
      color: '1a1f16'
    };

    component.openDialog('editcoin', mockCoin);

    expect(mockMatDialog.open).toHaveBeenCalledWith(EditCoinComponent, {
      data: mockCoin
    });
    expect(mockDialogRef.afterClosed).toHaveBeenCalled();
    expect(mockCoinService.getCoins).toHaveBeenCalled();
  });
});

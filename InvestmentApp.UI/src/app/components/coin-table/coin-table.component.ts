import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Coin } from 'src/app/models/coin';
import { CoinService } from 'src/app/services/coin.service';
import { AddCoinComponent } from '../add-coin/add-coin.component';
import { EditCoinComponent } from '../edit-coin/edit-coin.component';

@Component({
  selector: 'app-coin-table',
  templateUrl: './coin-table.component.html',
  styleUrls: ['./coin-table.component.scss']
})
export class CoinTableComponent{
  displayedColumns: string[] = ['rank', 'code', 'rate', 'cap', 'volume', 'allTimeHighUSD', 'edit'];
  coins = new MatTableDataSource<Coin>;

  @ViewChild(MatPaginator, { static: false }) paginator!: MatPaginator;
  @ViewChild(MatSort) sort!: MatSort;

  ngAfterViewInit() {
    this.coins.paginator = this.paginator;
    this.coins.sort = this.sort;
  }

  constructor(private coinService: CoinService, private dialog: MatDialog) {}

  ngOnInit(): void {
    this.coinService.getCoins().subscribe((result: Coin[]) => {
      this.coins.data = result;
    });
  }

  openDialog(dialogType: string, coin: Coin | null) {
    let dialogRef;

    if (dialogType === 'addcoin') {
      dialogRef = this.dialog.open(AddCoinComponent)
    } else if (dialogType === 'editcoin') {
      dialogRef = this.dialog.open(EditCoinComponent, {
        data: coin
      })
    }

    dialogRef?.afterClosed().subscribe(resp => {
        this.coinService.getCoins().subscribe((result: Coin[]) => {
          this.coins.data = result;
        });
  })
  }
}

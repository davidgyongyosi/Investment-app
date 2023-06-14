import { Component, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';
import { Coin } from 'src/app/models/coin';
import { AuthService } from 'src/app/services/auth.service';
import { CoinService } from 'src/app/services/coin.service';
import { AddcoinModalComponent } from '../addcoin-modal/addcoin-modal.component';
import { UserCoin } from 'src/app/models/usercoin';
import { EditcoinModalComponent } from '../editcoin-modal/editcoin-modal.component';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.scss']
})
export class DashboardComponent {
  displayedColumns: string[]
  coinstable: MatTableDataSource<UserCoin>
  coins: Array<Coin>
  userbalance: number = 0
  percent?: number;
  treemapData: any[] = [];

  @ViewChild(MatSort) sort!: MatSort;
  //@ViewChild(TreemapComponent) treemapComponent!: TreemapComponent;
  
  constructor(private authService: AuthService, private coinService: CoinService, private dialog: MatDialog) {
    this.displayedColumns = ['rank', 'code', 'rate', 'quantity', 'value', 'share', 'edit']
    this.coinstable = new MatTableDataSource<UserCoin>
    this.coins = new Array<Coin>
  }

  ngAfterViewInit() {
    this.coinstable.sort = this.sort;
  }  

  ngOnInit(): void {
    this.authService.getUserCoins()
          .subscribe({
            next: (data) => {
              this.coinstable.data = data
              data.forEach(data => {
                this.userbalance += data.coinCount * data.coin.rate
              });

              this.treemapData = [...this.generateTreemap(this.coinstable.data)];
          },
          error: (e) => {
            console.error(e);
          }
        });
    
    this.coinService.getCoins()
          .subscribe((result: Coin[]) => {
            this.coins = result;
        });
  }

  openDialog(dialogType: string, coin: UserCoin | null) {
    let dialogRef;

    if (dialogType === 'addusercoin') {
      dialogRef = this.dialog.open(AddcoinModalComponent)
    } else if (dialogType === 'editusercoin') {
      dialogRef = this.dialog.open(EditcoinModalComponent, {
        data: coin
      })
    }

    dialogRef?.afterClosed().subscribe(resp =>{
      this.userbalance = 0

      this.authService.getUserCoins()
          .subscribe({
            next: (data) => {
              this.coinstable.data = data
              data.forEach(data => {
                this.userbalance += data.coinCount * data.coin.rate
                this.percent = data.coinCount * data.coin.rate / this.userbalance
              });
              this.treemapData = [...this.generateTreemap(this.coinstable.data)];
          },
          error: (e) => {
            console.error(e);
          }
        });
    })
  }

  generateTreemap(data: UserCoin[]) : any {
    let mapdata = data.map((coinData) => {
      const coinValue = Math.round(((coinData.coinCount * coinData.coin.rate) / this.userbalance) * 100);

      return {
        label: coinData.coin.code,
        value: coinValue,
        color: coinData.coin.color
      };
    });
    return mapdata;
  }

  getStyle(percent: number){
    return {
      width: `${percent.toFixed()}%`,
    };
  }

}

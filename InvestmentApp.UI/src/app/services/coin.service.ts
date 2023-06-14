import { Injectable } from '@angular/core';
import { Coin } from '../models/coin';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment.development';
import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})
export class CoinService {
  private url = 'Coin';
  private liveUrl = 'https://api.livecoinwatch.com/coins/single';
  private apiKey = 'fa31ddb5-faa5-4780-9006-61cdb1411b82';

  constructor(private http: HttpClient) { }

  public getCoins() : Observable<Coin[]> {
    return this.http.get<Coin[]>(`${environment.baseApiUrl}/${this.url}`);
  }

  public Create(coin: Coin) {
    return this.http.post(`${environment.baseApiUrl}/${this.url}`, coin);
  }

  public Update(coin: Coin) {
    return this.http.put(`${environment.baseApiUrl}/${this.url}`, coin);
  }

  public Delete(coin: Coin) {
    return this.http.delete(`${environment.baseApiUrl}/${this.url}?uid=${coin.uid}`);
  }

  //Live Coin Watch API
  public getLiveCoinData(code: string): Observable<Coin> {
    const request = {
      method: 'POST',
      headers: {
        'content-type': 'application/json',
        'x-api-key': this.apiKey
      },
      body: JSON.stringify({
        currency: 'USD',
        code: code,
        meta: true
      })
    };

    return new Observable<Coin>((observer) => {
      fetch(new Request(this.liveUrl, request))
        .then(response => response.json())
        .then(data => {
          if (data.error) {
            observer.error(data.error);
          } else {
            observer.next(data);
          }
          observer.complete();
        })
        .catch(error => observer.error(error));
    });
  }
}

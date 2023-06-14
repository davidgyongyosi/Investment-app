import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment.development';
import { User } from '../models/user';
import { LoginModel } from '../models/loginmodel';
import { RegisterModel } from '../models/registermodel';
import { UserCoin } from '../models/usercoin';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  private url = 'Auth';
  constructor(private http: HttpClient) { }
  
  login(loginModel: LoginModel): Observable<string> {
    return this.http.post(`${environment.baseApiUrl}/${this.url}/Login`, loginModel, {
      responseType: 'text',
    });
  }
  
  register(registermodel: RegisterModel): Observable<any> {
    console.log(registermodel);
    return this.http.put<any>(`${environment.baseApiUrl}/${this.url}/InsertUser`, registermodel);
  }

  getUserInfo(): Observable<User> {
    return this.http.get<User>(`${environment.baseApiUrl}/${this.url}/GetUserInfos`);
  }

  updateUserInfo(user: User): Observable<any> {
    return this.http.post(`${environment.baseApiUrl}/${this.url}/Update`, user);
  }

  deleteAccount(): Observable<any> {
    return this.http.delete(`${environment.baseApiUrl}/${this.url}/DeleteMyself`);
  }

  getUserCoins(): Observable<UserCoin[]> {
    return this.http.get<UserCoin[]>(`${environment.baseApiUrl}/${this.url}/GetUserCoins`);
  }

  addCoinToUser(userid: string, coinid: string, amount: number): Observable<any> {
    return this.http.post(`${environment.baseApiUrl}/${this.url}/AddCoinToUser`, {userid, coinid, amount});
  }

  deleteUserCoin(userid: string, coinid: string): Observable<any> {
    return this.http.delete(`${environment.baseApiUrl}/${this.url}/DeleteUserCoin?userId=${userid}&coinId=${coinid}`);
  }

  updateUserCoin(newuserCoin: UserCoin): Observable<any>{
    return this.http.put(`${environment.baseApiUrl}/${this.url}/UpdateUserCoin`, newuserCoin);
  }
}

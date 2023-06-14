import { Coin } from "./coin"

export class UserCoin{
    userId: string = ""
    coinId: string = ""
    coinCount: number = 0
    coin: Coin = new Coin()
}
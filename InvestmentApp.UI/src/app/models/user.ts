import { Coin } from "./coin";

export class User {
    id = "";
    userName = "";
    firstName = "";
    lastName = "";
    email = "";
    picture = "";
    coin: Array<Coin> = []
}
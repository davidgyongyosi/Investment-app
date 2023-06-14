using System;
using InvestmentApp.API.Models;
using Newtonsoft.Json;
using RestSharp;

namespace InvestmentApp.API.Data
{
    public class CoinRepository : ICoinRepository
    {
        private readonly ApplicationDbContext _db;

        public CoinRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Coin> ReadAll()
        {
            return _db.Coins;
        }

        public void Create(Coin coin)
        {
            var old = _db.Coins.FirstOrDefault(t => t.Name == coin.Name);

            var newcoin = new Coin();

            newcoin.Name = coin.Name;
            newcoin.Rank = coin.Rank;
            newcoin.Age = coin.Age;
            newcoin.png64 = coin.png64;
            newcoin.AllTimeHighUSD = coin.AllTimeHighUSD;
            newcoin.Code = coin.Code;
            newcoin.Rate = coin.Rate;
            newcoin.Volume = coin.Volume;
            newcoin.Cap = coin.Cap;
            newcoin.Color = coin.Color;

            if (old == null)
            {
                _db.Coins.Add(newcoin);
                _db.SaveChanges();
            }
            else
            {
                throw new ArgumentException("Coin is already in the list");
            }
        }

        public void Update(string id, Coin coin)
        {
            var old = _db.Coins.FirstOrDefault(t => t.Name == coin.Name);

            if (old != null)
            {
                old.Age = coin.Age;
                old.png64 = coin.png64;
                old.AllTimeHighUSD = coin.AllTimeHighUSD;
                old.Rate = coin.Rate;
                old.Volume = coin.Volume;
                old.Cap = coin.Cap;
                old.Color = coin.Color;
            }
            _db.SaveChanges();
        }

        public void Delete(string id)
        {
            var coin = _db.Coins.FirstOrDefault(t => t.Uid == id);
            if (coin != null)
            {
                _db.Coins.Remove(coin);
                _db.SaveChanges();
            }
        }
    }
}


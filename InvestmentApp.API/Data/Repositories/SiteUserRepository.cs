using System;
using InvestmentApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace InvestmentApp.API.Data
{
	public class SiteUserRepository: ISiteUserRepository
	{
        private readonly ApplicationDbContext _db;

        public SiteUserRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<UserCoins> GetUserCoins(string userId)
        {
            return _db.UserCoins.Where(t => t.UserId == userId);
        }

        public void AddCoinToUser(string userId, string coinId, double count)
        {
            var user = _db.Users.FirstOrDefault(u => u.Id == userId);
            var coin = _db.Coins.FirstOrDefault(c => c.Uid == coinId);

            if (user != null && coin != null)
            {
                var userCoins = new UserCoins
                {
                    UserId = userId,
                    CoinId = coinId,
                    CoinCount = count,
                    Coin = coin
                };

                user.Coins.Add(userCoins);
                _db.SaveChanges();
            }
        }

        public void DeleteUserCoin(string userId, string coinId)
        {
            var userCoin = _db.UserCoins.FirstOrDefault(u => u.UserId == userId && u.CoinId == coinId);

            if (userCoin != null)
            {
                _db.UserCoins.Remove(userCoin);
                _db.SaveChanges();
            }
        }

        public void UpdateUserCoin(string userId, string coinId, UserCoins newuserCoins)
        {
            var olduserCoin = _db.UserCoins.FirstOrDefault(u => u.UserId == userId && u.CoinId == coinId);

            if (olduserCoin != null && newuserCoins != null)
            {
                olduserCoin.CoinCount = newuserCoins.CoinCount;
            }
            _db.SaveChanges();
        }
    }
}


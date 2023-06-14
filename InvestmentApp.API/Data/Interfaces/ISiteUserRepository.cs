using System;
using InvestmentApp.API.Models;

namespace InvestmentApp.API.Data
{
	public interface ISiteUserRepository
	{
        void AddCoinToUser(string userId, string coinId, double count);
        void DeleteUserCoin(string userId, string coinId);
        void UpdateUserCoin(string userId, string coinId, UserCoins newuserCoins);
        IEnumerable<UserCoins> GetUserCoins(string userId);
    }
}


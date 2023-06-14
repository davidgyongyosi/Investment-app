using System;
using InvestmentApp.API.Data;
using InvestmentApp.API.Models;

namespace InvestmentApp.API.Logic
{
	public class SiteUserLogic: ISiteUserLogic
	{
		private readonly ISiteUserRepository _repository;

		public SiteUserLogic(ISiteUserRepository repository)
		{
			_repository = repository;
		}

		public void AddCoinToUser(string userId, string coinId, double count)
		{
			_repository.AddCoinToUser(userId, coinId, count);
		}

		public void DeleteUserCoin(string userId, string coinId)
		{
			_repository.DeleteUserCoin(userId, coinId);
		}

		public void UpdateUserCoin(string userId, string coinId, UserCoins newuserCoins)
		{
			_repository.UpdateUserCoin(userId, coinId, newuserCoins);
		}


        public IEnumerable<UserCoins> GetUserCoins(string userId)
		{
			return _repository.GetUserCoins(userId);
		}
    }
}


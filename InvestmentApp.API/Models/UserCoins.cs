using System;
namespace InvestmentApp.API.Models
{
	public class UserCoins
	{
        public string UserId { get; set; }

        public string CoinId { get; set; }

        public double CoinCount { get; set; }
        public virtual Coin Coin { get; set; }
    }
}


using System;
using InvestmentApp.API.Data;
using InvestmentApp.API.Models;

namespace InvestmentApp.API.Logic
{
    public class CoinLogic : ICoinLogic
    {
        private readonly ICoinRepository _repository;

        public CoinLogic(ICoinRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Coin> ReadAll()
        {
            return _repository.ReadAll();
        }

        public void Create(Coin coin)
        {
            if (coin != null)
            {
                _repository.Create(coin);
            }
        }

        public void Update(string id, Coin coin)
        {
            if (coin != null)
            {
                _repository.Update(id, coin);
            }
        }

        public void Delete(string id)
        {
            if (id != null)
            {
                _repository.Delete(id);
            }
        }
    }
}


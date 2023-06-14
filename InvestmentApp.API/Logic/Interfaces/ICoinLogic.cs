using InvestmentApp.API.Models;

namespace InvestmentApp.API.Logic
{
    public interface ICoinLogic
    {
        IEnumerable<Coin> ReadAll();
        void Create(Coin coin);
        void Update(string id, Coin coin);
        void Delete(string id);
    }
}
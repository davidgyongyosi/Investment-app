using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvestmentApp.API.Logic;
using InvestmentApp.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace InvestmentApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinController : ControllerBase
    {
        private readonly ICoinLogic _logic;

        public CoinController(ICoinLogic logic)
        {
            _logic = logic;
        }

        [HttpGet]
        public IEnumerable<Coin> ReadAll()
        {
            return _logic.ReadAll();
        }

        [HttpPost]
        public void Post([FromBody]Coin coin)
        {
            _logic.Create(coin);
        }

        [HttpPut]
        public void Put([FromBody]Coin coin)
        {
            _logic.Update(coin.Uid, coin);
        }

        [HttpDelete]
        public void Delete(string uid)
        {
            _logic.Delete(uid);
        }
    }
}


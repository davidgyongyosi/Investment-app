using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using InvestmentApp.API.Logic;
using InvestmentApp.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace InvestmentApp.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<SiteUser> _userManager;
        private readonly ISiteUserLogic _logic;

        public AuthController(UserManager<SiteUser> userManager, ISiteUserLogic logic)
        {
            _userManager = userManager;
            _logic = logic;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);
            if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            {
                var claim = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.NameId, user.UserName)
                };
                foreach (var role in await _userManager.GetRolesAsync(user))
                {
                    claim.Add(new Claim(ClaimTypes.Role, role));
                }
                var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("nagyonhosszutitkoskodhelye"));
                var token = new JwtSecurityToken(
                 issuer: "http://www.security.org", audience: "http://www.security.org",
                 claims: claim, expires: DateTime.Now.AddMinutes(60),
                 signingCredentials: new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
                );
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPut]
        public async Task<IActionResult> InsertUser([FromBody] RegisterViewModel model)
        {
            var user = new SiteUser
            {
                Email = model.Email,
                UserName = model.UserName,
                SecurityStamp = Guid.NewGuid().ToString(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Picture = model.Photo,
            };
            await _userManager.CreateAsync(user, model.Password);
            await _userManager.AddToRoleAsync(user, "User");
            return Ok();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetUserInfos()
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            if (user != null)
            {
                return Ok(new
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    PictureData = user.Picture,
                    Coin = user.Coins
                });
            }
            return Unauthorized();
        }

        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeleteMyself()
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            var result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return Ok();
            }
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody] RegisterViewModel model)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            user.Email = model.Email;
            user.UserName = model.UserName;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Picture = model.Photo;
            if (!(model.Password == null || model.Password.Length == 0))
            {
                await _userManager.RemovePasswordAsync(user);
                await _userManager.AddPasswordAsync(user, model.Password);
            }
            await _userManager.UpdateAsync(user);
            return Ok();
        }


        [Authorize]
        [HttpGet]
        public IEnumerable<UserCoins> GetUserCoins()
        {
            var user = _userManager.Users.FirstOrDefault(t => t.UserName == this.User.Identity.Name);
            return _logic.GetUserCoins(user.Id);
        }

        [HttpPost]
        public IActionResult AddCoinToUser([FromBody] UserCoinModel model)
        {
            try
            {
                _logic.AddCoinToUser(model.userId, model.coinId, model.amount);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult DeleteUserCoin(string userId, string coinId)
        {
            try
            {
                _logic.DeleteUserCoin(userId, coinId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdateUserCoin(UserCoins newuserCoins)
        {
            try
            {
                _logic.UpdateUserCoin(newuserCoins.UserId, newuserCoins.CoinId, newuserCoins);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}


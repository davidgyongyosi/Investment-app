using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace InvestmentApp.API.Models
{
    public class SiteUser : IdentityUser
    {
        [Required, StringLength(200)]
        public string FirstName { get; set; }
        [Required, StringLength(200)]
        public string LastName { get; set; }

        public string? Picture { get; set; }

        public virtual ICollection<UserCoins> Coins { get; set; }

        public SiteUser()
        {
            this.Coins = new HashSet<UserCoins>();
        }
    }
}
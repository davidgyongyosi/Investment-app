using System;
using System.Reflection.Emit;
using InvestmentApp.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace InvestmentApp.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<SiteUser>
    {
        public DbSet<Coin> Coins { get; set; }
        public DbSet<SiteUser> Users { get; set; }
        public DbSet<UserCoins> UserCoins { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new { Id = "I", Name = "Admin", NormalizedName = "ADMIN" },
                new { Id = "2", Name = "User", NormalizedName = "User" }
                );

            PasswordHasher<SiteUser> ph = new PasswordHasher<SiteUser>();
            SiteUser superuser = new SiteUser
            {
                Id = Guid.NewGuid().ToString(),
                Email = "admin@admin.adm",
                EmailConfirmed = true,
                UserName = "superuser",
                FirstName = "Super",
                LastName = "User",
                NormalizedUserName = "SUPERUSER"
            };
            superuser.PasswordHash = ph.HashPassword(superuser, "Passw0rd");
            builder.Entity<SiteUser>().HasData(superuser);
            
            var json = File.ReadAllText("coins.json");
            var data = JsonConvert.DeserializeObject<List<Coin>>(json);
            foreach (var item in data)
            {
                var coin = new Coin
                {
                    Uid = Guid.NewGuid().ToString(),
                    Name = item.Name,
                    Rank = item.Rank,
                    Age = item.Age,
                    png64 = item.png64,
                    AllTimeHighUSD = item.AllTimeHighUSD,
                    Code = item.Code,
                    Rate = item.Rate,
                    Volume = item.Volume,
                    Cap = item.Cap,
                    Color = item.Color
                };

                builder.Entity<Coin>().HasData(coin);
                
            }

            builder.Entity<UserCoins>().HasKey("UserId", "CoinId");

            base.OnModelCreating(builder);

        }
    }
}


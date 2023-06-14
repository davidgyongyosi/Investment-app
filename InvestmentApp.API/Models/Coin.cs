using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RestSharp;

namespace InvestmentApp.API.Models
{
    public class Coin
	{
        [Key]
        public string? Uid { get; set; }

        [RequestProperty(Name = "name")]
        public string? Name { get; set; }

        [RequestProperty(Name = "rank")]
        public int Rank { get; set; }

        [RequestProperty(Name = "age")]
        public string? Age { get; set; }

        [RequestProperty(Name = "png64")]
        public string? png64 { get; set; }

        [RequestProperty(Name = "allTimeHighUSD")]
        public double AllTimeHighUSD { get; set; }

        [RequestProperty(Name = "code")]
        public string? Code { get; set; }

        [RequestProperty(Name = "rate")]
        public double Rate { get; set; }

        [RequestProperty(Name = "volume")]
        public double Volume { get; set; }

        [RequestProperty(Name = "cap")]
        public double Cap { get; set; }

        [RequestProperty(Name = "color")]
        public string? Color { get; set; }

        public Coin()
        {
            Uid = Guid.NewGuid().ToString();
        }
    }
}


using System;
using CoinbasePro.Services.Accounts.Types;
using CoinbasePro.Shared.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CoinbasePro.Services.Accounts.Models
{
    public class AccountHistory
    {
        public string Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal Amount { get; set; }

        public decimal Balance { get; set; }

        [JsonProperty("type")]
        public AccountEntryType AccountEntryType { get; set; }

        public Details Details { get; set; }
    }

    public class Details
    {
        public Guid OrderId { get; set; }

        public string TradeId { get; set; }

        public ProductType ProductId { get; set; }
    }
}

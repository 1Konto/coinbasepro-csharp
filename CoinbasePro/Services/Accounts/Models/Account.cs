using System;
using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Accounts.Models
{
    public class Account
    {
        public Guid Id { get; set; }

        public Guid ProfileId { get; set; }

        public Currency Currency { get; set; }

        public decimal Balance { get; set; }

        public decimal Hold { get; set; }

        public decimal Available { get; set; }
    }
}

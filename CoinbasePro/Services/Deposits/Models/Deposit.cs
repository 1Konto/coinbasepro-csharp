using System;
using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Deposits.Models
{
    public class Deposit
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public Guid PaymentMethodId { get; set; }
    }
}

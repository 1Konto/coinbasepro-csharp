using System;
using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Deposits.Models.Responses
{
    public class DepositResponse
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public DateTime PayoutAt { get; set; }
    }
}

using System;
using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Withdrawals.Models.Responses
{
    public class CryptoResponse
    {
        public Guid Id { get; set; }

        public decimal Amount { get; set; }

        public Currency Currency { get; set; }
    }
}

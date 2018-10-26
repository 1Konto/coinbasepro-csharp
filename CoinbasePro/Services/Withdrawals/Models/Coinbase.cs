using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Withdrawals.Models
{
    public class Coinbase
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public string CoinbaseAccountId { get; set; }
    }
}

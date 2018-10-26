using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Withdrawals.Models
{
    public class Crypto
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public string CryptoAddress { get; set; }
    }
}

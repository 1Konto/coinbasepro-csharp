using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Withdrawals.Models
{
    public class Withdrawal
    {
        public decimal Amount { get; set; }

        public Currency Currency { get; set; }

        public string PaymentMethodId { get; set; }
    }
}

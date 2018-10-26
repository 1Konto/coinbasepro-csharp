using CoinbasePro.Shared.Types;

namespace CoinbasePro.Services.Products.Models
{
    public class Product
    {
        public ProductType Id { get; set; }

        public Currency BaseCurrency { get; set; }

        public Currency QuoteCurrency { get; set; }

        public decimal BaseMinSize { get; set; }

        public decimal BaseMaxSize { get; set; }

        public decimal QuoteIncrement { get; set; }
    }
}

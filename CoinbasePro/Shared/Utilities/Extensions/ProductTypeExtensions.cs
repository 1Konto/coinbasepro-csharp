using System;
using CoinbasePro.Shared.Types;

namespace CoinbasePro.Shared.Utilities.Extensions
{
    public static class ProductTypeExtensions
    {
        public static Currency BaseCurrency(this ProductType value)
        {
            var baseCurrency = value.Symbol.Split('-')[0];

            return (Currency)Enum.Parse(typeof(Currency), baseCurrency);
        }

        public static Currency QuoteCurrency(this ProductType value)
        {
            var quoteCurrency = value.Symbol.Split('-')[1];

            return (Currency)Enum.Parse(typeof(Currency), quoteCurrency);
        }
    }
}

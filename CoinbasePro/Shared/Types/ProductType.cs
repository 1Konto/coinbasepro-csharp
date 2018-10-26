using System;
using CoinbasePro.Shared.Utilities;
using Newtonsoft.Json;

namespace CoinbasePro.Shared.Types
{
    [JsonConverter(typeof(JsonConverter))]
    public sealed class ProductType : IEquatable<ProductType>
    {
        public string Symbol { get; }

        public ProductType(string symbol)
        {
            if (!symbol.Contains("-"))
            {
                throw new FormatException("Currency pairs must be separated by a '-' character");
            }

            Symbol = symbol;
        }

        public bool Equals(ProductType other)
        {
            if (ReferenceEquals(null, other))
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return string.Equals(Symbol, other.Symbol, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((ProductType)obj);
        }

        public override int GetHashCode()
        {
            return (Symbol != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Symbol) : 0);
        }

        public override string ToString()
        {
            return Symbol;
        }

        public static ProductType BtcUsd = new ProductType("BTC-USD");
        public static ProductType BtcEur = new ProductType("BTC-EUR");
        public static ProductType BtcGbp = new ProductType("BTC-GBP");
        public static ProductType EthUsd = new ProductType("ETH-USD");
        public static ProductType EthEur = new ProductType("ETH-EUR");
        public static ProductType EthBtc = new ProductType("ETH-BTC");
        public static ProductType EthGbp = new ProductType("ETH-GBP");
        public static ProductType LtcUsd = new ProductType("LTC-USD");
        public static ProductType LtcEur = new ProductType("LTC-EUR");
        public static ProductType LtcBtc = new ProductType("LTC-BTC");
        public static ProductType LtcGbp = new ProductType("LTC-GBP");
        public static ProductType BchUsd = new ProductType("BCH-USD");
        public static ProductType BchEur = new ProductType("BCH-EUR");
        public static ProductType BchBtc = new ProductType("BCH-BTC");
        public static ProductType BchGbp = new ProductType("BCH-GBP");
        public static ProductType EtcUsd = new ProductType("ETC-USD");
        public static ProductType EtcEur = new ProductType("ETC-EUR");
        public static ProductType EtcBtc = new ProductType("ETC-BTC");
        public static ProductType EtcGbp = new ProductType("ETC-GBP");
        public static ProductType ZrxUsd = new ProductType("ZRX-USD");
        public static ProductType ZrxEur = new ProductType("ZRX-EUR");
        public static ProductType ZrxBtc = new ProductType("ZRX-BTC");

        public static bool operator ==(ProductType left, ProductType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ProductType left, ProductType right)
        {
            return !Equals(left, right);
        }

        internal class JsonConverter : TypeChangeJsonConverter<ProductType, string>
        {
            protected override string Convert(ProductType value)
            {
                return value.Symbol;
            }

            protected override ProductType Convert(string value)
            {
                return new ProductType(value);
            }
        }
    }
}

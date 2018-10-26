using System;
using CoinbasePro.Shared.Utilities;
using Newtonsoft.Json;

namespace CoinbasePro.Shared.Types
{
    [JsonConverter(typeof(JsonConverter))]
    public sealed class Currency : IEquatable<Currency>
    {
        public string Symbol { get; }

        public Currency(string symbol)
        {
            Symbol = symbol;
        }

        public bool Equals(Currency other)
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
            return obj is Currency other && Equals(other);
        }

        public override int GetHashCode()
        {
            return (Symbol != null ? StringComparer.OrdinalIgnoreCase.GetHashCode(Symbol) : 0);
        }

        public override string ToString()
        {
            return Symbol;
        }

        public static readonly Currency USD = new Currency("USD");
        public static readonly Currency EUR = new Currency("EUR");
        public static readonly Currency GBP = new Currency("GBP");
        public static readonly Currency BTC = new Currency("BTC");
        public static readonly Currency LTC = new Currency("LTC");
        public static readonly Currency ETH = new Currency("ETH");
        public static readonly Currency BCH = new Currency("BCH");
        public static readonly Currency ETC = new Currency("ETC");
        public static readonly Currency ZRX = new Currency("ZRX");

        public static bool operator ==(Currency left, Currency right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Currency left, Currency right)
        {
            return !Equals(left, right);
        }

        internal class JsonConverter : TypeChangeJsonConverter<Currency, string>
        {
            protected override string Convert(Currency value)
            {
                return value.Symbol;
            }

            protected override Currency Convert(string value)
            {
                return new Currency(value);
            }
        }
    }
}

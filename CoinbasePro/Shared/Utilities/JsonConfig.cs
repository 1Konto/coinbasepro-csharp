using System;
using System.Collections.Generic;
using CoinbasePro.Shared.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;

namespace CoinbasePro.Shared.Utilities
{
    internal static class JsonConfig
    {
        private static JsonSerializerSettings SerializerSettings { get; } = new JsonSerializerSettings
        {
            FloatParseHandling = FloatParseHandling.Decimal,
            NullValueHandling = NullValueHandling.Ignore,
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            },
            Converters = new List<JsonConverter>
            {
                new DecimalJsonConverter()
            },
            Error = delegate(object sender, ErrorEventArgs args)
            {
                if (args.CurrentObject == args.ErrorContext.OriginalObject)
                {
                    Log.Error("Json serialization error {@OriginalObject} {@Member} {@ErrorMessage}",
                        args.ErrorContext.OriginalObject,
                        args.ErrorContext.Member,
                        args.ErrorContext.Error.Message);
                }
            }
        };

        internal static string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value, SerializerSettings);
        }

        internal static T DeserializeObject<T>(string contentBody)
        {
            return JsonConvert.DeserializeObject<T>(contentBody, SerializerSettings);
        }

        private class DecimalJsonConverter : JsonConverter
        {
            public override bool CanRead => true;
            public override bool CanWrite => false;

            public override bool CanConvert(Type objectType)
            {
                return objectType == typeof(decimal);
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                throw new NotImplementedException();
            }

            public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            {
                var value = reader.Value as string;
                if (string.IsNullOrEmpty(value))
                {
                    return null;
                }

                try
                {
                    return decimal.Parse(value);
                }
                catch
                {
                    return (decimal) double.Parse(value);
                }
            }
        }
    }
}

using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace InternsApi.Services.Parsing
{
    public class CustomDateTimeConverter : IsoDateTimeConverter
    {
        public const string CustomIsoFormat = "yyyy'-'MM'-'dd'T'HH':'mm'+'ss'Z'";
        public CustomDateTimeConverter()
        {
            //2021-07-01T00:00+00Z
            DateTimeFormat = CustomIsoFormat;
        }
    }
}

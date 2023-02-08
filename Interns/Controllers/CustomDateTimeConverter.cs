using Newtonsoft.Json.Converters;

namespace Interns.Controllers;

internal class CustomDateTimeConverter : IsoDateTimeConverter
{
    public const string CustomIsoFormat = "yyyy'-'MM'-'dd'T'HH':'mm'+'ss'Z'";
    public CustomDateTimeConverter()
    {
        //2021-07-01T00:00+00Z
        base.DateTimeFormat = CustomIsoFormat;
    }
}
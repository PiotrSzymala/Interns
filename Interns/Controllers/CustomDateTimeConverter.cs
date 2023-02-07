using Newtonsoft.Json.Converters;

namespace Interns.Controllers;

internal class CustomDateTimeConverter : IsoDateTimeConverter
{
    public CustomDateTimeConverter()
    {
        //2021-07-01T00:00+00Z
        base.DateTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm'+'ss'Z'";
    }
}
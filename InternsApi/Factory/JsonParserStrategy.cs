using InternsApi.Models;
using Newtonsoft.Json;

namespace InternsApi.Factory
{
    public class JsonParserStrategy : IParserStrategy
    {
        public List<Intern> Parse(string data)
        {

            var settings = new JsonSerializerSettings
            {
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc
            };

            var interns = JsonConvert.DeserializeObject<InternsRoot>(data,settings);

            if (interns is null)
                throw new Exception("Wrong");

            return interns.Interns;
        }
    }
}

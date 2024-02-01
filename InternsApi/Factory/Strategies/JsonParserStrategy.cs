using InternsApi.Models;
using InternsApi.Services.Parsing.Json;
using Newtonsoft.Json;

namespace InternsApi.Factory.Strategies
{
    public class JsonParserStrategy : IParserStrategy
    {
        private readonly IJsonService _jsonService;

        public JsonParserStrategy(IJsonService jsonService)
        {
            _jsonService = jsonService;
        }

        public List<Intern> Parse(string data)
        {
            return _jsonService.ParseFromJson(data);
        }

    }
}

using InternsApi.Models;
using InternsApi.Services;
using Newtonsoft.Json;

namespace InternsApi.Factory
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

using InternsApi.Models;
using Newtonsoft.Json;

namespace InternsApi.Services
{
    public class JsonService : IJsonService
    {
        public List<Intern> ParseFromJson(string data)
        {
            var internsRoot = JsonConvert.DeserializeObject<InternsRoot>(data);

            return internsRoot is null ? throw new Exception("Unable to deserialize") : internsRoot.Interns;
        }
    }
}

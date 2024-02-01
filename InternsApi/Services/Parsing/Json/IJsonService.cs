using InternsApi.Models;

namespace InternsApi.Services.Parsing.Json
{
    public interface IJsonService
    {
        List<Intern> ParseFromJson(string data);
    }
}

using InternsApi.Models;

namespace InternsApi.Services
{
    public interface IJsonService
    {
        List<Intern> ParseFromJson(string data);
    }
}

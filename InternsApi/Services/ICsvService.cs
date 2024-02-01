using InternsApi.Models;

namespace InternsApi.Services
{
    public interface ICsvService
    {
        List<Intern> ParseFromCsv(string data);
    }
}

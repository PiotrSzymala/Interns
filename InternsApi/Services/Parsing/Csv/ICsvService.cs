using InternsApi.Models;

namespace InternsApi.Services.Parsing.Csv
{
    public interface ICsvService
    {
        List<Intern> ParseFromCsv(string data);
    }
}

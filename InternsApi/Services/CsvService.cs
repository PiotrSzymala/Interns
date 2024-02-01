using CsvHelper;
using InternsApi.Models;
using System.Globalization;

namespace InternsApi.Services
{
    public class CsvService : ICsvService
    {
        public List<Intern> ParseFromCsv(string data)
        {
            InternsRoot result = new InternsRoot();
            using var reader = new StringReader(data);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

            csv.Context.RegisterClassMap<CsvInternMapper>();

            var records = csv.GetRecords<Intern>().ToList();

            result.Interns = records;

            return result.Interns;
        }
    }
}

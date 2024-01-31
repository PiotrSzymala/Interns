using CsvHelper;
using InternsApi.Models;
using InternsApi.Services;
using System.Globalization;

namespace InternsApi.Factory
{
    public class CsvParserStrategy : IParserStrategy
    {
        public List<Intern> Parse(string data)
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

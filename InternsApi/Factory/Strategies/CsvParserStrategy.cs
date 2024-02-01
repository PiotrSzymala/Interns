using CsvHelper;
using InternsApi.Models;
using InternsApi.Services.Parsing.Csv;
using System.Globalization;

namespace InternsApi.Factory.Strategies
{
    public class CsvParserStrategy : IParserStrategy
    {
        private readonly ICsvService _csvService;

        public CsvParserStrategy(ICsvService csvService)
        {
            _csvService = csvService;
        }

        public List<Intern> Parse(string data)
        {
            return _csvService.ParseFromCsv(data);
        }
    }
}

using InternsApi.Models;
using System.IO.Compression;
using System.Text;
using InternsApi.Services.Parsing.Csv;
using InternsApi.Services.Parsing.Zip;

namespace InternsApi.Factory.Strategies
{
    public class ZipCsvParserStrategy : IParserStrategy
    {
        private readonly IZipService _zipService;
        private readonly ICsvService _csvService;

        public ZipCsvParserStrategy(IZipService fileService, ICsvService csvService)
        {
            _zipService = fileService;
            _csvService = csvService;
        }

        public List<Intern> Parse(string data)
        {
            var zipBytes = Convert.FromBase64String(data);

            var unzippedString = _zipService.ParseFromZip(zipBytes);

            var interns = _csvService.ParseFromCsv(unzippedString);

            return interns;
        }
    }
}

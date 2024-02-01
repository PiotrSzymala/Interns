using System.Globalization;
using CsvHelper;
using Interns.Application.Controllers.Deserialization;
using Interns.Application.Models;

namespace Interns.Application.Controllers.Deserialization.Csv;

internal class CsvParserStrategy : IParserStrategy
{
    public List<Intern> Parse(string input)
    {
        InternsResponse result = new InternsResponse();

        using var reader = new StringReader(input);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        csv.Context.RegisterClassMap<CsvInternMapper>();

        var records = csv.GetRecords<Intern>().ToList();

        result.Interns = records;

        return result.Interns;
    }
}
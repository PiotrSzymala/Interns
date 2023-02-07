using System.Globalization;
using CsvHelper;
using Interns.Models;

namespace Interns.Controllers.Deserialization.Csv;

internal class CsvDeserializer : IFileTypeDistincter
{
    public RootObject Deserialize(string input)
    {
        RootObject result = new RootObject();

        using var reader = new StringReader(input);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);

        csv.Context.RegisterClassMap<CsvInternMapper>();

        var records = csv.GetRecords<Intern>().ToList();

        result.Interns = records;

        return result;
    }
}
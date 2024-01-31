using CsvHelper.Configuration;
using InternsApi.Models;

namespace InternsApi.Services
{
    internal sealed class CsvInternMapper : ClassMap<Intern>
    {
        public CsvInternMapper()
        {
            Map(m => m.Id).Name("interns/id");
            Map(m => m.Age).Name("interns/age");
            Map(m => m.Name).Name("interns/name");
            Map(m => m.Email).Name("interns/email");

            Map(m => m.InternshipStart).Name("interns/internshipStart")
                .TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>()
                .TypeConverterOption
                .Format(CustomDateTimeConverter.CustomIsoFormat);

            Map(m => m.InternshipEnd).Name("interns/internshipEnd")
                .TypeConverter<CsvHelper.TypeConversion.DateTimeConverter>()
                .TypeConverterOption
                .Format(CustomDateTimeConverter.CustomIsoFormat);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interns.Application.Controllers.Deserialization.Csv;
using Interns.Application.Controllers.Deserialization.Json;
using Interns.Application.Controllers.Deserialization.Zip;

namespace Interns.Application.Controllers.Deserialization
{
    public class ParserFactory
    {
        public IParserStrategy CreateParser(FileType type)
        {
            return type switch
            {
                FileType.Json => new JsonParserStrategy(),
                FileType.Csv => new CsvParserStrategy(),
                FileType.Zip => new ZipParserStrategy(),
                _ => throw new Exception($"File type {type} is not handled")
            };
        }
    }

    public enum FileType
    {
        Json,
        Csv,
        Zip,
    }
}

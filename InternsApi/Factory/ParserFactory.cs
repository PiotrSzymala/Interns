namespace InternsApi.Factory
{
    public class ParserFactory
    {
        public IParserStrategy CreateParser(string fileType)
        {
            return fileType.ToLower() switch
            {
                "application/json" => new JsonParserStrategy(),
                "text/csv" => new CsvParserStrategy(),
                "application/zip" => new ZipCsvParserStrategy(),
                _ => throw new ArgumentException("Unhandled file format")
            };
        }
    }
}

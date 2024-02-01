using InternsApi.Services;

namespace InternsApi.Factory
{
    public class ParserFactory
    {

        private readonly IServiceProvider _serviceProvider;
        public ParserFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public IParserStrategy CreateParser(string fileType)
        {
            return fileType.ToLower() switch
            {
                "application/json" => (IParserStrategy)_serviceProvider.GetService(typeof(JsonParserStrategy)),
                "text/csv" => (IParserStrategy)_serviceProvider.GetService(typeof(CsvParserStrategy)),
                "application/zip" => (IParserStrategy)_serviceProvider.GetService(typeof(ZipCsvParserStrategy)),
                _ => throw new ArgumentException("Unhandled file format"),
            };
        }
    }
}

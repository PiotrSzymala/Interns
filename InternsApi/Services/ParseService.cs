using InternsApi.Factory;
using InternsApi.Models;

namespace InternsApi.Services
{
    public class ParseService : IParseService
    {
        private readonly ParserFactory _parserFactory;

        public ParseService(ParserFactory parserFactory)
        {
            _parserFactory = parserFactory;
        }

        public async Task ParseFile(FileResponseDto dto)
        {

            var parser = _parserFactory.CreateParser(dto.ResponseType);

            var interns = parser.Parse(dto.Response);

        }
    }
}

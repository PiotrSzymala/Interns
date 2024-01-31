using InternsApi.Factory;
using InternsApi.Models;

namespace InternsApi.Services
{
    public class ParseService : IParseService
    {

        public async Task ParseFile(FileResponseDto dto)
        {
            var parserFactory = new ParserFactory();

            var parser = parserFactory.CreateParser(dto.ResponseType);

            var interns = parser.Parse(dto.Response);

        }
    }
}

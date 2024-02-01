using InternsApi.Models;
using InternsApi.Models.DTO;

namespace InternsApi.Services.Parsing
{
    public interface IParseService
    {
        Task<List<Intern>> ParseFile(FileResponseDto dto);
    }
}

using InternsApi.Models.DTO;

namespace InternsApi.Services.Parsing
{
    public interface IParseService
    {
        Task ParseFile(FileResponseDto dto);
    }
}

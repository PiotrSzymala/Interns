using InternsApi.Models;

namespace InternsApi.Services
{
    public interface IParseService
    {
        Task ParseFile(FileResponseDto dto);
    }
}

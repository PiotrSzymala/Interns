using InternsApi.Models;

namespace InternsApi.Services
{
    public interface IFileService
    {
        Task<FileResponseDto> GetFileAsync(string url);
    }
}

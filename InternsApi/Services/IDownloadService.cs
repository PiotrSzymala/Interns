using InternsApi.Models;

namespace InternsApi.Services
{
    public interface IDownloadService
    {
        Task<FileResponseDto> GetFileAsync(string url);
    }
}

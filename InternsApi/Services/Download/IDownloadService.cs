using InternsApi.Models.DTO;

namespace InternsApi.Services.Download
{
    public interface IDownloadService
    {
        Task<FileResponseDto> GetFileAsync(string url);
    }
}

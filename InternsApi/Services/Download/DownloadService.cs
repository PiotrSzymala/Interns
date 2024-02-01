using System.Text;
using InternsApi.Models.DTO;

namespace InternsApi.Services.Download
{
    public class DownloadService : IDownloadService
    {
        private readonly HttpClient _client;

        public DownloadService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("FileClient");
        }

        public async Task<FileResponseDto> GetFileAsync(string url)
        {

            var result = await _client.GetAsync(_client.BaseAddress.AbsoluteUri + $"interns.{url}");

            result.EnsureSuccessStatusCode();

            var type = result.Content.Headers.ContentType.MediaType;

            var responseBodyBytes = await result.Content.ReadAsByteArrayAsync();

            string encodedContent = type == "application/zip" ?
                Convert.ToBase64String(responseBodyBytes) :
                Encoding.UTF8.GetString(responseBodyBytes);


            return new FileResponseDto
            {
                Response = encodedContent,
                ResponseType = type
            };
        }
    }
}

using InternsApi.Models;

namespace InternsApi.Services
{
    public class FileService : IFileService
    {
        private readonly HttpClient _client;

        public FileService(IHttpClientFactory clientFactory)
        {
            _client = clientFactory.CreateClient("FileClient");
        }

        public async Task<FileResponseDto> GetFileAsync(string url)
        {

            var result = await _client.GetAsync(_client.BaseAddress.AbsoluteUri + $"interns.{url}");

            var type = result.Content.Headers.ContentType.MediaType;

            var responseBody = await result.Content.ReadAsStringAsync();

            return new FileResponseDto
            {
                Response = responseBody,
                ResponseType = type
            };
        }
    }
}

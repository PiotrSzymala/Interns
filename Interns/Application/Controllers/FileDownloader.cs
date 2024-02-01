using System.Net;
using System.Reflection;

namespace Interns.Application.Controllers;

public static class FileDownloader
{

    public static async Task<DownloadResponseDTO> DownloadFile(string url)
    {
        try
        {
            using var client = new HttpClient();

            var response = await client.GetAsync(url);

            var responseBody = await response.Content.ReadAsStringAsync();

            var type = response.Content.Headers.ContentType.MediaType;


            return new DownloadResponseDTO()
            {
                Response = responseBody,
                ResponseType = type,
            };
        }
        catch (Exception)
        {
            Console.Error.Write("Error: Cannot get file.");
            throw;

        }
    }
}

public record DownloadResponseDTO
{
    public string Response { get; init; }
    public string ResponseType { get; init; }
}
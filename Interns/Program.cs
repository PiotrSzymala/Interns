using Interns.Application.Controllers;

namespace Interns;

internal class Program
{
    static async Task<int> Main(string[] args)
    {
        var test = await FileDownloader.DownloadFile("https://piotrszymala.github.io/Interns/interns.zip");
        return await AppRunner.Run(args);
    }
}
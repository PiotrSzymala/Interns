using System.CommandLine;
using System.CommandLine.IO;
using Interns.Application.Controllers;
using Interns.Application.Controllers.Deserialization;

namespace Interns.Application.Handlers;

internal static class OrderCommandHandler
{
    public static async Task HandleOrder(string url, bool desc, IConsole console)
    {
        var data = await FileDownloader.DownloadFile(url);

        if (string.IsNullOrEmpty(data.Response)) return;

        ParserFactory parserFactory = new ParserFactory();
        parserFactory.CreateParser()

        var fileDeserializer = DeserializationPicker.ChoseDeserializer(url, data.Response);
        var rootObject = fileDeserializer.Deserialize();

        if (rootObject.Interns != null)
        {
            var orderFormat = desc ? rootObject.Interns.OrderByDescending(i => i.Age) : rootObject.Interns.OrderBy(i => i.Age);

            foreach (var trainee in orderFormat)
            {
                console.Out.WriteLine(trainee.ToString());
            }
            Console.ReadKey(true);
        }
        else
        {
            console.Error.WriteLine("Error: Cannot process the file.");
        }
    }
}
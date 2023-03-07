using System.CommandLine;
using System.CommandLine.IO;
using Interns.Controllers;
using Interns.Controllers.Deserialization;
using Interns.Models;

namespace Interns.Handlers;

internal static class OrderCommandHandler
{
    public static void HandleOrder(string url, bool desc, IConsole console)
    {
        var data = FileDownloader.DownloadFile(url);
        if (string.IsNullOrEmpty(data)) return;

        var fileDeserializer = DeserializationPicker.ChoseDeserializer(url, data);
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
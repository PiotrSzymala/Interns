using System.CommandLine;
using System.CommandLine.IO;
using Interns.Application.Controllers;
using Interns.Application.Controllers.Deserialization;

namespace Interns.Application.Handlers;

internal static class MaxAgeCommandHandler
{
    public static async Task HandleMaxAge(string url, IConsole console)
    {
        var data = await FileDownloader.DownloadFile(url);

        if (string.IsNullOrEmpty(data.Response)) return;

        var fileDeserializer = DeserializationPicker.ChoseDeserializer(url, data.Response);

        var rootObject = fileDeserializer.Deserialize();

        if (rootObject.Interns != null)
        {
            var maxAge = rootObject.Interns.Max(i => i.Age);

            console.Out.WriteLine(maxAge.ToString());
            Console.ReadKey(true);
        }
        else
        {
            console.Error.WriteLine("Error: Cannot process the file.");
        }
    }
}
using System.CommandLine;
using System.CommandLine.IO;
using Interns.Controllers;
using Interns.Controllers.Deserialization;

namespace Interns.Handlers;

internal static class MaxAgeCommandHandler
{
    public static void HandleMaxAge(string url, IConsole console)
    {
        var data = FileDownloader.DownloadFile(url);

        if (string.IsNullOrEmpty(data)) return;

        var fileDeserializer = DeserializationPicker.ChoseDeserializer(url, data);

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
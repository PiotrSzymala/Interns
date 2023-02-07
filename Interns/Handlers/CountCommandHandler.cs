using System.CommandLine;
using System.CommandLine.IO;
using Interns.Controllers;
using Interns.Controllers.Deserialization;
using Interns.Models;

namespace Interns.Handlers;

internal static class CountCommandHandler
{
    public static void HandleCount(string url, int? ageGt, int? ageLt, IConsole console)
    {
        var data = FileDownloader.DownloadFile(url);

        if (string.IsNullOrEmpty(data)) return;

        var fileDeserializer = DeserializationPicker.ChoseDeserializer(url, data);

        var rootObject = fileDeserializer.Deserialize();

        if (rootObject.Interns != null)
        {
            int count = Count(ageGt, ageLt, rootObject);

            console.Out.WriteLine(count.ToString());
            Console.ReadKey(true);
        }
        else
        {
            console.Out.WriteLine("Error: Cannot process the file.");
        }
    }

    private static int Count(int? ageGt, int? ageLt, RootObject rootObject)
    {
        int count;
        if (ageGt != null)
        {
            count = rootObject.Interns.Count(i => i.Age > ageGt);
        }
        else if (ageLt != null)
        {
            count = rootObject.Interns.Count(i => i.Age < ageLt);
        }
        else
        {
            count = rootObject.Interns.Count;
        }

        return count;
    }
}
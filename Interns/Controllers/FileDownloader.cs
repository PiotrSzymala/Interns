using System.Net;
using System.Reflection;

namespace Interns.Controllers;

internal static class FileDownloader
{
    public static string DownloadFile(string url)
    {
        try
        {
            WebClient client;
            using (client = new WebClient())
            {
                if (url.Contains(".zip"))
                {
                    var archive = client.DownloadData(url);
                    return FileUnzipper.Unzip(archive);
                }

                return client.DownloadString(url);
            }
        }
        catch (WebException)
        {
            Console.Error.Write("Error: Cannot get file.");
            return string.Empty;

        }
        catch (TargetInvocationException)
        {
            return string.Empty;
        }
        catch (Exception)
        {
            return string.Empty;
        }
    }
}
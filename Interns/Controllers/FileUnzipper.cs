using System.IO.Compression;
using System.Text;

namespace Interns.Controllers;

internal static class FileUnzipper
{
    public static string Unzip(byte[] zippedBuffer)
    {
        using (var zippedStream = new MemoryStream(zippedBuffer))
        {
            using (var archive = new ZipArchive(zippedStream))
            {
                var entry = archive.Entries.FirstOrDefault();

                if (entry != null)
                {
                    using (var unzippedEntryStream = entry.Open())
                    {
                        using (var ms = new MemoryStream())
                        {
                            unzippedEntryStream.CopyTo(ms);
                            var unzippedArray = ms.ToArray();

                            return Encoding.Default.GetString(unzippedArray);
                        }
                    }
                }

                return string.Empty;
            }
        }
    }
}
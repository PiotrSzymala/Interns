using System.IO.Compression;
using System.Text;

namespace InternsApi.Services.Parsing.Zip
{
    public class ZipService : IZipService
    {
        public string ParseFromZip(byte[] zippedBuffer)
        {
            using var zippedStream = new MemoryStream(zippedBuffer);
            using var archive = new ZipArchive(zippedStream);
            var entry = archive.Entries.FirstOrDefault();

            if (entry == null)
                return string.Empty;

            using var unzippedEntryStream = entry.Open();
            using var ms = new MemoryStream();

            unzippedEntryStream.CopyTo(ms);

            var unzippedArray = ms.ToArray();

            return Encoding.Default.GetString(unzippedArray);
        }
    }
}

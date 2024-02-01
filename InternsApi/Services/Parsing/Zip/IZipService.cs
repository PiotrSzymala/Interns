namespace InternsApi.Services.Parsing.Zip
{
    public interface IZipService
    {
        string ParseFromZip(byte[] zippedBuffer);
    }
}

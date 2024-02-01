namespace InternsApi.Services
{
    public interface IZipService
    {
        string ParseFromZip(byte[] zippedBuffer);
    }
}

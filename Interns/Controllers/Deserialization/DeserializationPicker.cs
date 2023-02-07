namespace Interns.Controllers.Deserialization;

internal static class DeserializationPicker
{
    public static FileDeserializer ChoseDeserializer(string url, string data)
    {
        FileDeserializer fileDeserializer;
        if (url.Contains(@".csv") || url.Contains(@".zip"))
        {
            CsvDeserializer csvDeserializer = new CsvDeserializer();
            fileDeserializer = new FileDeserializer(data, csvDeserializer);
        }
        else
        {
            JsonDeserializer jsonDeserializer = new JsonDeserializer();
            fileDeserializer = new FileDeserializer(data, jsonDeserializer);
        }

        return fileDeserializer;
    }
}
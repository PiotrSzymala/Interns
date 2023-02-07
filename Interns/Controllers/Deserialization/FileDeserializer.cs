using Interns.Models;

namespace Interns.Controllers.Deserialization;

internal class FileDeserializer
{
    private readonly string _input;
    private readonly IFileTypeDistincter _deserializer;

    public FileDeserializer(string input, IFileTypeDistincter deserializer)
    {
        _input = input;
        _deserializer = deserializer;
    }

    public RootObject Deserialize()
    {
        return _deserializer.Deserialize(_input);
    }
}
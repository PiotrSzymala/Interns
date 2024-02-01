using Interns.Application.Models;

namespace Interns.Application.Controllers.Deserialization;

internal class FileDeserializer
{
    private readonly string _input;
    private readonly IParserStrategy _deserializer;

    public FileDeserializer(string input, IParserStrategy deserializer)
    {
        _input = input;
        _deserializer = deserializer;
    }

    public InternsResponse Deserialize()
    {
        return _deserializer.Parse(_input);
    }
}
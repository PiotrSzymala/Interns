using Interns.Models;
using Newtonsoft.Json;

namespace Interns.Controllers.Deserialization.Json;

internal class JsonDeserializer : IFileTypeDistincter
{
    public RootObject Deserialize(string input)
    {
        RootObject dataList = JsonConvert.DeserializeObject<RootObject>(input);

        return dataList;
    }
}
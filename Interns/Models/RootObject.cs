using Newtonsoft.Json;

namespace Interns.Models;

internal class RootObject
{
    [JsonProperty("interns")]
    public List<Intern>? Interns { get; set; }
}
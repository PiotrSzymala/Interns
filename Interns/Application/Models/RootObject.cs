using Newtonsoft.Json;

namespace Interns.Application.Models;

public class InternsResponse
{
    [JsonProperty("interns")]
    public List<Intern>? Interns { get; set; }
}
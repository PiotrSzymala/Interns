using Newtonsoft.Json;

namespace Interns.Models;

internal class Intern
{

    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("age")]
    public int Age { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime InternshipStart { get; set; }

    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime InternshipEnd { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Age: {Age}, Name: {Name}, Email: {Email}, InternshipStart: {InternshipStart}, InternshipEnd: {InternshipEnd} ";
    }
}
using InternsApi.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace InternsApi.Models
{
    public record Intern
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("age")]
        public int Age { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
       
        [JsonProperty("internshipStart")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime InternshipStart { get; set; }

        [JsonProperty("internshipEnd")]
        [JsonConverter(typeof(CustomDateTimeConverter))]
        public DateTime InternshipEnd { get; set; }
    }
}

using Newtonsoft.Json;

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
        public DateTime InternshipStart { get; set; }

        [JsonProperty("internshipEnd")]
        public DateTime InternshipEnd { get; set; }
    }
}

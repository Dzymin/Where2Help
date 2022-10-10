using System.Text.Json.Serialization;

namespace WebApp.Models
{
    public class LocationModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        
        [JsonPropertyName("latitude")]
        public double Latitude { get; set; }
        
        [JsonPropertyName("longtitude")]
        public double Longitude { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}

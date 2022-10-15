using System.Text.Json.Serialization;

namespace WebApp.Models
{
    public class LocationModel
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }
        
        [JsonPropertyName("latitude")]
        public float Latitude { get; set; }
        
        [JsonPropertyName("longtitude")]
        public float Longitude { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }
    }
}

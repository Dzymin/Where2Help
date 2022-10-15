namespace Backend.Models
{
    public class Location
    {
        public long Id { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Activity>? Activities = new List<Activity>();
    }
}

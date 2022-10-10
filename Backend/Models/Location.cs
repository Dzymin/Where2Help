namespace Backend.Models
{
    public class Location
    {
        public long Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<Activity>? Activities { get; set; }
    }
}

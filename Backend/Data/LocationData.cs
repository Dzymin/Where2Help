using Backend.Models;
using System.Collections.ObjectModel;

namespace Backend.Data
{
    public class LocationData
    {
        //TODO: Zapis i odczyt z bazy danych. W celach testowych lokalizacje zapisywane są lokalnie in-memory.
        private Dictionary<long, Location> _locations = new Dictionary<long, Location>();

        public void InitializeLocationData()
        {
            Location exampleLocation = new Location();
            exampleLocation.Id = 1;
            exampleLocation.Latitude = 51;
            exampleLocation.Longitude = 21;
            exampleLocation.Name = "Example";
            exampleLocation.Description = "Example location for testing";

            Activity exampleActivity = new Activity();
            exampleActivity.Id = 1;
            exampleActivity.Name = "Example Activity";
            exampleActivity.Description = "Lorem ipsum dolor sit amet. Et omnis dolor ab autem eligendi et voluptatem quae ut voluptates adipisci in quod accusamus.";

            exampleLocation.Activities.Add(exampleActivity);

            _locations.Add(exampleLocation.Id, exampleLocation);
        }

        public Location GetLocation(long id)
        {
            return _locations[id];
        }
    }
}

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

            _locations.Add(exampleLocation.Id, exampleLocation);
        }

        public Location GetLocation(long id)
        {
            return _locations[id];
        }
    }
}

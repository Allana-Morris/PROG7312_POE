using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.Models.Enums;

namespace PROG7312_POE.Class
{
    public class EventManagement
    {
        public static SortedDictionary<int, EventClass> EventStorage = [];

        public static Dictionary<DateTime, List<EventClass>> EventDateSort = [];
        public static Dictionary<RequestCategory, List<EventClass>> EventCategorySort = [];

        private Dictionary<RequestCategory, int> categorySelectionCounts = new Dictionary<RequestCategory, int>();

        public SimplePriorityQueue<AnnouncementClass, int> announcementQueue = new();

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public EventManagement()
        {
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that Returns all the events in EventStorage 
        /// </summary>
        public List<EventClass> GetAll()
        {
            try
            {
                List<EventClass> allEvents = EventStorage
                    .Select(entry => entry.Value)
                    .ToList();

                return allEvents;
            }
            catch (Exception)
            {
                return [];
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that returns all Events that the filtered Categories & Dates apply to
        /// </summary>
        public List<EventClass> CategoryandDateFilter(List<RequestCategory> selectedCategories, DateTime From, DateTime To)
        {
            try
            {
                HashSet<RequestCategory> hashcategories = new(selectedCategories);

                var SelectedEvents = EventDateSort
                    .Where(dateEntry => dateEntry.Key >= From && dateEntry.Key <= To)
                    .SelectMany(dateEntry => dateEntry.Value)
                    .Where(evt => hashcategories.Contains(evt.EventCategory))
                    .ToList();

                return SelectedEvents;
            }
            catch
            {
                return null;
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that returns all Events that the filtered Dates apply to
        /// </summary>
        public List<EventClass> DateFilter(DateTime From, DateTime To)
        {
            try
            {
                var SelectedEvents = EventDateSort
                    .Where(dateEntry => dateEntry.Key >= From && dateEntry.Key <= To)
                    .SelectMany(dateEntry => dateEntry.Value)
                    .ToList();
                return SelectedEvents;
            }
            catch (Exception)
            {
                return null;
            }

        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that returns all Events that the filtered Categories apply to
        /// </summary>
        public List<EventClass> CategoryFilter(List<string> selectedCategories)
        {
            HashSet<string> HashCategory = new(selectedCategories);
            try
            {
                var SelectedEvents = EventCategorySort
                    .Where(cat => HashCategory.Contains(cat.Key.ToString()))
                    .SelectMany(cat => cat.Value)
                    .ToList();
                return SelectedEvents;
            }
            catch (Exception)
            {
                return [];
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that returns Coordinates from CityCoordinates using parsed SouthAfricanCities
        /// </summary>
        public (double, double) GetCoordinates(SouthAfricanCities city)
        {
            Coordinates.SouthAfricanCityCoordinates.TryGetValue(city, out var coordinates);
            return coordinates;
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that calculates the approximate distance between the two locations
        /// </summary>
        public static double CalculateDistance((double Latitude, double Longitude) loc1, (double Latitude, double Longitude) loc2)
        {
            double R = 6371; // Radius of Earth in kilometers
            double dLat = (loc2.Latitude - loc1.Latitude) * (Math.PI / 180);
            double dLon = (loc2.Longitude - loc1.Longitude) * (Math.PI / 180);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(loc1.Latitude * (Math.PI / 180)) * Math.Cos(loc2.Latitude * (Math.PI / 180)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Distance in kilometers
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Function that returns all the Event Objects that will be recommended to the Customer based on the searched Categories, Dates and their location
        /// </summary>
        public List<EventClass> SuggestEvents(List<RequestCategory> selectedCategories, DateTime startDate, DateTime endDate, SouthAfricanCities userCity, List<EventClass> allEvents, double maxDistanceKm = 50) // Max distance for proximity filtering
        {
            // Step 1: Filter by category and date
            var suggestedEvents = categorySelectionCounts
            .OrderByDescending(c => c.Value)
            .Take(3) // Get top 3 categories, or you can adjust based on your needs
            .Select(c => c.Key)
            .ToList();

            var filteredEvents = allEvents
            .Where(e => suggestedEvents.Contains(e.EventCategory))
            .ToList();

            // Step 2: Filter by location (city-based or proximity-based)
            var coords = GetCoordinates(userCity);
            // Proximity-based filtering
            filteredEvents = filteredEvents
                .Where(e => e.EventLocation != default &&
                            CalculateDistance(coords, GetCoordinates(e.EventLocation)) <= maxDistanceKm)
                .ToList();

            return filteredEvents;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// ChatGPT Created this for Me
        /// </summary>
        public void LoadEvents()
        {
            try
            {
                var events = new List<EventClass>
            {
                new(1, "Water Quality Awareness Campaign", new DateTime(2024, 10, 15), RequestCategory.WaterSanitation, SouthAfricanCities.Kimberley),
                new(2, "Loadshedding Management Workshop", new DateTime(2025, 1, 22), RequestCategory.ElectricityLoadshedding, SouthAfricanCities.Pretoria),
                new(3, "Pothole Repair Initiative", new DateTime(2025, 3, 10), RequestCategory.RoadsPotholes, SouthAfricanCities.DeAar),
                new(4, "Waste Disposal Education Drive", new DateTime(2025, 5, 5), RequestCategory.WasteManagement, SouthAfricanCities.Durban),
                new(5, "Public Transport Improvement Forum", new DateTime(2024, 6, 20), RequestCategory.PublicTransport, SouthAfricanCities.Johannesburg),
                new(6, "Community Safety Fair", new DateTime(2025, 7, 18), RequestCategory.CommunitySafetySecurity, SouthAfricanCities.CapeTown),
                new(7, "Parks Clean-Up Day", new DateTime(2025, 2, 14), RequestCategory.ParksPublicSpaces, SouthAfricanCities.Polokwane),
                new(8, "Affordable Housing Expo", new DateTime(2024, 4, 22), RequestCategory.Housing, SouthAfricanCities.Bloemfontein),
                new(9, "Noise Reduction Awareness Week", new DateTime(2024, 8, 30), RequestCategory.NoiseComplaints, SouthAfricanCities.Mbombela),
                new(10, "Environmental Health Workshop", new DateTime(2025, 9, 15), RequestCategory.EnvironmentalHealth, SouthAfricanCities.EastLondon),
                new(11, "Traffic Safety Forum", new DateTime(2024, 11, 11), RequestCategory.TrafficTransportInfrastructure, SouthAfricanCities.Gqeberha),
                new(12, "Wildlife Protection Awareness Day", new DateTime(2025, 12, 12), RequestCategory.AnimalControlWildlife, SouthAfricanCities.Stellenbosch),
                new(13, "Clean Water Drive", new DateTime(2025, 1, 8), RequestCategory.WaterSanitation, SouthAfricanCities.Upington),
                new(14, "Solar Energy Awareness Seminar", new DateTime(2025, 3, 3), RequestCategory.ElectricityLoadshedding, SouthAfricanCities.Rustenburg),
                new(15, "Road Safety Campaign", new DateTime(2025, 6, 25), RequestCategory.RoadsPotholes, SouthAfricanCities.Vereeniging),
                new(16, "Waste Sorting Workshop", new DateTime(2024, 5, 10), RequestCategory.WasteManagement, SouthAfricanCities.Pietermaritzburg),
                new(17, "Public Transport Safety Training", new DateTime(2025, 8, 4), RequestCategory.PublicTransport, SouthAfricanCities.Benoni),
                new(18, "Community Security Meeting", new DateTime(2024, 10, 20), RequestCategory.CommunitySafetySecurity, SouthAfricanCities.Klerksdorp),
                new(19, "Urban Gardening Workshop", new DateTime(2024, 11, 30), RequestCategory.ParksPublicSpaces, SouthAfricanCities.Hermanus),
                new(20, "Housing Rights Forum", new DateTime(2025, 1, 15), RequestCategory.Housing, SouthAfricanCities.Makhado),
                new(21, "Sound Awareness Week", new DateTime(2025, 2, 27), RequestCategory.NoiseComplaints, SouthAfricanCities.Welkom),
                new(22, "Clean Air Workshop", new DateTime(2025, 3, 29), RequestCategory.EnvironmentalHealth, SouthAfricanCities.Stellenbosch),
                new(23, "Road Maintenance Initiative", new DateTime(2024, 4, 10), RequestCategory.TrafficTransportInfrastructure, SouthAfricanCities.Kuruman),
                new(24, "Animal Rescue Day", new DateTime(2025, 6, 1), RequestCategory.AnimalControlWildlife, SouthAfricanCities.MosselBay),
                new(25, "Rainwater Harvesting Workshop", new DateTime(2025, 8, 12), RequestCategory.WaterSanitation, SouthAfricanCities.Lichtenburg),
                new(26, "Renewable Energy Fair", new DateTime(2024, 9, 20), RequestCategory.ElectricityLoadshedding, SouthAfricanCities.Springs),
                new(27, "Community Road Safety Training", new DateTime(2025, 10, 5), RequestCategory.RoadsPotholes, SouthAfricanCities.Queenstown),
                new(28, "Waste Reduction Initiative", new DateTime(2024, 11, 22), RequestCategory.WasteManagement, SouthAfricanCities.Ceres),
                new(29, "Public Transport User Feedback Session", new DateTime(2025, 12, 15), RequestCategory.PublicTransport, SouthAfricanCities.Paarl),
                new(30, "Emergency Services Awareness Day", new DateTime(2025, 2, 10), RequestCategory.CommunitySafetySecurity, SouthAfricanCities.Witbank)
            };

                foreach (var eventItem in events)
                {
                    // Load into EventStorage
                    EventStorage.Add(eventItem.EventID, eventItem);

                    // Load into EventDateSort
                    if (!EventDateSort.ContainsKey(eventItem.EventDate))
                    {
                        EventDateSort[eventItem.EventDate] = [];
                    }
                    EventDateSort[eventItem.EventDate].Add(eventItem);

                    // Load into EventCategorySort
                    if (!EventCategorySort.ContainsKey(eventItem.EventCategory))
                    {
                        EventCategorySort[eventItem.EventCategory] = [];
                    }
                    EventCategorySort[eventItem.EventCategory].Add(eventItem);
                }
            }
            catch (Exception) { }
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//
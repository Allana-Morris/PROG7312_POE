using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class EventManagement
    {
        public static SortedDictionary<int, EventClass> EventStorage = new SortedDictionary<int, EventClass>();

        public static Dictionary<DateTime, List<EventClass>> EventDateSort = new Dictionary<DateTime, List<EventClass>>();
        public static Dictionary<string, List<EventClass>> EventCategorySort = new Dictionary<string, List<EventClass>>();

        public PriorityQueue<AnnouncementClass, int> announcementQueue = new PriorityQueue<AnnouncementClass, int>();

        public EventManagement()
        {

        }



        public List<EventClass> GetAll()
        {
            List<EventClass> allEvents = EventStorage
                .Select(entry => entry.Value)
                .ToList();

            return allEvents;
        }

        public List<EventClass> CategoryandDateFilter(List<string> selectedCategories, DateTime From, DateTime To)
        {
            HashSet<string> hashcategories = new HashSet<string>(selectedCategories);

            var SelectedEvents = EventDateSort
                .Where(dateEntry => dateEntry.Key >= From && dateEntry.Key <= To)
                .SelectMany(dateEntry => dateEntry.Value)
                .Where(evt => hashcategories.Contains(evt.EventCategory))
                .ToList();

            return SelectedEvents;
        }

        public List<EventClass> DateFilter(DateTime From, DateTime To)
        {
            var SelectedEvents = EventDateSort
                .Where(dateEntry => dateEntry.Key >= From && dateEntry.Key <= To)
                .SelectMany(dateEntry => dateEntry.Value)
                .ToList();
            return SelectedEvents;
        }

        public List<EventClass> CategoryFilter(List<string> selectedCategories)
        {
            HashSet<string> HashCategory = new HashSet<string>(selectedCategories);

            var SelectedEvents = EventCategorySort
                .Where(cat => HashCategory.Contains(cat.Key))
                .SelectMany(cat => cat.Value)
                .ToList();

            return SelectedEvents;
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// ChatGPT Created this for Me, Screenchots of the Conversation will be provided
        /// </summary>
        public void LoadEvents()
        {
            List<EventClass> events = new List<EventClass>
            {
                new EventClass(1, "Water Quality Awareness Campaign", new DateTime(2024, 10, 15), "Water and Sanitation"),
                new EventClass(2, "Loadshedding Management Workshop", new DateTime(2025, 1, 22), "Electricity and Loadshedding"),
                new EventClass(3, "Pothole Repair Initiative", new DateTime(2025, 3, 10), "Roads and Potholes"),
                new EventClass(4, "Waste Disposal Education Drive", new DateTime(2025, 5, 5), "Waste Management"),
                new EventClass(5, "Public Transport Improvement Forum", new DateTime(2024, 6, 20), "Public Transport"),
                new EventClass(6, "Community Safety Fair", new DateTime(2025, 7, 18), "Community Safety and Security"),
                new EventClass(7, "Parks Clean-Up Day", new DateTime(2025, 2, 14), "Parks and Public Spaces"),
                new EventClass(8, "Affordable Housing Expo", new DateTime(2024, 4, 22), "Housing"),
                new EventClass(9, "Noise Reduction Awareness Week", new DateTime(2024, 8, 30), "Noise Complaints"),
                new EventClass(10, "Environmental Health Workshop", new DateTime(2025, 9, 15), "Environmental Health"),
                new EventClass(11, "Traffic Safety Forum", new DateTime(2024, 11, 11), "Traffic and Transport Infrastructure"),
                new EventClass(12, "Wildlife Protection Awareness Day", new DateTime(2025, 12, 12), "Animal Control and Wildlife"),
                new EventClass(13, "Clean Water Drive", new DateTime(2025, 1, 8), "Water and Sanitation"),
                new EventClass(14, "Solar Energy Awareness Seminar", new DateTime(2025, 3, 3), "Electricity and Loadshedding"),
                new EventClass(15, "Road Safety Campaign", new DateTime(2025, 6, 25), "Roads and Potholes"),
                new EventClass(16, "Waste Sorting Workshop", new DateTime(2024, 5, 10), "Waste Management"),
                new EventClass(17, "Public Transport Safety Training", new DateTime(2025, 8, 4), "Public Transport"),
                new EventClass(18, "Community Security Meeting", new DateTime(2024, 10, 20), "Community Safety and Security"),
                new EventClass(19, "Urban Gardening Workshop", new DateTime(2024, 11, 30), "Parks and Public Spaces"),
                new EventClass(20, "Housing Rights Forum", new DateTime(2025, 1, 15), "Housing"),
                new EventClass(21, "Sound Awareness Week", new DateTime(2025, 2, 27), "Noise Complaints"),
                new EventClass(22, "Clean Air Workshop", new DateTime(2025, 3, 29), "Environmental Health"),
                new EventClass(23, "Road Maintenance Initiative", new DateTime(2024, 4, 10), "Traffic and Transport Infrastructure"),
                new EventClass(24, "Animal Rescue Day", new DateTime(2025, 6, 1), "Animal Control and Wildlife"),
                new EventClass(25, "Rainwater Harvesting Workshop", new DateTime(2025, 8, 12), "Water and Sanitation"),
                new EventClass(26, "Renewable Energy Fair", new DateTime(2024, 9, 20), "Electricity and Loadshedding"),
                new EventClass(27, "Community Road Safety Training", new DateTime(2025, 10, 5), "Roads and Potholes"),
                new EventClass(28, "Waste Reduction Initiative", new DateTime(2024, 11, 22), "Waste Management"),
                new EventClass(29, "Public Transport User Feedback Session", new DateTime(2025, 12, 15), "Public Transport"),
                new EventClass(30, "Emergency Services Awareness Day", new DateTime(2025, 2, 10), "Community Safety and Security")
            };
            foreach (var eventItem in events)
            {
                // Load into EventStorage
                EventStorage.Add(eventItem.EventID, eventItem);

                // Load into EventDateSort
                if (!EventDateSort.ContainsKey(eventItem.EventDate))
                {
                    EventDateSort[eventItem.EventDate] = new List<EventClass>();
                }
                EventDateSort[eventItem.EventDate].Add(eventItem);

                // Load into EventCategorySort
                if (!EventCategorySort.ContainsKey(eventItem.EventCategory))
                {
                    EventCategorySort[eventItem.EventCategory] = new List<EventClass>();
                }
                EventCategorySort[eventItem.EventCategory].Add(eventItem);
            }
        }
    }
}

using GMap.NET.WindowsForms;
using PROG7312_POE.Class.Models.Enums.PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROG7312_POE
{
    public partial class DataVisual : Form
    {
        SouthAfricanCityCoordinates sacc = new SouthAfricanCityCoordinates();
        public DataVisual()
        {
            InitializeComponent();
        }

        public List<List<ReportedRequest>> ClusterRequestsByProximity(List<ReportedRequest> requests, double maxDistanceKm)
        {
            var clusters = new List<List<ReportedRequest>>();

            foreach (var request in requests)
            {
                bool addedToCluster = false;

                foreach (var cluster in clusters)
                {
                    var firstRequest = cluster.First(); // Use the first request in the cluster as the "center"

                    // Get coordinates of the cluster center (first request)
                    var firstRequestCoordinates = sacc.GetCityCoordinates(firstRequest.UserLocation);

                    // Get coordinates of the current request
                    var currentRequestCoordinates = sacc.GetCityCoordinates(request.UserLocation);

                    // Calculate the distance between the two requests
                    double distance = GetDistance(firstRequestCoordinates.Latitude, firstRequestCoordinates.Longitude, currentRequestCoordinates.Latitude, currentRequestCoordinates.Longitude);

                    if (distance <= maxDistanceKm) // If within max distance, add to cluster
                    {
                        cluster.Add(request);
                        addedToCluster = true;
                        break;
                    }
                }

                // If the request wasn't added to an existing cluster, create a new cluster
                if (!addedToCluster)
                {
                    clusters.Add(new List<ReportedRequest> { request });
                }
            }

            return clusters;
        }

        public double GetDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double EarthRadiusKm = 6371.0; // Radius of the Earth in kilometers

            // Convert degrees to radians
            double lat1Rad = DegreesToRadians(lat1);
            double lon1Rad = DegreesToRadians(lon1);
            double lat2Rad = DegreesToRadians(lat2);
            double lon2Rad = DegreesToRadians(lon2);

            // Calculate the differences
            double dLat = lat2Rad - lat1Rad;
            double dLon = lon2Rad - lon1Rad;

            // Haversine formula
            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Calculate the distance in kilometers
            double distance = EarthRadiusKm * c;
            return distance;
        }

        // Helper method to convert degrees to radians
        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }

}


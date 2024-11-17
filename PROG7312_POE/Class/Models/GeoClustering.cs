using PROG7312_POE.Class.Models.Enums.PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PROG7312_POE.Class.Models.GeoClustering
{
    public class GeoClustering
    {
        public int NumberOfClusters { get; private set; }
        public List<Cluster> Clusters { get; private set; }

        public GeoClustering(int numberOfClusters)
        {
            NumberOfClusters = numberOfClusters;
            Clusters = new List<Cluster>();
        }

        public void PerformClustering()
        {
            // Step 1: Load coordinates from the SouthAfricanCityCoordinates
            var cityCoordinates = SouthAfricanCityCoordinates.Coordinates.ToList();

            // Step 2: Initialize clusters with random centroids
            var random = new Random();
            Clusters = Enumerable.Range(0, NumberOfClusters)
                .Select(i => new Cluster(cityCoordinates[random.Next(cityCoordinates.Count)].Value))
                .ToList();

            bool hasConverged;
            do
            {
                // Step 3: Assign cities to the nearest cluster
                foreach (var cluster in Clusters)
                {
                    cluster.Cities.Clear();
                }

                foreach (var (city, coordinates) in cityCoordinates)
                {
                    var closestCluster = Clusters.OrderBy(cluster =>
                        CalculateDistance(cluster.Centroid, coordinates)).First();

                    closestCluster.Cities.Add((city, coordinates));
                }

                // Step 4: Recalculate cluster centroids
                hasConverged = true;
                foreach (var cluster in Clusters)
                {
                    var newCentroid = cluster.CalculateNewCentroid();
                    if (!cluster.Centroid.Equals(newCentroid))
                    {
                        hasConverged = false;
                        cluster.Centroid = newCentroid;
                    }
                }

            } while (!hasConverged);
        }

        private double CalculateDistance((double Latitude, double Longitude) point1, (double Latitude, double Longitude) point2)
        {
            // Use Euclidean distance for simplicity
            var latDiff = point1.Latitude - point2.Latitude;
            var lonDiff = point1.Longitude - point2.Longitude;
            return Math.Sqrt(latDiff * latDiff + lonDiff * lonDiff);
        }
    }

    public class Cluster
    {
        public (double Latitude, double Longitude) Centroid { get; set; }
        public List<(SouthAfricanCities City, (double Latitude, double Longitude) Coordinates)> Cities { get; private set; }

        public Cluster((double Latitude, double Longitude) initialCentroid)
        {
            Centroid = initialCentroid;
            Cities = new List<(SouthAfricanCities, (double, double))>();
        }

        public (double Latitude, double Longitude) CalculateNewCentroid()
        {
            if (!Cities.Any())
                return Centroid;

            var avgLatitude = Cities.Average(c => c.Coordinates.Latitude);
            var avgLongitude = Cities.Average(c => c.Coordinates.Longitude);
            return (avgLatitude, avgLongitude);
        }
    }
}

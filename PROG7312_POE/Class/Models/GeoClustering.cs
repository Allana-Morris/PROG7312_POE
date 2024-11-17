using System;
using System.Collections.Generic;
using System.Linq;
using PROG7312_POE.Class.Models.Enums;

namespace PROG7312_POE.Class.Models.GeoClustering
{
    public class GeoClustering
    {
        public Dictionary<string, HashSet<ReportedRequest>> ProvinceClusters { get; private set; }

        // Constructor initializes the ProvinceClusters
        public GeoClustering()
        {
            ProvinceClusters = new Dictionary<string, HashSet<ReportedRequest>>();
            // Initialize HashSets for each province
            foreach (var province in SouthAfricanProvinces.GroupedCitiesByProvince.Keys)
            {
                ProvinceClusters[province] = new HashSet<ReportedRequest>();
            }
        }

        // Simulate getting ReportedRequest objects (you can replace this with your actual method)


        public Dictionary<string, HashSet<ReportedRequest>> PerformClustering()
        {
            RedBlackTree rbt = new RedBlackTree();
            // Step 1: Get all the reported requests
            var requests = rbt.GetRequestsForListView();

            // Step 2: Group requests by province based on the Location city
            foreach (var request in requests)
            {
                // Get the province for the current city
                var province = GetProvinceForCity(request.UserLocation);

                // Add the request to the appropriate province cluster
                AddRequestToProvinceCluster(province, request);
            }

            return ProvinceClusters;
        }

        // Helper method to get the province for a given city
        private string GetProvinceForCity(SouthAfricanCities city)
        {
            foreach (var province in SouthAfricanProvinces.GroupedCitiesByProvince)
            {
                if (province.Value.Any(cityInfo => cityInfo.City == city))
                {
                    return province.Key;
                }
            }

            // Default to "Unknown" if the city is not found in any province
            return "Unknown";
        }

        // Helper method to add the request to the correct province cluster
        private void AddRequestToProvinceCluster(string province, ReportedRequest request)
        {
            if (ProvinceClusters.ContainsKey(province))
            {
                ProvinceClusters[province].Add(request);
            }
        }
    }
}

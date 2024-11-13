using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PROG7312_POE
{
    public enum IssueCategory
    {
        [Description("Water and Sanitation")]
        WaterSanitation,

        [Description("Electricity and Loadshedding")]
        ElectricityLoadshedding,

        [Description("Roads and Potholes")]
        RoadsPotholes,

        [Description("Waste Management")]
        WasteManagement,

        [Description("Public Transport")]
        PublicTransport,

        [Description("Community Safety and Security")]
        CommunitySafetySecurity,

        [Description("Parks and Public Spaces")]
        ParksPublicSpaces,

        [Description("Housing")]
        Housing,

        [Description("Noise Complaints")]
        NoiseComplaints,

        [Description("Environmental Health")]
        EnvironmentalHealth,

        [Description("Traffic and Transport Infrastructure")]
        TrafficTransportInfrastructure,

        [Description("Animal Control and Wildlife")]
        AnimalControlWildlife
    }

    public enum IssueStatus
    {
        [Description("Pending")]
        Pending,
        [Description("In Progress")]
        InProgress,
        [Description("Resolved")]
        Resolved
    }

    public class IssueClass
    {
        public List<IssueCategory> categoryList = new List<IssueCategory>
        {
            IssueCategory.WaterSanitation,
            IssueCategory.ElectricityLoadshedding,
            IssueCategory.RoadsPotholes,
            IssueCategory.WasteManagement,
            IssueCategory.PublicTransport,
            IssueCategory.CommunitySafetySecurity,
            IssueCategory.ParksPublicSpaces,
            IssueCategory.Housing,
            IssueCategory.NoiseComplaints,
            IssueCategory.EnvironmentalHealth,
            IssueCategory.TrafficTransportInfrastructure,
            IssueCategory.AnimalControlWildlife
        };

        public Guid userId { get; set; }
        public string userLocation { get; set; }
        public IssueCategory userCategory { get; set; }
        public string userDescription { get; set; }
        public string userFileName { get; set; }
        public byte[] userFileData { get; set; }
        public DateTime userSubmissionDate { get; set; }
        public IssueStatus userStatus { get; set; }

        public IssueClass() { }

        public IssueClass(string location, IssueCategory category, string description, string filename, byte[] filedata)
        {
            this.userId = Guid.NewGuid();  // Automatically generate a unique ID
            this.userLocation = location;
            this.userCategory = category;
            this.userDescription = description;
            this.userFileName = filename;
            this.userFileData = filedata;
            this.userSubmissionDate = DateTime.Now;
            this.userStatus = IssueStatus.Pending;  // Default status is Pending
        }
    }
}

using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models;
using System.ComponentModel;
using System;

// Combine the RequestPriority with IssueCategory for consistency
public class ReportedRequest : IComparable<ReportedRequest>
{
    public Guid RequestId { get; private set; }
    public Customer Customer { get; set; }
    public DateTime RequestDate { get; private set; }
    public DateTime LastUpdated { get; set; }
    public string Description { get; set; }
    public RequestCategory Category { get; set; }
    public RequestStatus Status { get; set; }
    public int Progress { get; set; }
    public string UserLocation { get; set; }
    public string UserFileName { get; set; }
    public byte[] UserFileData { get; set; }

    public ReportedRequest() { }

    public ReportedRequest(Customer customer, string description, RequestCategory category, string location, string filename, byte[] filedata)
    {
        RequestId = Guid.NewGuid();
        Customer = customer;
        RequestDate = DateTime.Now;
        LastUpdated = DateTime.Now;
        Description = description;
        Category = category;
        UserLocation = location;
        UserFileName = filename;
        UserFileData = filedata;
        Status = RequestStatus.Pending;
        Progress = 0;
    }

    public void UpdateStatus(RequestStatus newStatus, int progress)
    {
        Status = newStatus;
        Progress = progress;
        LastUpdated = DateTime.Now;
    }

    public int CompareTo(ReportedRequest other)
    {
        return RequestId.CompareTo(other.RequestId);
    }

    internal ReportedRequest(Guid requestId)
    {
        RequestId = requestId;
    }

    // Method to assign priority based on the IssueCategory
    public RequestPriority AssignPriority(RequestCategory category)
    {
        return category switch
        {
            RequestCategory.WaterSanitation => RequestPriority.High,
            RequestCategory.ElectricityLoadshedding => RequestPriority.High,
            RequestCategory.CommunitySafetySecurity => RequestPriority.High,
            RequestCategory.EnvironmentalHealth => RequestPriority.High,

            RequestCategory.RoadsPotholes => RequestPriority.Medium,
            RequestCategory.WasteManagement => RequestPriority.Medium,
            RequestCategory.PublicTransport => RequestPriority.Medium,
            RequestCategory.Housing => RequestPriority.Medium,
            RequestCategory.TrafficTransportInfrastructure => RequestPriority.Medium,
            RequestCategory.AnimalControlWildlife => RequestPriority.Medium,

            RequestCategory.ParksPublicSpaces => RequestPriority.Low,
            RequestCategory.NoiseComplaints => RequestPriority.Low,

            _ => RequestPriority.Low
        };
    }
}

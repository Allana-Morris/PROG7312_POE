using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models;
using System.ComponentModel;
using System;

// Combine the RequestPriority with IssueCategory for consistency
public class ReportedRequest : IComparable<ReportedRequest>
{
    public Guid RequestId { get; private set; }
    public string RequestName { get; private set; }
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
        RequestId = new Guid();
        Customer = customer;
        RequestDate = DateTime.Now;
        LastUpdated = DateTime.Now;
        Description = description;
        Category = category;
        UserLocation = location;
        UserFileName = filename;
        UserFileData = filedata;
        Status = RequestStatus.Open;
        Progress = 0;
    }

    public ReportedRequest(int id, ReportedRequest rr)
    {
        RequestId = rr.RequestId;
        RequestName = GenerateCustomRequestId(id);
        Customer = rr.Customer;
        RequestDate = rr.RequestDate;
        LastUpdated = rr.LastUpdated;
        Description = rr.Description;
        Category = rr.Category;
        UserLocation = rr.UserLocation;
        UserFileName = rr.UserFileName;
        UserFileData = rr.UserFileData;
        Status = rr.Status;
        Progress = rr.Progress;
    }

    public void UpdateStatus(int progress, DateTime updateTime)
    {
        if (progress > 0 && progress < 100)
        {
            Status = RequestStatus.InProgress;
        }
        else if (progress == 100)
        {
            Status = RequestStatus.Closed;
        }
        else
        {
            Status = RequestStatus.Open;
        }
        Progress = progress;
        //LastUpdated = DateTime.Now;
        LastUpdated = updateTime;
    }

    private string GenerateCustomRequestId(int id)
    {
        return $"REP{id:D3}"; // D3 formats the number as a 3-digit string, e.g., "REP001"
    }

    public int CompareTo(ReportedRequest other)
    {
        if (other == null) return 1; // To handle null comparisons
        return this.RequestId.CompareTo(other.RequestId);
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

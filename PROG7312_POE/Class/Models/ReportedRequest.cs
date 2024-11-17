using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

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
    public SouthAfricanCities UserLocation { get; set; }
    public List<string> UserFileNames { get; set; } = new List<string>();
    public List<byte[]> UserFileData { get; set; } = new List<byte[]>();


    public ReportedRequest() { }

    public ReportedRequest(Customer customer, string description, RequestCategory category, SouthAfricanCities location, string filename, byte[] filedata)
    {
        RequestId = new Guid();
        Customer = customer;
        RequestDate = DateTime.Now;
        LastUpdated = DateTime.Now;
        Description = description;
        Category = category;
        UserLocation = location;
        AddFile(filename, filedata);
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
        UserFileNames = rr.UserFileNames;
        UserFileData = rr.UserFileData;
        Status = rr.Status;
        Progress = rr.Progress;
    }

    // Method to add a file (to control how files are added)
    public void AddFile(string filename, byte[] filedata)
    {
        if (string.IsNullOrWhiteSpace(filename))
            throw new ArgumentException("Filename cannot be null or empty", nameof(filename));
        if (filedata == null || filedata.Length == 0)
            throw new ArgumentException("File data cannot be null or empty", nameof(filedata));

        UserFileNames.Add(filename);
        UserFileData.Add(filedata);
    }

    // Optionally: Method to remove a file by filename (or index, depending on your use case)
    public bool RemoveFile(string filename)
    {
        var index = UserFileNames.IndexOf(filename);
        if (index >= 0)
        {
            UserFileNames.RemoveAt(index);
            UserFileData.RemoveAt(index);
            return true;
        }
        return false;  // Return false if file was not found
    }

    // Optionally: Method to remove a file by index
    public bool RemoveFileAt(int index)
    {
        if (index >= 0 && index < UserFileNames.Count)
        {
            UserFileNames.RemoveAt(index);
            UserFileData.RemoveAt(index);
            return true;
        }
        return false;  // Return false if index is out of range
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

    public void LoadExampleRequests()
    {
        var random = new Random();
        RedBlackTree rbt = new RedBlackTree();


        for (int i = 1; i <= 30; i++)
        {

            // Create a new ReportedRequest
            var req = new ReportedRequest
            {
                RequestId = Guid.NewGuid(),
                RequestName = $"Request {i}",
                Customer = new Customer($"Customer {i}",
                     $"Customer {i}",
                     $"customer{i}@example.com"),
                RequestDate = DateTime.Now.AddDays(-random.Next(1, 100)),
                LastUpdated = DateTime.Now.AddDays(-random.Next(0, 10)),
                Description = $"Description for Request {i}",

                // Ensuring Category is not "None"
                Category = (RequestCategory)random.Next(1, Enum.GetValues(typeof(RequestCategory)).Length),

                // Ensuring Status is not "None"
                Status = (RequestStatus)random.Next(1, Enum.GetValues(typeof(RequestStatus)).Length),

                Progress = random.Next(0, 101), // Progress percentage

                // Ensuring UserLocation (city) is not "None"
                UserLocation = (SouthAfricanCities)random.Next(1, Enum.GetValues(typeof(SouthAfricanCities)).Length),

                UserFileNames = new List<string> { $"file{i}.txt", $"image{i}.png" },
                UserFileData = new List<byte[]>
    {
        new byte[] { 0x1, 0x2, 0x3 },
        new byte[] { 0x4, 0x5, 0x6 }
    }
            };

            rbt.Insert(req);

        }

    }
}

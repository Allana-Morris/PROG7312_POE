using PROG7312_POE.Class.Models.Enums;
using PROG7312_POE.Class.Models;
using System;
using System.Collections.Generic;

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

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Primary Constructor
    /// </summary>
    public ReportedRequest() { }

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Constructor to initialize data
    /// </summary>
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

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Constructor to initialize data and generate custom RequestId/RequestName
    /// </summary>
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


    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to add a file (to control how files are added)
    /// </summary>
    public void AddFile(string filename, byte[] filedata)
    {
        if (string.IsNullOrWhiteSpace(filename))
            throw new ArgumentException("Filename cannot be null or empty", nameof(filename));
        if (filedata == null || filedata.Length == 0)
            throw new ArgumentException("File data cannot be null or empty", nameof(filedata));

        UserFileNames.Add(filename);
        UserFileData.Add(filedata);
    }


    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to remove a file by filename
    /// </summary>
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

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to remove a file by index
    /// </summary>
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

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to Change/Update Request Status (Not Implemented)
    /// </summary>
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

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to generate custom RequestId/RequestName
    /// </summary>
    private string GenerateCustomRequestId(int id)
    {
        return $"REP{id:D3}"; // D3 formats the number as a 3-digit string, e.g., "REP001"
    }

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to Compare RequestName
    /// </summary>
    public int CompareTo(ReportedRequest other)
    {
        if (other == null) return 1; // To handle null comparisons
        return this.RequestName.CompareTo(other.RequestName);
    }

    internal ReportedRequest(string reqName)
    {
        RequestName = reqName;
    }

    
    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to assign priority based on the RequestCategory
    /// </summary>
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

            _ => RequestPriority.Low //Default to Low
        };
    }

    //-------------------------------------------------------------------------------------
    /// <summary>
    /// Method to create Example reported requests
    /// </summary>
    RedBlackTree rbt = new RedBlackTree();
    public void LoadExampleRequests()
    {
        var random = new Random();
        for (int i = 1; i <= 30; i++)
        {
            int ranprog = random.Next(0, 101);
            RequestStatus status = new RequestStatus();
            if (ranprog == 0)
            {
                status = RequestStatus.Open;
            }
            else if (ranprog > 0 && ranprog < 100)
            {
                status = RequestStatus.InProgress;
            }
            else
            {
                status = RequestStatus.Closed;
            }
            // Create a new ReportedRequest
            var req = new ReportedRequest
            {
                RequestId = Guid.NewGuid(),
                RequestName = $"Request {i}",
                Customer = new Customer($"Customer {i}",
                     $"Customer {i}",
                     $"customer{i}@example.com",
                     (SouthAfricanCities)random.Next(1, Enum.GetValues(typeof(SouthAfricanCities)).Length)),
                RequestDate = DateTime.Now.AddDays(-random.Next(1, 100)),
                LastUpdated = DateTime.Now.AddDays(-random.Next(0, 10)),
                Description = $"Description for Request {i}",

                // Ensuring Category is not "None"
                Category = (RequestCategory)random.Next(1, Enum.GetValues(typeof(RequestCategory)).Length),

                // Ensuring Status is not "None"
                Status = status,

                Progress = ranprog, // Progress percentage

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
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class IssueClass
    {
          public List<string> categoryList = new List<string> {"Water and Sanitation", "Electricy and Loadshedding", "Roads and Potholes", "Waster Management", "Public Transport", "Community Safety and Security", "Parks and Public Spaces", "Housing", "Noise Complaints", "Environmental Health", "Traffic and Transport Infrastructure", "Animal Control and Wildlife"};

        public string userLocation { get; set; }
        public string userCategory { get; set; }
        public string userDescription { get; set; }
        public string userFileName { get; set; }
        public byte[] userFileData { get; set; }
        public DateTime userSubmissionDate { get; set; }

        public IssueClass() { } 

        public IssueClass(string location, string category, string description, string filename, byte[] filedata, DateTime submissionDate)
        {
            this.userLocation = location;
            this.userCategory = category;
            this.userDescription = description;
            this.userFileName = filename;
            this.userFileData = filedata;
            this.userSubmissionDate = submissionDate;
        }

    }
}

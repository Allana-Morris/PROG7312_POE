using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models
{
    public class Customer
    {
        public Guid CustomerId { get; private set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public SouthAfricanCities Location { get; set; }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public Customer() { }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor to initialize Data
        /// </summary>
        public Customer(string name, string contactNumber, string email, SouthAfricanCities location)
        {

            CustomerId = Guid.NewGuid();
            Name = name;
            ContactNumber = contactNumber;
            Email = email;
            Location = location;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//
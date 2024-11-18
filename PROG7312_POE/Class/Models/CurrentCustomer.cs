using PROG7312_POE.Class.Models.Enums;

namespace PROG7312_POE.Class.Models
{
    public class CurrentCustomer : Customer
    {

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Static instance of CurrentCustomer
        /// </summary>
        private static CurrentCustomer _instance;


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Lock object for thread safety
        /// </summary>
        private static readonly object _lock = new object();


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Private constructor to prevent direct instantiation
        /// </summary>
        private CurrentCustomer(string name, string contactNumber, string email, SouthAfricanCities location)
            : base(name, contactNumber, email, location)
        {
        }


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Public static property to access the singleton instance
        /// </summary>
        public static CurrentCustomer Instance
        {
            get
            {
                lock (_lock)
                {
                    // If the instance is null, create it
                    if (_instance == null)
                    {
                        // Initialize with default values, or set your own initialization logic
                        _instance = new CurrentCustomer("Default User", "0000000000", "user@example.com", SouthAfricanCities.Johannesburg);
                    }
                    return _instance;
                }
            }
        }

        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Sets Instance to Customer Details
        /// </summary>
        public static void SetInstance(Customer customer)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    // Create a new instance of CurrentCustomer if it doesn't exist yet
                    _instance = new CurrentCustomer(customer.Name, customer.ContactNumber, customer.Email, customer.Location);
                }
                else
                {
                    // Update the existing singleton instance with the new customer's values
                    _instance.Name = customer.Name;
                    _instance.ContactNumber = customer.ContactNumber;
                    _instance.Email = customer.Email;
                    _instance.Location = customer.Location;
                }
            }
        }


        //-------------------------------------------------------------------------------------
        /// <summary>
        /// Method to reset the instance
        /// </summary>
        public static void ResetInstance()
        {
            lock (_lock)
            {
                _instance = null;
            }
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//
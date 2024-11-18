using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROG7312_POE.Class;
using PROG7312_POE.Class.Models;
using PROG7312_POE.Class.Models.Enums;

namespace PROG7312_POE
{
    public partial class CustomerInput : Form
    {
        public Customer CustomerDetails { get; private set; }
        int valcount = 0;
        readonly SouthAfricanCities customerLocation = SouthAfricanCities.None;

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public CustomerInput()
        {
            InitializeComponent();
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor that receives the Customers location based on the Requet's location
        /// </summary>
        public CustomerInput(SouthAfricanCities location)
        {
            customerLocation = location;
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Creates new Customer using inputs
        /// </summary>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string cName = tBName.Text;
                string cEmail = tBEmail.Text;
                string cNumber = tBNumber.Text;

                ValidationClass val = new();

                if (val.isString(cName)) valcount++;
                if (val.isString(cEmail)) valcount++;
                if (val.isString(cNumber)) valcount++;

                if (valcount == 3)
                {

                    CustomerDetails = new Customer(cName, cNumber, cEmail, customerLocation);
                    CurrentCustomer.SetInstance(CustomerDetails);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch { }
        }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Closes Form if Customer wants to cancel
        /// </summary>
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//
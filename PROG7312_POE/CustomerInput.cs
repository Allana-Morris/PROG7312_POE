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

namespace PROG7312_POE
{
    public partial class CustomerInput : Form
    {
        public Customer CustomerDetails { get; private set; }
        int valcount = 0;
        public CustomerInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string cName = tBName.Text;
                string cEmail = tBEmail.Text;
                string cNumber = tBNumber.Text;

                ValidationClass val = new ValidationClass();

                if (val.isString(cName)) valcount++;
                if (val.isString(cEmail)) valcount++;
                if (val.isString(cNumber)) valcount++;

                if (valcount == 3)
                {

                    CustomerDetails = new Customer(cName, cNumber, cEmail);

                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
            }
            catch { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

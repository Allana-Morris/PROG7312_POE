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
        public CustomerInput()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string cName = tBName.Text;
            string cEmail = tBEmail.Text;
            string cNumber = tBNumber.Text;

            ValidationClass val = new ValidationClass();

            if (val.isString(cName)) ;
            if (val.isString(cEmail)) ;
            if (val.isString(cNumber)) ;

            // TODO: Validate inputs

            CustomerDetails = new Customer(cName, cNumber, cEmail);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Close the form with DialogResult.Cancel
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

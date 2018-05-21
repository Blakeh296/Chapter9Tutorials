using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object 
        // as an argument. It assigns the data entered by the
        // user to the objects properties
        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable to hold the price
            decimal price;

            // Get the phones brand
            phone.Brand = tbBrand.Text;

            // Get the phones model
            phone.Model = tbModel.Text;

            // Get the phones price
            if (decimal.TryParse(tbPrice.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message
                MessageBox.Show("Invalid Price");
            }
            
        }

        private void btnCreateObject_Click(object sender, EventArgs e)
        {
            // Create a Cehhphone object
            CellPhone myPhone = new CellPhone();

            // Get the phone data
            GetPhoneData(myPhone);

            // Display the phone data
            outBrand.Text = myPhone.Brand;
            outModel.Text = myPhone.Model;
            outPrice.Text = myPhone.Price.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

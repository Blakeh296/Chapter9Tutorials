using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CellPhoneInventory
{
    public partial class Form1 : Form
    {
        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public Form1()
        {
            InitializeComponent();
        }

        

        // The GetPhoneData method accepts a CellPhone Object
        // As an argument. It assigns the data entered by the 
        // User to the objects properties
        private void GetPhoneData(CellPhone Phone)
        {
            // Temp variable to hold the price
            decimal price;

            // Get the phones brand
            
        }
    }
}

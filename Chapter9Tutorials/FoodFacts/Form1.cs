using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodFacts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Create an instance of the NutritonForm
            NutritionInfo.Form1 var = new NutritionInfo.Form1();

            


            // Find the selected radio button
            if (rbBanana.Checked)
            {
                
            }
        }
    }
}

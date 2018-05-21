using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9Tutorials
{
    public partial class CoinToss : Form
    {
        public CoinToss()
        {
            InitializeComponent();
        }

       

        private void btnToss_Click(object sender, EventArgs e)
        {
            // Creae a Coin object
            Coin myCoin = new Coin();

            // Clear the ListBox
            lbOutput.Items.Clear();

            // Toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                // Toss the coin;
                myCoin.Toss();

                // Display the side that is up
                lbOutput.Items.Add(myCoin.GetSideUp());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

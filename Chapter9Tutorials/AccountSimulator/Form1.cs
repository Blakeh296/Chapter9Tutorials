using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // BankAccount field with a $1000 starting balance
        private BankAccount account = new BankAccount(1000);

        private void Form1_Load(object sender, EventArgs e)
        {
            // Display the starting balance
            lblBalance.Text = account.Balance.ToString("c");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount; // To hold amount of deposit

            try
            {
                // Convert the amount to a decimal
                if (decimal.TryParse(tbDeposit.Text, out amount))
                {
                    // Deposit the amount into the account
                    account.Deposit(amount);

                    // Display the new balance
                    lblBalance.Text = account.Balance.ToString("c");

                    // Clear the text box
                    tbDeposit.Clear();
                }
                else
                {
                    // Display an error message
                    MessageBox.Show("Invalid Amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;     // To hold the amount of withdrawl

            try
            {
                // Convert the amount to a decimal
                if (decimal.TryParse(tbWithdraw.Text, out amount))
                {
                    // Withdraw the amount from the account
                    account.Withdraw(amount);

                    // to prevent overdrafting the account
                    if (amount > account.Balance)
                    {
                        MessageBox.Show("Inadiquate Funds");
                    }
                    else
                    {
                        // Display the new balance
                        lblBalance.Text = account.Balance.ToString("c");

                        // Clear the text box
                        tbWithdraw.Clear();
                    }
                    
                }
                else
                {
                    // Display an error message
                    MessageBox.Show("Invalid Amount");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

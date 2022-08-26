//Moshoaliba,K-34316345

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_account_Creative
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public decimal withdraw;

        public const decimal fee_withdraw = 0.50m;

        public decimal amount = 0;

        public decimal deposit;

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAcc.Text, out decimal amount))
            {
                if (decimal.TryParse(txtInput.Text, out withdraw))
                {
                    withdraw = decimal.Parse(txtInput.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect amount");
                }
            }
            else
            {
                MessageBox.Show("Bank account empty");
            }
            
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtAcc.Text,out decimal amount))
            {
                if (decimal.TryParse(txtInput2.Text, out deposit))
                {
                    deposit = decimal.Parse(txtInput2.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Incorrect amount");
                }
            }
            else
            {
                MessageBox.Show("Bank account empty");
            }
            
        }

        public decimal TotalDeposit(decimal value)
        {

            amount = decimal.Parse(txtAcc.Text);

            amount += value;
            return amount;
        }

        public decimal TotalWithdrawal(decimal value_1)
        {
            amount = decimal.Parse(txtAcc.Text);
            amount -= value_1 + fee_withdraw;
            return amount;
        }
    }
}

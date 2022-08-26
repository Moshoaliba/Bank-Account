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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            Form2 myTransactions = new Form2();
            myTransactions.ShowDialog();

            decimal final_answer = myTransactions.TotalDeposit(myTransactions.deposit);
            textBox2.Text = final_answer.ToString("C");
            decimal final_answer_1 = myTransactions.TotalWithdrawal(myTransactions.withdraw);
            textBox2.Text = final_answer_1.ToString("C");

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                this.BackColor = Color.Green;
            }
        }
    }
}

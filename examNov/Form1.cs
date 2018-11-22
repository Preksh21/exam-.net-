using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examNov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TtlAmt = Convert.ToInt32(textBox4.Text);
            int Deposit = Convert.ToInt32(textBox5.Text);

            deposit myDeposit = new deposit();
            myDeposit.setTtlAmt(TtlAmt);
            myDeposit.setDeposit(Deposit);
            

            MessageBox.Show("Total Amt After Deposit is " + myDeposit.calculateDeposit());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TtlAmt = Convert.ToInt32(textBox4.Text);
            int WIthdraw = Convert.ToInt32(textBox6.Text);
      
            withdraw myWithdraw = new withdraw();
            myWithdraw.setTtlAmt(TtlAmt);
            myWithdraw.setDeposit(WIthdraw);


            MessageBox.Show("Total Amt After Withdrawal is " + myWithdraw.calculateWithdraw());
        }
    }
}

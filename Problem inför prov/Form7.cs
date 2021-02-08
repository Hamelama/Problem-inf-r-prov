using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem_inför_prov
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        int amountOf20s;
        int amountOf50s;
        int amountOf100s;
        private void Form7_Load(object sender, EventArgs e)
        {
            LabelAmountOf100s.Text = "100";
            LabelAmountOf20s.Text = "20";
            LabelAmountOf50s.Text = "50";
            LabelWithdrawalAmount.Text = "Belopp";
            ButtonWithdraw.Text = "Ta ut";
            TboxAmountOf100s.ReadOnly = true;
            TboxAmountOf50s.ReadOnly = true;
            TboxAmountOf20s.ReadOnly = true;

        }

        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            int withdrawalAmount = Convert.ToInt32(TboxWithdrawalAmount.Text);
            amountOf20s = 0;
            amountOf50s = 0;
            amountOf100s = 0;
            withdraw(withdrawalAmount);

        }
        

        void withdraw(int amount)
        {
            Console.WriteLine(amount);
            if (amount > 0)
            {
                if (amountOf20s >= 2 && amountOf50s >= 2 && amount % 100 == 0)
                {
                    amount = amount - 100;
                    amountOf100s++;
                    withdraw(amount);
                }
                else if (amountOf20s >= 2 && amount % 50 == 0)
                {
                    amount = amount - 50;
                    amountOf50s++;
                    withdraw(amount);
                }
                else
                {
                    amount = amount - 20;
                    amountOf20s++;
                    withdraw(amount);
                }
            }

            else
            {
                TboxAmountOf100s.Text = amountOf100s.ToString();
                TboxAmountOf50s.Text = amountOf50s.ToString();
                TboxAmountOf20s.Text = amountOf20s.ToString();
            }




        }
    }
}

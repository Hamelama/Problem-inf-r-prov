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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LabelCharPos.Text = "Position";
            LabelInput.Text = "Indata";
            LabelOutput.Text = "Utdata";

            OutputCharTextbox.ReadOnly = true;
            GiveChar.Text = "Ge bokstav, snälla";

            LabelError.Text = "Angiven position finns inte";
            LabelError.Visible = false;
        }

        private void GiveChar_Click(object sender, EventArgs e)
        {
            string input = InputTextbox.Text;
            int position = Convert.ToInt32(CharPositionTextbox.Text);
            //position i sträng börjar på 0 (medan människor börjar på 1)
            position--;

            if ( (position >= input.Length) || position < 0)
            {
                LabelError.Visible = true;
            }

            else
            {
                LabelError.Visible = false;
                OutputCharTextbox.Text = Convert.ToString(input[position]);
            }

        }

        private void Form2Button_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void Form4Button_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }

        private void Form5Button_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.ShowDialog();
        }

        private void Form6Button_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.ShowDialog();
        }
        double number = 10;
        private void BttnSquare_Click(object sender, EventArgs e)
        {
            number = number * number;
        }

        private void BttnRoot_Click(object sender, EventArgs e)
        {
            number = Math.Pow(number, 0.5);
        }

        private void Form7Button_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();
        }
    }
}

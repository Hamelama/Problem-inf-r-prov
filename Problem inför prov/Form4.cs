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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            ButtonRandomize.Text = "Slumpa!";
            TboxRandom.ReadOnly = true;
            TimerRandom.Enabled = false;
            TboxRandom.Width = 100;
  
            TboxRandom.Font = new Font("Arial", 24);
            TboxRandom.TextAlign = HorizontalAlignment.Center;
        }
        int add;
        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            add = 100;
            ButtonRandomize.Enabled = false;
            TboxRandom.BackColor = Color.White;
            TimerRandom.Interval = 100; 
            TimerRandom.Enabled = true;
            
        }
        
        private void TimerRandom_Tick(object sender, EventArgs e)
        {
            Random randomizer = new Random();
            TboxRandom.Text = (randomizer.Next(1, 11)).ToString();

            if ((TimerRandom.Interval + add) > 2000)
            {
                TimerRandom.Enabled = false;
                TboxRandom.BackColor = Color.Green;
                ButtonRandomize.Enabled = true;
            }
            else
            {
                TimerRandom.Interval = TimerRandom.Interval + add;
            }

            add = add + 100;
            
        }
    }
}

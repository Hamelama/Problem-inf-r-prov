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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Slot1.Image = SlotImages.Images[0];
            Slot2.Image = SlotImages.Images[1];
            Slot3.Image = SlotImages.Images[2];
            BttnPull.Text = "Dra!";
            Slot1Timer.Enabled = false;
            Slot1Timer.Interval = 1000;
        }

        private void BttnPull_Click(object sender, EventArgs e)
        {
            //skriv ut vad du tänker göra
            Slot1Timer.Enabled = true;
            Random randomizer = new Random();

        }

        private void SlotTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(Slot1Timer);
        }

        private void Slot2Timer_Tick(object sender, EventArgs e)
        {

        }
    }
}

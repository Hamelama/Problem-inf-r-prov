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
            Slot1Timer.Interval = 500;
            Slot2Timer.Enabled = false;
            Slot2Timer.Interval = 500;
            Slot3Timer.Enabled = false;
            Slot3Timer.Interval = 500;
            KeepSlot1.Text = "Behåll";
            KeepSlot2.Text = "Behåll";
            KeepSlot3.Text = "Behåll";
        }
        SlotMachine slot = new SlotMachine();
        private void BttnPull_Click(object sender, EventArgs e)
        {
            Slot1Timer.Enabled = false;
            Slot2Timer.Enabled = false;
            Slot3Timer.Enabled = false;
            Random randomizer = new Random();
            slot.ticksSlot1 = randomizer.Next(1, 7);
            slot.ticksSlot2 = randomizer.Next(7, 13);
            slot.ticksSlot3 = randomizer.Next(13, 19);
            slot.amountOfRolls = 0;
            Slot1Timer.Enabled = true;
            Slot2Timer.Enabled = true;
            Slot3Timer.Enabled = true;

            Console.WriteLine(slot.ticksSlot1);
            Console.WriteLine(slot.ticksSlot2);
            Console.WriteLine(slot.ticksSlot3);

            slot.Keep1 = KeepSlot1.Checked;
            slot.Keep2 = KeepSlot2.Checked;
            slot.Keep3 = KeepSlot3.Checked;

        }

        private void SlotTimer_Tick(object sender, EventArgs e)
        {

            if (slot.amountOfRolls == slot.ticksSlot1)
            {
                Slot1Timer.Enabled = false;
            }
            else
            {
                if (!slot.Keep1)
                {
                    Slot1.Image = SlotImages.Images[(slot.amountOfRolls % 6)];
                }
                
            }
        }

        private void Slot2Timer_Tick(object sender, EventArgs e)
        {

            if (slot.amountOfRolls == slot.ticksSlot2)
            {
                Slot2Timer.Enabled = false;
            }
            else
            {
                if (!slot.Keep2)
                {
                    Slot2.Image = SlotImages.Images[(slot.amountOfRolls % 6)];
                }
            }
        }

        private void Slot3Timer_Tick(object sender, EventArgs e)
        {
            slot.amountOfRolls++;

            if (slot.amountOfRolls == slot.ticksSlot3)
            {
                Slot3Timer.Enabled = false;
            }
            else
            {
                if (!slot.Keep3)
                {
                    Slot3.Image = SlotImages.Images[(slot.amountOfRolls % 6)];
                }
                
            }
        }
    }
}

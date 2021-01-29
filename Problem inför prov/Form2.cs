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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            InputLabel.Text = "Indata";
            OutputLabel.Text = "Utdata";
            ReverseButton.Text = "Vänd!";
            OutputTextbox.ReadOnly = true;
        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string input = InputTextbox.Text;
            //börjar på 0
            int startingPos = input.Length - 1;
            string output = "";
            for (int i = startingPos; i > -1; i--)
            {
                output = output + input[i];
            }
            OutputTextbox.Text = output;

        }
    }
}

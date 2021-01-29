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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            BttnEnter.Text = "Mata in";
            BttnForward.Text = ">>>";
            BttnBackward.Text = "<<<";
            LabelGrade.Text = "Betyg";
            LabelName.Text = "Namn";
            LabelResult.Text = "Resultat";

        }
        PupilList listOfPupils = new PupilList(0); 
        
        
        private void bttnEnter_Click(object sender, EventArgs e)
        {
            string name = TboxName.Text;
            int result = Convert.ToInt32(TboxResult.Text);
            string grade = TboxGrade.Text;
            Pupil pupil = new Pupil(name, result, grade);
            
            listOfPupils.AddPupil(pupil);

            TboxName.Text = listOfPupils.pupils[listOfPupils.currentPos].name;
            TboxResult.Text = listOfPupils.pupils[listOfPupils.currentPos].result.ToString();
            TboxGrade.Text = listOfPupils.pupils[listOfPupils.currentPos].grade;

        }

        private void BttnForward_Click(object sender, EventArgs e)
        {
            listOfPupils.currentPos++;
            Console.WriteLine(listOfPupils.currentPos);
            //riktigt dumt
            TboxName.Text = listOfPupils.pupils[listOfPupils.currentPos].name;
            TboxResult.Text = listOfPupils.pupils[listOfPupils.currentPos].result.ToString();
            TboxGrade.Text = listOfPupils.pupils[listOfPupils.currentPos].grade;
            
        }

        private void BttnBackward_Click(object sender, EventArgs e)
        {
            listOfPupils.currentPos--;
            TboxName.Text = listOfPupils.pupils[listOfPupils.currentPos].name;
            TboxResult.Text = listOfPupils.pupils[listOfPupils.currentPos].result.ToString();
            TboxGrade.Text = listOfPupils.pupils[listOfPupils.currentPos].grade;
        }
    }
}

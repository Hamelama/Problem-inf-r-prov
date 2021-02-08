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
            LabelPos.Text = "Nummer";
            TextboxPos.ReadOnly = true;
            LabelError.Text = "Inga fler elever";
            LabelError.Visible = false;

        }
        PupilList listOfPupils = new PupilList(); 
        
        
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
            TextboxPos.Text = (listOfPupils.currentPos + 1).ToString();
            LabelError.Visible = false;
        }

        private void BttnForward_Click(object sender, EventArgs e)
        {
            if ((listOfPupils.currentPos + 1) < listOfPupils.pupils.Count())
            {
                listOfPupils.currentPos++;

                //riktigt dumt
                TboxName.Text = listOfPupils.pupils[listOfPupils.currentPos].name;
                TboxResult.Text = listOfPupils.pupils[listOfPupils.currentPos].result.ToString();
                TboxGrade.Text = listOfPupils.pupils[listOfPupils.currentPos].grade;
                TextboxPos.Text = (listOfPupils.currentPos + 1).ToString();
                LabelError.Visible = false;
            }
            else
            {
                LabelError.Visible = true;
            }
            

            
        }

        private void BttnBackward_Click(object sender, EventArgs e)
        {
            if ((listOfPupils.currentPos - 1) >= 0)
            {
                listOfPupils.currentPos--;
                TboxName.Text = listOfPupils.pupils[listOfPupils.currentPos].name;
                TboxResult.Text = listOfPupils.pupils[listOfPupils.currentPos].result.ToString();
                TboxGrade.Text = listOfPupils.pupils[listOfPupils.currentPos].grade;
                TextboxPos.Text = (listOfPupils.currentPos + 1).ToString();
                LabelError.Visible = false;
            }
            else
            {
                LabelError.Visible = true;
            }
        }
    }
}

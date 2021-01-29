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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Kryptera meddelande (meddelande får bara vara A-Z och a-z)
            //Dekryptera meddelande

            InputEncryptedLabel.Text = "Skriv in krypterat";
            InputPlaintextLabel.Text = "Skriv in klartext";

            OutputEncryptedLabel.Text = "Krypterat";
            OutputPlaintextLabel.Text = "Klartext";

            KeyLabel.Text = "Nyckel";

            OutputPlaintextTbox.ReadOnly = true;
            OutputEncryptedTbox.ReadOnly = true;

            EncryptButton.Text = "Encrypt";
            DecryptButton.Text = "Decrypt";

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string message = InputPlaintextTbox.Text;
            int key = Convert.ToInt32(KeyTextbox.Text);
            string encryptedMessage = "";
            foreach (char letter in message)
            {
                encryptedMessage = encryptedMessage + EncryptLetter(key, letter);
            }
            OutputEncryptedTbox.Text = encryptedMessage;
        }

        char EncryptLetter(int key, char letter)
        {
            int remove = 65;
            
            int asciiNr = (int)letter;

            //versal
            if (asciiNr > 64 && asciiNr < 91)
            {
                //A = 0, B = 1 .... Z = 25
                remove = 65;
                //Vill att Z mod 26 = Z. Därmed Z = 25
            }
            //gemen
            else if (asciiNr > 96)
            {
                //a = 0 .. .. . .
                remove = 97;
                
            }
            //mellanslag
            else
            {
                return letter;
            }

            asciiNr = asciiNr - remove;

            asciiNr = (asciiNr + key) % 26;

            asciiNr = asciiNr + remove;
            
            return (char)asciiNr;
        }

        char DecryptLetter(int key, char letter)
        {
            int remove = 65;

            int asciiNr = (int)letter;

            //versal
            if (asciiNr > 64 && asciiNr < 91)
            {
                //A = 0, B = 1 .... Z = 25
                remove = 65;
                //Vill att Z mod 26 = Z. Därmed Z = 25
            }
            //gemen
            else if (asciiNr > 96)
            {
                //a = 0 .. .. . .
                remove = 97;

            }
            //mellanslag
            else
            {
                return letter;
            }

            asciiNr = asciiNr - remove;

            asciiNr = ((asciiNr - key)) % 26;
            //C# ; % är rest. Resten av -1/26 är -1. Vill att ska loopa om. Därför adderar 26 tills
            //blir positivt (i vårt fall -1 + 26 = 25 --> z som vi vill ha
            //Olika i olika språk tror jag
            while (asciiNr < 0)
            {
                //Varför addera? Jo resten är som vid positiva tal fast med minustecken framför
                //-27 % 26 = 1
                //Fast -1 ska motsvara 25, -2 motsvara 24 osv. Om jag adderar 26 (det jag tar resten genom)
                //så ska det bli "samma värde". Jmf. 0 + 26 --> 26, 26%26 = 0. 
                //Är ett sätt att "loopa om". Hålls inom ramarna av 0 <= n >= 26 ty adderar 26 åt gången och
                //kan inte köras om asciiNr > 0. Behöver därmed inte ta rest igen. 
                asciiNr = asciiNr + 26;
            }

            asciiNr = asciiNr + remove;

            return (char)asciiNr;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string message = InputEncryptedTbox.Text;
            int key = Convert.ToInt32(KeyTextbox.Text);
            string decryptedMessage = "";
            foreach (char letter in message)
            {
                decryptedMessage = decryptedMessage + DecryptLetter(key, letter);
            }
            OutputPlaintextTbox.Text = decryptedMessage;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiDataHack_2020
{
    public partial class NominateForm : Form
    {
        mainBackend mb = new mainBackend();
        public NominateForm()
        {
            InitializeComponent();
            String localLocation = Directory.GetCurrentDirectory();
            string readText = File.ReadAllText(localLocation + "\\settingsFile.db");
            string readCode = File.ReadAllText(localLocation + "\\VotingSettings\\" + readText + "\\reg.db");

            String[] values = mb.Decrypt(readCode).Split('♥');
            Nm.Text = values[0];
            surN.Text = values[1];
            GV.Text = values[2];
            IDE.Text = values[3];
            ELI.Text = values[4];
            GEN.Text = values[5];

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Register Person
            String localLocation = Directory.GetCurrentDirectory() + "//Registrations";
            if(File.Exists(localLocation))
            {

            }
            else
            {
            System.IO.Directory.CreateDirectory(localLocation);

            }
            bool detectEmpty = false;
            if (String.IsNullOrEmpty(lblName.Text))
            {
                detectEmpty = true;
            }
            if (String.IsNullOrEmpty(txbSurname.Text))
            {
                detectEmpty = true;
            }
            if (String.IsNullOrEmpty(groupVal.Text))
            {
                detectEmpty = true;
            }
            if (String.IsNullOrEmpty(txfID.Text))
            {
                detectEmpty = true;
            }
            if (String.IsNullOrEmpty(txfEligible.Text))
            {
                detectEmpty = true;
            }
            if (String.IsNullOrEmpty(txfGender.Text))
            {
                detectEmpty = true;
            }
            string path = localLocation + "//" + lblName.Text.ToString().Trim() + " " + txbSurname.Text.ToString().Trim() + ".db";
            String seperation = "♥";
            String storageData = lblName.Text.ToString().Trim() + seperation + txbSurname.Text.ToString().Trim() + seperation + groupVal.Text.ToString() + seperation + txfID.Text.ToString().Trim() + seperation + txfEligible.Text.ToString() + seperation + txfGender.Text.ToString();
           

            if (detectEmpty == true)
            {
                MessageBox.Show("Error, Please make sure all data is filled in", "Error");
                detectEmpty = false;
            }
            else
            {

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(mb.Encrypt(storageData));
                    MessageBox.Show(lblName.Text.ToString().Trim() + " " + txbSurname.Text.ToString().Trim() + " Has been Registered Successfully", "Success");

                }


            }
            else if (File.Exists(path))
            {
                MessageBox.Show("Error, Please Not\n" + lblName.Text.ToString().Trim() + " " + txbSurname.Text.ToString().Trim() +" Already Exists In The System", "Error");
            }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
            this.Hide();
        }
    }
}

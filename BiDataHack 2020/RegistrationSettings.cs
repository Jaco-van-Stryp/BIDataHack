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
    public partial class RegistrationSettings : Form
    {
        String localLocation;
        public RegistrationSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ready = true;
            if (txtName.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;
            }
            if (txtSN.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;

            }
            if (txtGV.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;

            }
            if (txtID.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;

            }
            if (txtEl.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;

            }

            if (txbGen.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
                ready = false;

            }
            if(ready == false)
            {

            } else
            {
                String seperation = "♥";
                String collect = txtName.Text.ToString() + seperation + textBox3.Text.ToString() + seperation + txtSN.Text.ToString() + seperation + txtGV.Text.ToString() + seperation + txtID.Text.ToString() + seperation + txtEl.Text.ToString() + seperation + txbGen.Text.ToString();
                string createText = mb.Encrypt(collect);
                File.WriteAllText(localLocation + "//reg.db", createText);
                this.Hide();
                MainMenu mm = new MainMenu();
                mm.Show();
                MessageBox.Show("Profile Created Successfully", "Success!");

            }
  
        }
        mainBackend mb = new mainBackend();

        internal void sendData(string localL)
        {
            localLocation = localL;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

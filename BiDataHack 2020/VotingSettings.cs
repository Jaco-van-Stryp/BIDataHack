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
    public partial class VotingSettings : Form
    {
        public String localLocation;

        public VotingSettings()
        {
            InitializeComponent();
        }
        mainBackend mb = new mainBackend();
        private void button1_Click(object sender, EventArgs e)
        {
           

            if (textBox3.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");

            }
            if (textBox4.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");

            }
            if (textBox5.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");

            }
            if (textBox6.Text.ToString() == "")
            {
                MessageBox.Show("As of this version, Please fill in all the information", "Error");
            }

            String seperation = "♥";
            String collect = textBox3.Text.ToString() + seperation + textBox4.Text.ToString() + seperation + textBox5.Text.ToString() + seperation + textBox6.Text.ToString();
            string createText = mb.Encrypt(collect);
            File.WriteAllText(localLocation + "//vote.db", createText);
            RegistrationSettings rs = new RegistrationSettings();
            rs.Show();
            rs.sendData(localLocation);
            this.Hide();



        }

        internal void carryOver(string localL)
        {
            localLocation = localL;
        }

        private void btn_BackVotingSettings_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class VotingFormMainUI : Form
    {
        public VotingFormMainUI()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mm = new Form1();
            mm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainBackend mb = new mainBackend();

            String localLocation = Directory.GetCurrentDirectory() + "//Registrations";
            if (String.IsNullOrEmpty(nameVal.Text));
            {
                bool found = false;
                String userName = nameVal.Text + " " + surnameVal.Text;
                String locatedFile = "";
                string[] files = new DirectoryInfo(localLocation).GetFiles().Select(o => o.Name).ToArray();
                for (int i = 0; i < files.Length; i++)
                {
                    String nameTest = files[i].Substring(0, files[i].Length-3);
                    if(userName.ToLower().Equals(nameTest.ToLower()))
                    {
                        found = true;
                        localLocation = localLocation + "//" + nameTest + ".db";
                        break;
                    }
                }
                if(found == true)
                {
                    string text = System.IO.File.ReadAllText(localLocation);
                    MainVotingSection mvs = new MainVotingSection();
                    string[] datafile = mb.Decrypt(text).Split('♥');
                    if(datafile[4].Equals("Vote") || datafile[4].Equals("Both"))
                    {
                        if(datafile[3].Equals(idVal.Text.ToString().Trim()))
                        {
                    mvs.Show();
                    this.Hide();
                        } else
                        {
                            MessageBox.Show("You are not authenticated to vote, Sorry!", "Error");
                            this.Hide();
                            this.Show();
                        }

                    }
                    else
                    {
                        MessageBox.Show("You are not allowed to vote, Sorry!" + datafile[0] + datafile[1] + datafile[2] + datafile[3] + datafile[4], "Error");
                        this.Hide();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("We didnt find you in the system, sorry about that!", "Error");
                    this.Hide();
                    this.Show();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace BiDataHack_2020
{
    public partial class CreateCustomeSystem : Form
    {
        public CreateCustomeSystem()
        {
            InitializeComponent();
        }

        private void btn_VotingSettings_Click(object sender, EventArgs e)
        {
            String localLocation = "";
            //Register Person
            if (String.IsNullOrEmpty(fileName.Text))
            {
                MessageBox.Show("Error, Please make sure all data is filled in", "Error");

            }
            else
            {
                localLocation = Directory.GetCurrentDirectory() + "//VotingSettings//" + fileName.Text.ToString().Trim();
                if (File.Exists(localLocation))
                {
                        MessageBox.Show("Error, Project already exists", "Error");
                }
                else
                {
                    System.IO.Directory.CreateDirectory(localLocation);
                    VotingSettings vs = new VotingSettings();
                    vs.carryOver(localLocation);
                    vs.Show();

                    this.Hide();
                }
            }
        }
            
        

        private void btn_CreationBack_Click(object sender, EventArgs e)
        {
            MainMenu cs = new MainMenu();
            cs.Show();
            this.Hide();
        }



    }

    
}

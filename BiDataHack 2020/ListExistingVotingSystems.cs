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
    public partial class ListExistingVotingSystems : Form
    {
        public ListExistingVotingSystems()
        {
            InitializeComponent();
            String localLocation = Directory.GetCurrentDirectory() + "//VotingSettings";
            var directories = Directory.GetDirectories(localLocation);
            for (int i = 0; i < directories.Length; i++)
            {
                mainList.Items.Add(directories[i]);
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Proceed_Click(object sender, EventArgs e)
        {

            Form1 votingsys = new Form1();
            votingsys.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainMenu cs = new MainMenu();
            cs.Show();
            this.Hide();
        }
    }
}

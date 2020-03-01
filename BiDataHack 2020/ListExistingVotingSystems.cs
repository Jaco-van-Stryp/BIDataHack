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

            string[] files = Directory.GetDirectories(localLocation);
            foreach (string file in files)
            {
                mainList.Items.Add(Path.GetFileName(file).ToString().Trim());
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
            String val = mainList.SelectedItem.ToString();
            Form1 votingsys = new Form1();
            votingsys.Show();
            votingsys.sendSettingsFile(val);
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

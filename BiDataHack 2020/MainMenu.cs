using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiDataHack_2020
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListExistingVotingSystems cs = new ListExistingVotingSystems();
            cs.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            CreateCustomeSystem ccsys = new CreateCustomeSystem();
            ccsys.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Remove_VotingSystem cs = new Remove_VotingSystem();
            cs.Show();
            this.Hide();

        }
    }
}

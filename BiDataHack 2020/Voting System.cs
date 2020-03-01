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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NominateForm nf = new NominateForm();
            nf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             VotingFormMainUI vfmui = new VotingFormMainUI();
            vfmui.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListExistingVotingSystems cs = new ListExistingVotingSystems();
            cs.Show();
            this.Hide();
        }
    }
}

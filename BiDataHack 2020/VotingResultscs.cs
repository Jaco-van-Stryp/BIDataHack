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
    public partial class VotingResultscs : Form
    {
        public VotingResultscs()
        {
            InitializeComponent();
           // loadResults();
        }
        mainBackend mb = new mainBackend();
        public void loadResults()
        {
            String localLocation = Directory.GetCurrentDirectory() + "\\Results";
            string[] files = Directory.GetFiles(localLocation);
            foreach (string file in files)
            {
                resultBox.Text += (Path.GetFileName(file));
                String location = localLocation + "\\" + file + ".db";
                string readText = File.ReadAllText(localLocation + "//Results//" + file + ".db");
                resultBox.Text += "\t" + mb.Decrypt(readText) +"\n";


            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form1 cs = new Form1();
            cs.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

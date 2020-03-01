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
    public partial class Remove_VotingSystem : Form
    {
        public Remove_VotingSystem()
        {
            InitializeComponent();
            String localLocation = Directory.GetCurrentDirectory() + "//VotingSettings";

            string[] files = Directory.GetDirectories(localLocation);
            foreach (string file in files)
            {
                mainList.Items.Add(Path.GetFileName(file).ToString().Trim());
            }
        }

        private void btn_BackRemoveSystem_Click(object sender, EventArgs e)
        {
            MainMenu cs = new MainMenu();
            cs.Show();
            this.Hide();
        }

        private void btn_RemoveSystem_Click(object sender, EventArgs e)
        {
            String val = mainList.SelectedItem.ToString();
            String localLocations = Directory.GetCurrentDirectory() + "//VotingSettings//" + val;

            try
            {
                Directory.Delete(localLocations);
            }
            catch (Exception)
            {
            }


        }
    }
}

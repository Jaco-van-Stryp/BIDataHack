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
    public partial class MainVotingSection : Form
    {
        public String publicText;

        mainBackend mb = new mainBackend();
        public List<String> nominees()
        {
            String localLocation = Directory.GetCurrentDirectory() + "//VotingSettings";
            string[] files = Directory.GetDirectories(localLocation);
            List<string> final = new List<string>();

            for (int i = 0; i < files.Length; i++)
            {
                string readText = File.ReadAllText(files[i]);
                String[] data = mb.Decrypt(readText).Split('♥');
                String[] pbt = mb.Decrypt(publicText).Split('♥');

                //0 - name
                //1 - Surname
                //2 - Group
                //3 - ID
                //4 - Elligable
                //5 - Gender
                if (data[2].ToLower().Equals(pbt[2].ToLower()))
                {
                     final.Add(mb.Decrypt(readText)); //could potentially add gender based conditioning here
                }
            }
            return final;
        }
        public MainVotingSection()
        {
            InitializeComponent();
            loadButtons();
        }

        public void loadButtons()
        {
            List<string> buttonsToLoad = new List<string>();
            buttonsToLoad = nominees();
            int totalToLoad = buttonsToLoad.Count();
            int val = 0;

            if(val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[0].Split('♥');
                button1.Text = s1[1] + s1[2];
            } else
            {
                button1.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[1].Split('♥');
                button2.Text = s1[1] + s1[2];
            }
            else
            {
                button2.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[2].Split('♥');
                button3.Text = s1[1] + s1[2];
            }
            else
            {
                button3.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[3].Split('♥');
                button4.Text = s1[1] + s1[2];
            }
            else
            {
                button4.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[4].Split('♥');
                button5.Text = s1[1] + s1[2];
            }
            else
            {
                button5.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[5].Split('♥');
                button10.Text = s1[1] + s1[2];
            }
            else
            {
                button10.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[6].Split('♥');
                button9.Text = s1[1] + s1[2];
            }
            else
            {
                button9.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[7].Split('♥');
                button8.Text = s1[1] + s1[2];
            }
            else
            {
                button8.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[8].Split('♥');
                button7.Text = s1[1] + s1[2];
            }
            else
            {
                button7.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[9].Split('♥');
                button6.Text = s1[1] + s1[2];
            }
            else
            {
                button6.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[10].Split('♥');
                button15.Text = s1[1] + s1[2];
            }
            else
            {
                button15.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[11].Split('♥');
                button14.Text = s1[1] + s1[2];
            }
            else
            {
                button14.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[12].Split('♥');
                button13.Text = s1[1] + s1[2];
            }
            else
            {
                button13.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[13].Split('♥');
                button12.Text = s1[1] + s1[2];
            }
            else
            {
                button12.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[14].Split('♥');
                button11.Text = s1[1] + s1[2];
            }
            else
            {
                button11.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[15].Split('♥');
                button20.Text = s1[1] + s1[2];
            }
            else
            {
                button20.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[16].Split('♥');
                button19.Text = s1[1] + s1[2];
            }
            else
            {
                button19.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[17].Split('♥');
                button18.Text = s1[1] + s1[2];
            }
            else
            {
                button18.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[18].Split('♥');
                button17.Text = s1[1] + s1[2];
            }
            else
            {
                button17.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[19].Split('♥');
                button16.Text = s1[1] + s1[2];
            }
            else
            {
                button16.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[20].Split('♥');
                button25.Text = s1[1] + s1[2];
            }
            else
            {
                button25.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[21].Split('♥');
                button24.Text = s1[1] + s1[2];
            }
            else
            {
                button24.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[22].Split('♥');
                button23.Text = s1[1] + s1[2];
            }
            else
            {
                button23.Visible = false;
            }

            if (val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[23].Split('♥');
                button22.Text = s1[1] + s1[2];
            }
            else
            {
                button22.Visible = false;
            }

              if(val <= totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[24].Split('♥');
                button21.Text = s1[1] + s1[2];
            } else
            {
                button21.Visible = false;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        internal void carryOver(string txt)
        {
            publicText = txt;
        }
    }
}

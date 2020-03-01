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
        public string publicText;

        mainBackend mb = new mainBackend();
      
        public MainVotingSection()
        {
            InitializeComponent();
            loadButtons();
        }

        public void loadButtons()
        {
            String localLocation = Directory.GetCurrentDirectory() + "\\Registrations";
            string[] files = Directory.GetFiles(localLocation);
            publicText = File.ReadAllText(Directory.GetCurrentDirectory() + "\\temp.db");
            List<string> buttonsToLoad = new List<string>();

            for (int i = 0; i < files.Length; i++)
            {
                string readText = System.IO.File.ReadAllText(files[i]);

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
                    buttonsToLoad.Add(mb.Decrypt(readText)); //could potentially add gender based conditioning here
                }
            }

            
            int totalToLoad = buttonsToLoad.Count;
            int val = 0;

            if(val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[0].Split('♥');
                button1.Text = s1[1] + " " + s1[2];
            } else
            {
                button1.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[1].Split('♥');
                button2.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button2.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[2].Split('♥');
                button3.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button3.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[3].Split('♥');
                button4.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button4.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[4].Split('♥');
                button5.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button5.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[5].Split('♥');
                button10.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button10.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[6].Split('♥');
                button9.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button9.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[7].Split('♥');
                button8.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button8.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[8].Split('♥');
                button7.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button7.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[9].Split('♥');
                button6.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button6.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[10].Split('♥');
                button15.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button15.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[11].Split('♥');
                button14.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button14.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[12].Split('♥');
                button13.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button13.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[13].Split('♥');
                button12.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button12.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[14].Split('♥');
                button11.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button11.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[15].Split('♥');
                button20.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button20.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[16].Split('♥');
                button19.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button19.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[17].Split('♥');
                button18.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button18.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[18].Split('♥');
                button17.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button17.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[19].Split('♥');
                button16.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button16.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[20].Split('♥');
                button25.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button25.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[21].Split('♥');
                button24.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button24.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[22].Split('♥');
                button23.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button23.Visible = false;
            }

            if (val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[23].Split('♥');
                button22.Text = s1[1] + " " + s1[2];
            }
            else
            {
                button22.Visible = false;
            }

              if(val < totalToLoad)
            {
                val++;
                String[] s1 = buttonsToLoad[24].Split('♥');
                button21.Text = s1[1] + " " + s1[2];
            } else
            {
                button21.Visible = false;
            }


        }
        bool btn1 = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if(btn1 == false)
            {
                btn1 = true;
                button1.BackColor = Color.Green;
            }
            else if (btn1 == true)
            {
                btn1 = false;
                button1.BackColor = Color.Red;

            }
        }

        bool btn2 = false;
        private void button2_Click(object sender, EventArgs e)
        {
            if (btn2 == false)
            {
                btn2 = true;
                button2.BackColor = Color.Green;
            }
            else if (btn2 == true)
            {
                btn2 = false;
                button2.BackColor = Color.Red;

            }
        }

        bool btn3 = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (btn3 == false)
            {
                btn3 = true;
                button3.BackColor = Color.Green;
            }
            else if (btn3 == true)
            {
                btn3 = false;
                button3.BackColor = Color.Red;

            }
        }

        bool btn4 = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (btn4 == false)
            {
                btn4 = true;
                button4.BackColor = Color.Green;
            }
            else if (btn4 == true)
            {
                btn4 = false;
                button4.BackColor = Color.Red;

            }
        }

        bool btn5 = false;
        private void button5_Click(object sender, EventArgs e)
        {
            if (btn5 == false)
            {
                btn5 = true;
                button5.BackColor = Color.Green;
            }
            else if (btn5 == true)
            {
                btn5 = false;
                button5.BackColor = Color.Red;

            }
        }



        bool btn6 = false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (btn6 == false)
            {
                btn6 = true;
                button6.BackColor = Color.Green;
            }
            else if (btn6 == true)
            {
                btn6 = false;
                button6.BackColor = Color.Red;

            }
        }

        bool btn7 = false;
        private void button7_Click(object sender, EventArgs e)
        {
            if (btn7 == false)
            {
                btn7 = true;
                button7.BackColor = Color.Green;
            }
            else if (btn7 == true)
            {
                btn7 = false;
                button7.BackColor = Color.Red;

            }
        }

        bool btn8 = false;
        private void button8_Click(object sender, EventArgs e)
        {
            if (btn8 == false)
            {
                btn8 = true;
                button8.BackColor = Color.Green;
            }
            else if (btn8 == true)
            {
                btn8 = false;
                button8.BackColor = Color.Red;

            }
        }

        bool btn9 = false;
        private void button9_Click(object sender, EventArgs e)
        {
            if (btn9 == false)
            {
                btn9 = true;
                button9.BackColor = Color.Green;
            }
            else if (btn9 == true)
            {
                btn9 = false;
                button9.BackColor = Color.Red;

            }
        }

        bool btn10 = false;
        private void button10_Click(object sender, EventArgs e)
        {
            if (btn10 == false)
            {
                btn10 = true;
                button10.BackColor = Color.Green;
            }
            else if (btn10 == true)
            {
                btn10 = false;
                button10.BackColor = Color.Red;

            }
        }


        bool btn11 = false;
        private void button11_Click(object sender, EventArgs e)
        {
            if (btn11 == false)
            {
                btn11 = true;
                button11.BackColor = Color.Green;
            }
            else if (btn11 == true)
            {
                btn11 = false;
                button11.BackColor = Color.Red;

            }
        }

        bool btn12 = false;
        private void button12_Click(object sender, EventArgs e)
        {
            if (btn12 == false)
            {
                btn12 = true;
                button12.BackColor = Color.Green;
            }
            else if (btn12 == true)
            {
                btn12 = false;
                button12.BackColor = Color.Red;

            }
        }

        bool btn13 = false;
        private void button13_Click(object sender, EventArgs e)
        {
            if (btn13 == false)
            {
                btn13 = true;
                button13.BackColor = Color.Green;
            }
            else if (btn13 == true)
            {
                btn13 = false;
                button13.BackColor = Color.Red;

            }
        }

        bool btn14 = false;
        private void button14_Click(object sender, EventArgs e)
        {
            if (btn14 == false)
            {
                btn14 = true;
                button14.BackColor = Color.Green;
            }
            else if (btn14 == true)
            {
                btn14 = false;
                button14.BackColor = Color.Red;

            }
        }

        bool btn15 = false;
        private void button15_Click(object sender, EventArgs e)
        {
            if (btn15 == false)
            {
                btn15 = true;
                button15.BackColor = Color.Green;
            }
            else if (btn15 == true)
            {
                btn15 = false;
                button15.BackColor = Color.Red;

            }
        }



        bool btn16 = false;
        private void button16_Click(object sender, EventArgs e)
        {
            if (btn16 == false)
            {
                btn16 = true;
                button16.BackColor = Color.Green;
            }
            else if (btn16 == true)
            {
                btn16 = false;
                button16.BackColor = Color.Red;

            }
        }

        bool btn17 = false;
        private void button17_Click(object sender, EventArgs e)
        {
            if (btn17 == false)
            {
                btn17 = true;
                button17.BackColor = Color.Green;
            }
            else if (btn17 == true)
            {
                btn17 = false;
                button17.BackColor = Color.Red;

            }
        }

        bool btn18 = false;
        private void button18_Click(object sender, EventArgs e)
        {
            if (btn18 == false)
            {
                btn18 = true;
                button18.BackColor = Color.Green;
            }
            else if (btn18 == true)
            {
                btn18 = false;
                button18.BackColor = Color.Red;

            }
        }

        bool btn19 = false;
        private void button19_Click(object sender, EventArgs e)
        {
            if (btn19 == false)
            {
                btn19 = true;
                button19.BackColor = Color.Green;
            }
            else if (btn19 == true)
            {
                btn19 = false;
                button19.BackColor = Color.Red;

            }
        }

        bool btn20 = false;
        private void button20_Click(object sender, EventArgs e)
        {
            if (btn20 == false)
            {
                btn20 = true;
                button20.BackColor = Color.Green;
            }
            else if (btn20 == true)
            {
                btn20 = false;
                button20.BackColor = Color.Red;

            }
        }

        bool btn21 = false;
        private void button21_Click(object sender, EventArgs e)
        {
            if (btn21 == false)
            {
                btn21 = true;
                button21.BackColor = Color.Green;
            }
            else if (btn21 == true)
            {
                btn21 = false;
                button21.BackColor = Color.Red;

            }
        }

        bool btn22 = false;
        private void button22_Click(object sender, EventArgs e)
        {
            if (btn22 == false)
            {
                btn22 = true;
                button22.BackColor = Color.Green;
            }
            else if (btn22 == true)
            {
                btn22 = false;
                button22.BackColor = Color.Red;

            }
        }

        bool btn23 = false;
        private void button23_Click(object sender, EventArgs e)
        {
            if (btn23 == false)
            {
                btn23 = true;
                button23.BackColor = Color.Green;
            }
            else if (btn23 == true)
            {
                btn23 = false;
                button23.BackColor = Color.Red;

            }
        }

        bool btn24 = false;
        private void button24_Click(object sender, EventArgs e)
        {
            if (btn24 == false)
            {
                btn24 = true;
                button24.BackColor = Color.Green;
            }
            else if (btn24 == true)
            {
                btn24 = false;
                button24.BackColor = Color.Red;

            }
        }

        bool btn25 = false;
        private void button25_Click(object sender, EventArgs e)
        {
            if (btn25 == false)
            {
                btn25 = true;
                button25.BackColor = Color.Green;
            }
            else if (btn25 == true)
            {
                btn25 = false;
                button25.BackColor = Color.Red;

            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            String totalNames = ""; 
            if(btn1 == true)
            {
                totalNames = totalNames + button1.Text + "♥";
            }
            if (btn2 == true)
            {
                totalNames = totalNames + button2.Text + "♥";
            }
            if (btn3 == true)
            {
                totalNames = totalNames + button3.Text + "♥";
            }
            if (btn4 == true)
            {
                totalNames = totalNames + button4.Text + "♥";
            }
            if (btn5 == true)
            {
                totalNames = totalNames + button5.Text + "♥";
            }
            if (btn6 == true)
            {
                totalNames = totalNames + button6.Text + "♥";
            }
            if (btn7 == true)
            {
                totalNames = totalNames + button7.Text + "♥";
            }
            if (btn8 == true)
            {
                totalNames = totalNames + button8.Text + "♥";
            }
            if (btn9 == true)
            {
                totalNames = totalNames + button9.Text + "♥";
            }
            if (btn10 == true)
            {
                totalNames = totalNames + button10.Text + "♥";
            }
            if (btn11 == true)
            {
                totalNames = totalNames + button11.Text + "♥";
            }
            if (btn12 == true)
            {
                totalNames = totalNames + button12.Text + "♥";
            }
            if (btn13 == true)
            {
                totalNames = totalNames + button13.Text + "♥";
            }
            if (btn14 == true)
            {
                totalNames = totalNames + button14.Text + "♥";
            }
            if (btn15 == true)
            {
                totalNames = totalNames + button15.Text + "♥";
            }
            if (btn16 == true)
            {
                totalNames = totalNames + button16.Text + "♥";
            }
            if (btn17 == true)
            {
                totalNames = totalNames + button17.Text + "♥";
            }
            if (btn18 == true)
            {
                totalNames = totalNames + button18.Text + "♥";
            }
            if (btn19 == true)
            {
                totalNames = totalNames + button19.Text + "♥";
            }
            if (btn20 == true)
            {
                totalNames = totalNames + button20.Text + "♥";
            }
            if (btn21 == true)
            {
                totalNames = totalNames + button21.Text + "♥";
            }
            if (btn22 == true)
            {
                totalNames = totalNames + button22.Text + "♥";
            }
            if (btn23 == true)
            {
                totalNames = totalNames + button23.Text + "♥";
            }
            if (btn24 == true)
            {
                totalNames = totalNames + button24.Text + "♥";
            }
            if (btn25 == true)
            {
                totalNames = totalNames + button25.Text + "♥";
            }
            totalNames = totalNames.Substring(0, totalNames.Length - 1);
            System.IO.Directory.CreateDirectory("Votes");
            System.IO.Directory.CreateDirectory("Results");
            String localLocation = Directory.GetCurrentDirectory() + "//Results";
            String[] names = totalNames.Split('♥');
            for (int i = 0; i < names.Length; i++)
            {
                if(File.Exists(localLocation + "//" + names[i] + ".db"))
                {
                    string readText = File.ReadAllText(localLocation + "//" + names[i] + ".db");
                    int counter = int.Parse(readText);
                    counter++;
                    File.WriteAllText(localLocation + "//" + names[i] + ".db", mb.Encrypt(counter.ToString()));
                }
                else
                {
                    string createText = "1";
                    File.WriteAllText(localLocation + "//" + names[i] + ".db", mb.Encrypt(createText));
                }
                VotingFormMainUI vfmUI = new VotingFormMainUI();
                vfmUI.Show();
                this.Hide();

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }



}

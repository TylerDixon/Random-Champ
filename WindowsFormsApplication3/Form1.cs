using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        ArrayList chosenTop;
        ArrayList chosenMid;
        ArrayList chosenJungle;
        ArrayList chosenADC;
        ArrayList chosenSupport;
        public Form1()
        {
            chosenTop = new ArrayList();
            chosenMid = new ArrayList();
            chosenADC = new ArrayList();
            chosenJungle = new ArrayList();
            chosenSupport = new ArrayList();
            InitializeComponent();
        }
        public static void ThreadProc()
        {
            Form form = new Champs(null);
            Application.Run(form);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            t.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            NewChampList list = new NewChampList(chosenTop, chosenMid, chosenJungle, chosenADC, chosenSupport);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                chosenTop = list.chosenTop;
                chosenADC = list.chosenADC;
                chosenMid = list.chosenMid;
                chosenSupport = list.chosenSupport;
                chosenJungle = list.chosenJungle;
            }
        }

        private void randomize_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            int randomNumber;
            if (comboBox1.Text == "Top")
            {
                if (chosenTop.Count != 0)
                {
                    randomNumber = random.Next(0, chosenTop.Count);
                    pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + chosenTop[randomNumber] + ".jpg");
                    label1.Text = (String)chosenTop[randomNumber];
                }
                else
                    MessageBox.Show("You don't have any champs selected.", "Error");
            }
            if (comboBox1.Text == "Mid")
            {
                if (chosenMid.Count != 0)
                {
                    randomNumber = random.Next(0, chosenMid.Count);
                    pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + chosenMid[randomNumber] + ".jpg");
                    label1.Text = (String)chosenMid[randomNumber];
                }
                else
                    MessageBox.Show("You don't have any champs selected.", "Error");
            }
            if (comboBox1.Text == "Jungle")
            {
                if (chosenJungle.Count != 0)
                {
                    randomNumber = random.Next(0, chosenJungle.Count);
                    pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + chosenJungle[randomNumber] + ".jpg");
                    label1.Text = (String)chosenJungle[randomNumber];
                }
                else
                    MessageBox.Show("You don't have any champs selected.", "Error");
            }
            if (comboBox1.Text == "ADC")
            {
                if (chosenADC.Count!=0)
                {
                    randomNumber = random.Next(0, chosenADC.Count);
                    pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + chosenADC[randomNumber] + ".jpg");
                    label1.Text = (String)chosenADC[randomNumber];
                }
                else
                    MessageBox.Show("You don't have any champs selected.", "Error");
            }
            if (comboBox1.Text == "Support")
            {
                if (chosenSupport.Count != 0)
                {
                    randomNumber = random.Next(0, chosenSupport.Count);
                    pictureBox1.Image = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + chosenSupport[randomNumber] + ".jpg");
                    label1.Text = (String)chosenSupport[randomNumber];
                }
                else
                    MessageBox.Show("You don't have any champs selected.", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();
            string file = "asdf";
            if (result == DialogResult.OK) // Test result.
            {
                file = ofd.FileName;
                string text = File.ReadAllText(file);
            }
            StreamReader reader = new StreamReader(file);
            String champ = reader.ReadLine();
            champ = reader.ReadLine();
            while (champ != "Mid")
            {
                chosenTop.Add(champ);
                champ = reader.ReadLine();
            }
            champ = reader.ReadLine();
            while (champ != "Jungle")
            {
                chosenMid.Add(champ);
                champ = reader.ReadLine();
            }
            champ = reader.ReadLine();
            while (champ != "ADC")
            {
                chosenJungle.Add(champ);
                champ = reader.ReadLine();
            }
            champ = reader.ReadLine();
            while (champ != "Support")
            {
                chosenADC.Add(champ);
                champ = reader.ReadLine();
            }
            champ = reader.ReadLine();
            while (champ != null)
            {
                chosenSupport.Add(champ);
                champ = reader.ReadLine();
            }
            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewChampList list = new NewChampList(chosenTop, chosenMid, chosenJungle, chosenADC, chosenSupport);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                chosenTop = list.chosenTop;
                chosenADC = list.chosenADC;
                chosenMid = list.chosenMid;
                chosenSupport = list.chosenSupport;
                chosenJungle = list.chosenJungle;
            }
        }

    }
}
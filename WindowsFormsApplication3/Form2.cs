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
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class NewChampList : Form
    {
        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        
        public ArrayList chosenTop;
        public ArrayList chosenMid;
        public ArrayList chosenJungle;
        public ArrayList chosenADC;
        public ArrayList chosenSupport;
        public NewChampList(ArrayList top, ArrayList mid, ArrayList jungle, ArrayList adc, ArrayList support)
        {
            //AllocConsole();
            chosenTop = top;
            chosenADC = adc;
            chosenJungle = jungle;
            chosenMid = mid;
            chosenSupport = support;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Champs list = new Champs(chosenTop);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                list.chosen.Sort();
                chosenTop = list.chosen;             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Champs list = new Champs(chosenMid);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                list.chosen.Sort();
                chosenMid = list.chosen;
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Champs list = new Champs(chosenJungle);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                list.chosen.Sort();
                chosenJungle = list.chosen;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Champs list = new Champs(chosenADC);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                list.chosen.Sort();
                chosenADC = list.chosen;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Champs list = new Champs(chosenSupport);
            if (list.ShowDialog(this) == DialogResult.OK)
            {
                list.chosen.Sort();
                chosenSupport = list.chosen;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string name = sfd.FileName;
                StreamWriter writer = new StreamWriter(name);
                this.DialogResult = DialogResult.OK;
                writer.WriteLine("Top");
                foreach (String i in chosenTop)
                {
                    writer.WriteLine(i);
                }
                writer.WriteLine("Mid");
                foreach (String i in chosenMid)
                {
                    writer.WriteLine(i);
                }
                writer.WriteLine("Jungle");
                foreach (String i in chosenJungle)
                {
                    writer.WriteLine(i);
                }
                writer.WriteLine("ADC");
                foreach (String i in chosenADC)
                {
                    writer.WriteLine(i);
                }
                writer.WriteLine("Support");
                foreach (String i in chosenSupport)
                {
                    writer.WriteLine(i);
                }
                writer.Close();
                this.Close();
            }
        }

    }
}

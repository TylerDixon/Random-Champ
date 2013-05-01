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
using System.Resources;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication3
{
    public partial class Champs : Form
    {
        public ArrayList chosen = new ArrayList();
        //Dictionary from string to pictureboxes
        Dictionary<string, PictureBox> boxes = new Dictionary<string, PictureBox>();
        PictureBox current = new PictureBox();

        public Champs(ArrayList previous)
        {
            InitializeComponent();
            boxes.Add("Ahri", this.Ahri);
            boxes.Add("Akali", this.Akali);
            boxes.Add("Alistar", this.Alistar);
            boxes.Add("Amumu",this.Amumu);
            boxes.Add("Anivia",this.Anivia);
            boxes.Add("Annie",this.Annie);
            boxes.Add("Ashe",this.Ashe);
            boxes.Add("Blitzcrank",this.Blitzcrank);	
            boxes.Add("Brand",this.Brand);
            boxes.Add("Caitlyn",this.Caitlyn);
            boxes.Add("Cassiopeia",this.Cassiopeia);
            boxes.Add("Cho_Gath",this.Cho_Gath);
            boxes.Add("Corki",this.Corki);
            boxes.Add("Darius",this.Darius);
            boxes.Add("Diana",this.Diana);
            boxes.Add("Mundo",this.Mundo);
            boxes.Add("Draven",this.Draven);
            boxes.Add("Elise",this.Elise);
            boxes.Add("Evelynn",this.Evelynn);
            boxes.Add("Ezreal",this.Ezreal);
            boxes.Add("Fiddlesticks",this.Fiddlesticks);
            boxes.Add("Fiora",this.Fiora);
            boxes.Add("Fizz",this.Fizz);
            boxes.Add("Galio",this.Galio);
            boxes.Add("Gangplank",this.Gangplank);
            boxes.Add("Garen",this.Garen);
            boxes.Add("Gragas",this.Gragas);
            boxes.Add("Graves",this.Graves);
            boxes.Add("Hecarim", this.Hecarim);
            boxes.Add("Hermerdernger", this.Hermerdernger);
            boxes.Add("Irelia", this.Irelia);
            boxes.Add("Janna", this.Janna);
            boxes.Add("Jarvan_IV", this.Jarvan_IV);
            boxes.Add("Jax", this.Jax);
            boxes.Add("Jayce", this.Jayce);
            boxes.Add("Karma", this.Karma);
            boxes.Add("Karthus", this.Karthus);
            boxes.Add("Kassadin", this.Kassadin);
            boxes.Add("Katarina", this.Katarina);
            boxes.Add("Kayle", this.Kayle);
            boxes.Add("Kennen", this.Kennen);
            boxes.Add("Kha_Zix", this.Kha_Zix);
            boxes.Add("Kog_Maw", this.Kog_Maw);
            boxes.Add("Lebonkers", this.Lebonkers);
            boxes.Add("Lee_Singer", this.Lee_Singer);
            boxes.Add("Leona", this.Leona);
            boxes.Add("Lulu", this.Lulu);
            boxes.Add("Lux", this.Lux);
            boxes.Add("Malphite", this.Malphite);
            boxes.Add("Malzahar", this.Malzahar);
            boxes.Add("Meowkai", this.Meowkai);
            boxes.Add("Master_Yi", this.Master_Yi);
            boxes.Add("Miss_Fortune", this.Miss_Fortune);
            boxes.Add("Mordehaiser", this.Mordehaiser);
            boxes.Add("Morgana", this.Morgana);
            boxes.Add("Nami", this.Nami);
            boxes.Add("Nasus", this.Nasus);
            boxes.Add("Nautilus", this.Nautilus);
            boxes.Add("Nidalee", this.Nidalee);
            boxes.Add("Nocturne", this.Nocturne);
            boxes.Add("Nunu", this.Nunu);
            boxes.Add("Olaf", this.Olaf);
            boxes.Add("Orianna", this.Orianna);
            boxes.Add("Pantheon", this.Pantheon);
            boxes.Add("Poopy", this.Poopy);
            boxes.Add("Rammus", this.Rammus);
            boxes.Add("Renekton", this.Renekton);
            boxes.Add("Rengar", this.Rengar);
            boxes.Add("Riven", this.Riven);
            boxes.Add("Rumble", this.Rumble);
            boxes.Add("Ryze", this.Ryze);
            boxes.Add("Sejuani", this.Sejuani);
            boxes.Add("Shaco", this.Shaco);
            boxes.Add("Shen", this.Shen);
            boxes.Add("Shyvana", this.Shyvana);
            boxes.Add("Singed", this.Singed);
            boxes.Add("Sion", this.Sion);
            boxes.Add("Sivir", this.Sivir);
            boxes.Add("Skarner", this.Skarner);
            boxes.Add("Sona", this.Sona);
            boxes.Add("Soraka", this.Soraka);
            boxes.Add("Swain", this.Swain);
            boxes.Add("Syndra", this.Syndra);
            boxes.Add("Talon", this.Talon);
            boxes.Add("Taric", this.Taric);
            boxes.Add("Teemo", this.Teemo);
            boxes.Add("Thresh", this.Thresh);
            boxes.Add("Tristana", this.Tristana);
            boxes.Add("Trundle", this.Trundle);
            boxes.Add("Tryndamere", this.Tryndamere);
            boxes.Add("Twisted_Fate", this.Twisted_Fate);
            boxes.Add("Twitch", this.Twitch);
            boxes.Add("Udyr", this.Udyr);
            boxes.Add("Urgot", this.Urgot);
            boxes.Add("Varus", this.Varus);
            boxes.Add("Vayne", this.Vayne);
            boxes.Add("Veigar", this.Veigar);
            boxes.Add("Vi", this.Vi);
            boxes.Add("Viktor", this.Viktor);
            boxes.Add("Vladimir", this.Vladimir);
            boxes.Add("Volibear", this.Volibear);
            boxes.Add("Warwick", this.Warwick);
            boxes.Add("Wukong", this.Wukong);
            boxes.Add("Xerath", this.Xerath);
            boxes.Add("Xin_Zhao", this.Xin_Zhao);
            boxes.Add("Yorick", this.Yorick);
            boxes.Add("Zed", this.Zed);
            boxes.Add("Ziggs", this.Ziggs);
            boxes.Add("Zilean", this.Zilean);
            boxes.Add("Zyra", this.Zyra);
            chosen = previous;
                        String change;
            Image c_bitmap = global::WindowsFormsApplication3.Properties.Resources.Ahri;
            
            foreach(String i in chosen)
            {
                change = i + "1";
                try
                {
                    c_bitmap = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + i + ".jpg");
                }
                catch { }

                boxes[i].Image= c_bitmap;
            }
        }
        private void Ahri_Click(object sender, EventArgs e)
        {


            PictureBox clicked = (PictureBox)sender;
            String asdf = clicked.Name;
            Image m_bitmap = global::WindowsFormsApplication3.Properties.Resources.Ahri;
            
            //Adds to champs array list, and replaces BW with color
            if (!chosen.Contains(asdf))
            {
                chosen.Add(asdf);
                //Tries to replace image
                try
                {
                    m_bitmap = new System.Drawing.Bitmap(Application.StartupPath + "\\Images\\" + asdf + ".jpg");
                }
                catch { }
                clicked.Image = m_bitmap;

            }
                //Removes from champs arraylist
            else
            {
                chosen.Remove(asdf);
                //Tries to replace image
                try
                {
                    m_bitmap = new System.Drawing.Bitmap(Application.StartupPath + "\\BWChamps\\" + asdf + ".jpg");
                }
                catch { }
                clicked.Image = m_bitmap;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.chosen = null;
            this.Close();
        }

        private void select_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

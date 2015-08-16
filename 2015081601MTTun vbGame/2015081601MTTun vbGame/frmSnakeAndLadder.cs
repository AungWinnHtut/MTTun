using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmSnakeAndLadder : Form
    {
        int iPlayer1 = 1;
        string path;
        string imgP1, imgP2;
        public frmSnakeAndLadder()
        {
            InitializeComponent();
        }

        private void btnDice_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            txtDice.Text = dice.ToString();
            string dpath = path + "\\dice\\";           
            picDice.Image = Image.FromFile(dpath + dice.ToString() + ".png");
            iPlayer1 = iPlayer1 + dice;
            txtPlayer1.Text = iPlayer1.ToString();
            funShowPlayer(iPlayer1, imgP1);

        }

        private void frmSnakeAndLadder_Load(object sender, EventArgs e)
        {
            path = System.IO.Directory.GetCurrentDirectory();
            imgP1 = path + "\\dice\\Char1.gif";
            imgP2 = path + "\\dice\\Char2.gif";
            funShowPlayer(iPlayer1,imgP1 );
        }

        public void funHideAll()
        {
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox19.Visible = false;
            pictureBox20.Visible = false;
            pictureBox21.Visible = false;
            pictureBox22.Visible = false;            
            pictureBox23.Visible = false;
            pictureBox24.Visible = false;            
            pictureBox25.Visible = false;
            pictureBox26.Visible = false;
            pictureBox27.Visible = false;
            pictureBox28.Visible = false;
            pictureBox29.Visible = false;
            pictureBox30.Visible = false;

        }

        public void funShowPlayer(int pos,string img)
        {
            switch(pos)
            {
                case 1:
                    funHideAll();
                    pictureBox1.Visible = true;
                    pictureBox1.Image = Image.FromFile(img);
                    break;
                case 2:
                    funHideAll();
                    pictureBox2.Visible = true;
                    pictureBox2.Image = Image.FromFile(img);
                    break;
               
                case 3:
                    funHideAll();
                    pictureBox3.Visible = true;
                    pictureBox3.Image = Image.FromFile(img);
                    break;
                case 4:
                    funHideAll();
                    pictureBox4.Visible = true;
                    pictureBox4.Image = Image.FromFile(img);
                    break;
                case 5:
                    funHideAll();
                    pictureBox5.Visible = true;
                    pictureBox5.Image = Image.FromFile(img);
                    break;
                case 6:
                    funHideAll();
                    pictureBox6.Visible = true;
                    pictureBox6.Image = Image.FromFile(img);
                    break;
                case 7:
                    funHideAll();
                    pictureBox7.Visible = true;
                    pictureBox7.Image = Image.FromFile(img);
                    break;
                case 8:
                    funHideAll();
                    pictureBox8.Visible = true;
                    pictureBox8.Image = Image.FromFile(img);
                    break;
                case 9:
                    funHideAll();
                    pictureBox9.Visible = true;
                    pictureBox9.Image = Image.FromFile(img);
                    break;
                case 10:
                    funHideAll();
                    pictureBox10.Visible = true;
                    pictureBox10.Image = Image.FromFile(img);
                    break;
                case 11:
                    funHideAll();
                    pictureBox11.Visible = true;
                    pictureBox11.Image = Image.FromFile(img);
                    break;
                case 12:
                    funHideAll();
                    pictureBox12.Visible = true;
                    pictureBox12.Image = Image.FromFile(img);
                    break;
                case 13:
                    funHideAll();
                    pictureBox13.Visible = true;
                    pictureBox13.Image = Image.FromFile(img);
                    break;
                case 14:
                    funHideAll();
                    pictureBox14.Visible = true;
                    pictureBox14.Image = Image.FromFile(img);
                    break;
                case 15:
                    funHideAll();
                    pictureBox15.Visible = true;
                    pictureBox15.Image = Image.FromFile(img);
                    break;
                case 16:
                    funHideAll();
                    pictureBox16.Visible = true;
                    pictureBox16.Image = Image.FromFile(img);
                    break;
                case 17:
                    funHideAll();
                    pictureBox17.Visible = true;
                    pictureBox17.Image = Image.FromFile(img);
                    break;
                case 18:
                    funHideAll();
                    pictureBox18.Visible = true;
                    pictureBox18.Image = Image.FromFile(img);
                    break;
                case 19:
                    funHideAll();
                    pictureBox19.Visible = true;
                    pictureBox19.Image = Image.FromFile(img);
                    break;
                case 20:
                    funHideAll();
                    pictureBox20.Visible = true;
                    pictureBox20.Image = Image.FromFile(img);
                    break;
                case 21:
                    funHideAll();
                    pictureBox21.Visible = true;
                    pictureBox21.Image = Image.FromFile(img);
                    break;
                case 22:
                    funHideAll();
                    pictureBox22.Visible = true;
                    pictureBox22.Image = Image.FromFile(img);
                    break;
                case 23:
                    funHideAll();
                    pictureBox23.Visible = true;
                    pictureBox23.Image = Image.FromFile(img);
                    break;
                case 24:
                    funHideAll();
                    pictureBox24.Visible = true;
                    pictureBox24.Image = Image.FromFile(img);
                    break;
                case 25:
                    funHideAll();
                    pictureBox25.Visible = true;
                    pictureBox25.Image = Image.FromFile(img);
                    break;
                case 26:
                    funHideAll();
                    pictureBox26.Visible = true;
                    pictureBox26.Image = Image.FromFile(img);
                    break;
                case 27:
                    funHideAll();
                    pictureBox27.Visible = true;
                    pictureBox27.Image = Image.FromFile(img);
                    break;
                case 28:
                    funHideAll();
                    pictureBox28.Visible = true;
                    pictureBox28.Image = Image.FromFile(img);
                    break;
                case 29:
                    funHideAll();
                    pictureBox29.Visible = true;
                    pictureBox29.Image = Image.FromFile(img);
                    break;
                case 30:
                    funHideAll();
                    pictureBox30.Visible = true;
                    pictureBox30.Image = Image.FromFile(img);
                    break;

            }
        }


    }
}

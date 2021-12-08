using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAtma
{
    public partial class Form1 : Form
    {
        CheckBox[] checkBoxes = new CheckBox[5];
        PictureBox[] pictureBoxes = new PictureBox[5];
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxes = new CheckBox[5] { cB1, cB2, cB3, cB4, cB5 };
            pictureBoxes = new PictureBox[5] { pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5 };
        }
        private void btnZarAt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                ZarAt(pictureBoxes[i]);
                checkBoxes[i].Visible = true;
                
            }
            btnZarAt.Enabled = false;
            btnTekrar.Visible = true;
        }
        private void btnTekrar_Click(object sender, EventArgs e)
        {
            btnZarAt.Enabled = false;
            for (int i = 0; i < checkBoxes.Length; i++)
            {
                if (checkBoxes[i].Checked)
                {
                    ZarAt(pictureBoxes[i]);
                }
                checkBoxes[i].Checked = false;
                checkBoxes[i].Visible = false;
            }
            btnZarAt.Enabled = true;
            btnTekrar.Visible = false;
        }
        private void ZarAt(PictureBox pcb)
        {
            pcb.Image = ımageList1.Images[rnd.Next(0, 6)];
            btnZarAt.Enabled = true;
        }
        private void btnZarAt_MouseEnter(object sender, EventArgs e)
        {
            btnZarAt.BackColor = Color.DarkGreen;
        }
        private void btnZarAt_MouseLeave(object sender, EventArgs e)
        {
            btnZarAt.BackColor = Color.MediumSeaGreen;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ad");
        }
    }
}

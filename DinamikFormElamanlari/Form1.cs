using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinamikFormElamanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblSkor.Text = "0";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            btnUret.Enabled = false;
            int mayin1 = 0;
            int mayin2 = 0;
            int mayin3 = 0;

            Random rnd = new Random();
            mayin1 = rnd.Next(1, 20);
            mayin2 = rnd.Next(21, 40);
            mayin3 = rnd.Next(41, 50);

            for (int i = 1; i <=300; i++)
            {
                Button btnTemp = new Button();
                btnTemp.Name = "btn" + i.ToString();
                btnTemp.Size = new System.Drawing.Size(70,70);
                btnTemp.Text = i.ToString();
                btnTemp.UseVisualStyleBackColor = true;
                if (mayin1 == i || mayin2 == i || mayin3 == i)
                {
                    btnTemp.Tag = true;
                }
                else
                {
                    btnTemp.Tag = false;
                }
                btnTemp.Click += BtnTemp_Click;
                flowLayoutPanel1.Controls.Add(btnTemp);
            }
        }
        private void BtnTemp_Click(object sender,EventArgs e)
        {
            //eğer 3 kez mayına basıldıysa form üzerinde bulunan tüm butonları pasif edin ve uygulama bitti şeklinde bir mesaj verin
            Button basilanButton = (Button)sender;
            bool mayinBulunduMu = (bool)basilanButton.Tag;
            int mayinInt = 0;
            if (mayinBulunduMu)
            {
                MessageBox.Show("mayını buldunuz tebrikler");
                basilanButton.BackColor = Color.Red;
                mayinInt =Convert.ToInt32(lblMayin.Text);
                mayinInt++;
                lblMayin.Text = mayinInt.ToString();
            }
            else
            {
                basilanButton.BackColor = Color.Green;
                basilanButton.Enabled = false;
                int skorInt = int.Parse(lblSkor.Text);
                skorInt++;
                lblSkor.Text = skorInt.ToString();
            }
            if(mayinInt == 3)
            {
                MessageBox.Show("Oyun Bitti");
            }
            
        }
    }
}

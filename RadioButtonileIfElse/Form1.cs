using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonileIfElse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rb1.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else if (rb2.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else if (rb3.Checked == true)
            {
                this.BackColor = Color.Orange;
            }
            else
            {
                MessageBox.Show("Seçim yapılmadı.");
            }
        }
    }
}

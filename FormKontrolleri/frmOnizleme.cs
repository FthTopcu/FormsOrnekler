﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormKontrolleri
{
    public partial class frmOnizleme : Form
    {
        public frmOnizleme()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            //Form yakalananForm = Application.OpenForms["Form2"];

            foreach (Form item in Application.OpenForms)
            {
                if (item.Name=="Form1")
                {
                    foreach (Control FormItem in item.Controls)
                    {
                        if (FormItem is TextBox)
                        {
                            ((TextBox)FormItem).Text = string.Empty;
                        }
                    }
                }
            }
            this.Close();
        }

        private void frmOnizleme_Load(object sender, EventArgs e)
        {

        }
    }
}


namespace WindowsFormElemanInceleme
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnResimSec = new System.Windows.Forms.Button();
            this.chkEkGaranti = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUrunTanim = new System.Windows.Forms.TextBox();
            this.txtUrunKod = new System.Windows.Forms.TextBox();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.cltUrunOzellikleri = new System.Windows.Forms.CheckedListBox();
            this.cmbUrunRenk = new System.Windows.Forms.ComboBox();
            this.rchAciklama = new System.Windows.Forms.RichTextBox();
            this.pcbResimSecim = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pcbResimSecim)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResimSec.Location = new System.Drawing.Point(25, 419);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(103, 29);
            this.btnResimSec.TabIndex = 0;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // chkEkGaranti
            // 
            this.chkEkGaranti.AutoSize = true;
            this.chkEkGaranti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkEkGaranti.Location = new System.Drawing.Point(255, 381);
            this.chkEkGaranti.Name = "chkEkGaranti";
            this.chkEkGaranti.Size = new System.Drawing.Size(164, 29);
            this.chkEkGaranti.TabIndex = 1;
            this.chkEkGaranti.Text = "Ek Garanti 2 Yıl";
            this.chkEkGaranti.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(20, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Katagori :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Açıklama :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(20, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Özellikleri :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Kod :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(13, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ürün Renk :";
            // 
            // txtUrunTanim
            // 
            this.txtUrunTanim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunTanim.Location = new System.Drawing.Point(176, 19);
            this.txtUrunTanim.Name = "txtUrunTanim";
            this.txtUrunTanim.Size = new System.Drawing.Size(243, 30);
            this.txtUrunTanim.TabIndex = 4;
            // 
            // txtUrunKod
            // 
            this.txtUrunKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunKod.Location = new System.Drawing.Point(176, 198);
            this.txtUrunKod.Name = "txtUrunKod";
            this.txtUrunKod.Size = new System.Drawing.Size(243, 30);
            this.txtUrunKod.TabIndex = 4;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(176, 55);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(243, 33);
            this.cmbUrunKategori.TabIndex = 5;
            // 
            // cltUrunOzellikleri
            // 
            this.cltUrunOzellikleri.FormattingEnabled = true;
            this.cltUrunOzellikleri.Location = new System.Drawing.Point(176, 98);
            this.cltUrunOzellikleri.Name = "cltUrunOzellikleri";
            this.cltUrunOzellikleri.Size = new System.Drawing.Size(243, 94);
            this.cltUrunOzellikleri.TabIndex = 6;
            // 
            // cmbUrunRenk
            // 
            this.cmbUrunRenk.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunRenk.FormattingEnabled = true;
            this.cmbUrunRenk.Location = new System.Drawing.Point(176, 237);
            this.cmbUrunRenk.Name = "cmbUrunRenk";
            this.cmbUrunRenk.Size = new System.Drawing.Size(243, 33);
            this.cmbUrunRenk.TabIndex = 7;
            // 
            // rchAciklama
            // 
            this.rchAciklama.Location = new System.Drawing.Point(176, 279);
            this.rchAciklama.Name = "rchAciklama";
            this.rchAciklama.Size = new System.Drawing.Size(243, 96);
            this.rchAciklama.TabIndex = 8;
            this.rchAciklama.Text = "";
            // 
            // pcbResimSecim
            // 
            this.pcbResimSecim.Location = new System.Drawing.Point(176, 419);
            this.pcbResimSecim.Name = "pcbResimSecim";
            this.pcbResimSecim.Size = new System.Drawing.Size(243, 158);
            this.pcbResimSecim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbResimSecim.TabIndex = 9;
            this.pcbResimSecim.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtUrunTanim);
            this.groupBox1.Controls.Add(this.pcbResimSecim);
            this.groupBox1.Controls.Add(this.btnResimSec);
            this.groupBox1.Controls.Add(this.rchAciklama);
            this.groupBox1.Controls.Add(this.chkEkGaranti);
            this.groupBox1.Controls.Add(this.cmbUrunRenk);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cltUrunOzellikleri);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbUrunKategori);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUrunKod);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 612);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(344, 583);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 603);
            this.dataGridView1.TabIndex = 11;
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 649);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbResimSecim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.CheckBox chkEkGaranti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUrunTanim;
        private System.Windows.Forms.TextBox txtUrunKod;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.CheckedListBox cltUrunOzellikleri;
        private System.Windows.Forms.ComboBox cmbUrunRenk;
        private System.Windows.Forms.RichTextBox rchAciklama;
        private System.Windows.Forms.PictureBox pcbResimSecim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog OFD;
    }
}


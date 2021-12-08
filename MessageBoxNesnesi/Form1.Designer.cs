
namespace MessageBoxNesnesi
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
            this.components = new System.ComponentModel.Container();
            this.btnMesajGoster = new System.Windows.Forms.Button();
            this.btnSoruSor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.txtTelefonNumara = new System.Windows.Forms.TextBox();
            this.txtEmailAdres = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.bildirimCubugu = new System.Windows.Forms.NotifyIcon(this.components);
            this.sanalDatabaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sanalDatabaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMesajGoster
            // 
            this.btnMesajGoster.Location = new System.Drawing.Point(109, 80);
            this.btnMesajGoster.Name = "btnMesajGoster";
            this.btnMesajGoster.Size = new System.Drawing.Size(136, 23);
            this.btnMesajGoster.TabIndex = 0;
            this.btnMesajGoster.Text = "Mesaj Göster";
            this.btnMesajGoster.UseVisualStyleBackColor = true;
            this.btnMesajGoster.Click += new System.EventHandler(this.btnMesajGoster_Click);
            // 
            // btnSoruSor
            // 
            this.btnSoruSor.Location = new System.Drawing.Point(109, 109);
            this.btnSoruSor.Name = "btnSoruSor";
            this.btnSoruSor.Size = new System.Drawing.Size(136, 23);
            this.btnSoruSor.TabIndex = 1;
            this.btnSoruSor.Text = "Soru Sor";
            this.btnSoruSor.UseVisualStyleBackColor = true;
            this.btnSoruSor.Click += new System.EventHandler(this.btnSoruSor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnYeniKayit);
            this.groupBox1.Controls.Add(this.txtTelefonNumara);
            this.groupBox1.Controls.Add(this.txtEmailAdres);
            this.groupBox1.Controls.Add(this.txtSoyisim);
            this.groupBox1.Controls.Add(this.txtIsim);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(267, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Ekleme";
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKayit.Location = new System.Drawing.Point(194, 185);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(132, 44);
            this.btnYeniKayit.TabIndex = 8;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // txtTelefonNumara
            // 
            this.txtTelefonNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTelefonNumara.Location = new System.Drawing.Point(181, 139);
            this.txtTelefonNumara.Name = "txtTelefonNumara";
            this.txtTelefonNumara.Size = new System.Drawing.Size(159, 30);
            this.txtTelefonNumara.TabIndex = 7;
            // 
            // txtEmailAdres
            // 
            this.txtEmailAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtEmailAdres.Location = new System.Drawing.Point(181, 103);
            this.txtEmailAdres.Name = "txtEmailAdres";
            this.txtEmailAdres.Size = new System.Drawing.Size(159, 30);
            this.txtEmailAdres.TabIndex = 6;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyisim.Location = new System.Drawing.Point(181, 65);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(159, 30);
            this.txtSoyisim.TabIndex = 5;
            // 
            // txtIsim
            // 
            this.txtIsim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtIsim.Location = new System.Drawing.Point(181, 29);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(159, 30);
            this.txtIsim.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(16, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(16, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Adresi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMusteriler);
            this.groupBox2.Location = new System.Drawing.Point(664, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 245);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteri Kayıt Listesi";
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.ColumnWidth = 50;
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.Location = new System.Drawing.Point(7, 29);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(362, 147);
            this.lstMusteriler.TabIndex = 0;
            // 
            // bildirimCubugu
            // 
            this.bildirimCubugu.Text = "Bildirim Çubuğu";
            this.bildirimCubugu.Visible = true;
            // 
            // sanalDatabaseBindingSource
            // 
            this.sanalDatabaseBindingSource.DataSource = typeof(MessageBoxNesnesi.SanalDatabase);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 382);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSoruSor);
            this.Controls.Add(this.btnMesajGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sanalDatabaseBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMesajGoster;
        private System.Windows.Forms.Button btnSoruSor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefonNumara;
        private System.Windows.Forms.TextBox txtEmailAdres;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.NotifyIcon bildirimCubugu;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.BindingSource sanalDatabaseBindingSource;
    }
}


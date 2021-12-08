
namespace QrKodOlusturma
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnQr = new System.Windows.Forms.Button();
            this.pcbQr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbQr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(196, 34);
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(236, 38);
            this.txtMetin.TabIndex = 0;
            // 
            // btnQr
            // 
            this.btnQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnQr.Location = new System.Drawing.Point(196, 78);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(236, 38);
            this.btnQr.TabIndex = 1;
            this.btnQr.Text = "QR Kod Oluştur";
            this.btnQr.UseVisualStyleBackColor = true;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // pcbQr
            // 
            this.pcbQr.Location = new System.Drawing.Point(113, 122);
            this.pcbQr.Name = "pcbQr";
            this.pcbQr.Size = new System.Drawing.Size(396, 313);
            this.pcbQr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbQr.TabIndex = 2;
            this.pcbQr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 480);
            this.Controls.Add(this.pcbQr);
            this.Controls.Add(this.btnQr);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbQr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.PictureBox pcbQr;
    }
}


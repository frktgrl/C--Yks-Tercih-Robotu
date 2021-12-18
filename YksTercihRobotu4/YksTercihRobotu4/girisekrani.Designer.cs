
namespace YksTercihRobotu4
{
    partial class girisekrani
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(girisekrani));
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_kad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kayit_ol = new System.Windows.Forms.Button();
            this.giris_yap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(152, 322);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.PasswordChar = '*';
            this.txt_sifre.Size = new System.Drawing.Size(276, 27);
            this.txt_sifre.TabIndex = 1;
            // 
            // txt_kad
            // 
            this.txt_kad.Location = new System.Drawing.Point(152, 265);
            this.txt_kad.Name = "txt_kad";
            this.txt_kad.Size = new System.Drawing.Size(276, 27);
            this.txt_kad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre:";
            // 
            // kayit_ol
            // 
            this.kayit_ol.Location = new System.Drawing.Point(152, 371);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(94, 41);
            this.kayit_ol.TabIndex = 0;
            this.kayit_ol.Text = "Kayıt Ol";
            this.kayit_ol.UseVisualStyleBackColor = true;
            this.kayit_ol.Click += new System.EventHandler(this.kayit_ol_Click);
            // 
            // giris_yap
            // 
            this.giris_yap.Location = new System.Drawing.Point(334, 371);
            this.giris_yap.Name = "giris_yap";
            this.giris_yap.Size = new System.Drawing.Size(94, 41);
            this.giris_yap.TabIndex = 3;
            this.giris_yap.Text = "Giriş Yap";
            this.giris_yap.UseVisualStyleBackColor = true;
            this.giris_yap.Click += new System.EventHandler(this.giris_yap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(152, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 185);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // girisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(581, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.giris_yap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kad);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.kayit_ol);
            this.Name = "girisekrani";
            this.Text = "Yks Robotu - Giris Ekrani";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_kad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button kayit_ol;
        private System.Windows.Forms.Button giris_yap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


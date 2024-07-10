namespace HesapSatisProjem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TxtKullaniciAd = new TextBox();
            TxtSifre = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            BtnGiris = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // TxtKullaniciAd
            // 
            TxtKullaniciAd.Font = new Font("Segoe UI", 12F);
            TxtKullaniciAd.Location = new Point(206, 120);
            TxtKullaniciAd.Margin = new Padding(4);
            TxtKullaniciAd.Name = "TxtKullaniciAd";
            TxtKullaniciAd.Size = new Size(194, 39);
            TxtKullaniciAd.TabIndex = 1;
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Segoe UI", 12F);
            TxtSifre.Location = new Point(206, 177);
            TxtSifre.Margin = new Padding(4);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(194, 39);
            TxtSifre.TabIndex = 3;
            TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(111, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(102, 123, 198);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(444, 67);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // BtnGiris
            // 
            BtnGiris.Location = new Point(214, 242);
            BtnGiris.Name = "BtnGiris";
            BtnGiris.Size = new Size(158, 52);
            BtnGiris.TabIndex = 5;
            BtnGiris.Text = "Giriş Yap:";
            BtnGiris.UseVisualStyleBackColor = true;
            BtnGiris.Click += BtnGiris_Click;
            // 
            // Form1
            // 
            AcceptButton = BtnGiris;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(102, 123, 198);
            ClientSize = new Size(775, 336);
            Controls.Add(BtnGiris);
            Controls.Add(pictureBox1);
            Controls.Add(TxtSifre);
            Controls.Add(label2);
            Controls.Add(TxtKullaniciAd);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Giriş Paneli";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtKullaniciAd;
        private TextBox TxtSifre;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnGiris;
    }
}

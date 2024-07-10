namespace HesapSatisProjem
{
    partial class FrmGirisDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisDetay));
            BtnValo = new Button();
            BtnLol = new Button();
            BtnIstatistik = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Lblisim = new Label();
            SuspendLayout();
            // 
            // BtnValo
            // 
            BtnValo.BackgroundImage = (Image)resources.GetObject("BtnValo.BackgroundImage");
            BtnValo.BackgroundImageLayout = ImageLayout.Stretch;
            BtnValo.Location = new Point(27, 81);
            BtnValo.Name = "BtnValo";
            BtnValo.Size = new Size(188, 173);
            BtnValo.TabIndex = 0;
            BtnValo.UseVisualStyleBackColor = true;
            BtnValo.Click += button1_Click;
            // 
            // BtnLol
            // 
            BtnLol.BackgroundImage = (Image)resources.GetObject("BtnLol.BackgroundImage");
            BtnLol.BackgroundImageLayout = ImageLayout.Stretch;
            BtnLol.Location = new Point(295, 81);
            BtnLol.Name = "BtnLol";
            BtnLol.Size = new Size(188, 173);
            BtnLol.TabIndex = 1;
            BtnLol.UseVisualStyleBackColor = true;
            BtnLol.Click += BtnLol_Click;
            // 
            // BtnIstatistik
            // 
            BtnIstatistik.BackgroundImage = (Image)resources.GetObject("BtnIstatistik.BackgroundImage");
            BtnIstatistik.BackgroundImageLayout = ImageLayout.Stretch;
            BtnIstatistik.Location = new Point(559, 81);
            BtnIstatistik.Name = "BtnIstatistik";
            BtnIstatistik.Size = new Size(188, 173);
            BtnIstatistik.TabIndex = 2;
            BtnIstatistik.UseVisualStyleBackColor = true;
            BtnIstatistik.Click += BtnIstatistik_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 286);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 3;
            label1.Text = "Valorant Hesaplar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 286);
            label2.Name = "label2";
            label2.Size = new Size(161, 32);
            label2.TabIndex = 4;
            label2.Text = "LOL Hesaplar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(577, 286);
            label3.Name = "label3";
            label3.Size = new Size(134, 32);
            label3.TabIndex = 5;
            label3.Text = "İstatistikler";
            // 
            // Lblisim
            // 
            Lblisim.AutoSize = true;
            Lblisim.Location = new Point(27, 19);
            Lblisim.Name = "Lblisim";
            Lblisim.Size = new Size(109, 32);
            Lblisim.TabIndex = 6;
            Lblisim.Text = "Null Null";
            // 
            // FrmGirisDetay
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(58, 166, 185);
            ClientSize = new Size(774, 357);
            Controls.Add(Lblisim);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnIstatistik);
            Controls.Add(BtnLol);
            Controls.Add(BtnValo);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmGirisDetay";
            Text = "Kategori Seçimi";
            Load += FrmGirisDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnValo;
        private Button BtnLol;
        private Button BtnIstatistik;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label Lblisim;
    }
}
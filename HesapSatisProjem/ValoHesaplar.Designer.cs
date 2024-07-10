namespace HesapSatisProjem
{
    partial class ValoHesaplar
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
            dataGridView1 = new DataGridView();
            BtnGuncelle = new Button();
            BtnEkle = new Button();
            BtnSil = new Button();
            BtnListele = new Button();
            TxtAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtSifre = new TextBox();
            CmbRank = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            TxtFiyat = new TextBox();
            label5 = new Label();
            radioButton1 = new RadioButton();
            TxtID = new TextBox();
            label6 = new Label();
            radioButton2 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 227);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1052, 311);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuncelle.Location = new Point(892, 30);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(155, 54);
            BtnGuncelle.TabIndex = 1;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnEkle
            // 
            BtnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEkle.Location = new Point(892, 103);
            BtnEkle.Name = "BtnEkle";
            BtnEkle.Size = new Size(155, 54);
            BtnEkle.TabIndex = 2;
            BtnEkle.Text = "Ekle";
            BtnEkle.UseVisualStyleBackColor = true;
            BtnEkle.Click += BtnEkle_Click;
            // 
            // BtnSil
            // 
            BtnSil.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnSil.Location = new Point(710, 103);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(155, 54);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = true;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnListele
            // 
            BtnListele.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnListele.Location = new Point(710, 30);
            BtnListele.Name = "BtnListele";
            BtnListele.Size = new Size(155, 54);
            BtnListele.TabIndex = 4;
            BtnListele.Text = "Listele";
            BtnListele.UseVisualStyleBackColor = true;
            BtnListele.Click += button4_Click;
            // 
            // TxtAd
            // 
            TxtAd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtAd.Location = new Point(164, 30);
            TxtAd.Name = "TxtAd";
            TxtAd.Size = new Size(182, 39);
            TxtAd.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 33);
            label1.Name = "label1";
            label1.Size = new Size(150, 32);
            label1.TabIndex = 6;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(90, 91);
            label2.Name = "label2";
            label2.Size = new Size(67, 32);
            label2.TabIndex = 8;
            label2.Text = "Şifre:";
            // 
            // TxtSifre
            // 
            TxtSifre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSifre.Location = new Point(164, 91);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(182, 39);
            TxtSifre.TabIndex = 7;
            // 
            // CmbRank
            // 
            CmbRank.FormattingEnabled = true;
            CmbRank.Items.AddRange(new object[] { "Gümüş", "Altın", "Platin", "Elmas", "Yücelik", "Ölümsüzlük", "Radyant" });
            CmbRank.Location = new Point(458, 138);
            CmbRank.Name = "CmbRank";
            CmbRank.Size = new Size(182, 33);
            CmbRank.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(379, 138);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 10;
            label3.Text = "Rank:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(381, 81);
            label4.Name = "label4";
            label4.Size = new Size(69, 32);
            label4.TabIndex = 11;
            label4.Text = "Fiyat:";
            // 
            // TxtFiyat
            // 
            TxtFiyat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtFiyat.Location = new Point(458, 74);
            TxtFiyat.Name = "TxtFiyat";
            TxtFiyat.Size = new Size(182, 39);
            TxtFiyat.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(405, 28);
            label5.Name = "label5";
            label5.Size = new Size(65, 32);
            label5.TabIndex = 13;
            label5.Text = "Stok:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(493, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 29);
            radioButton1.TabIndex = 14;
            radioButton1.TabStop = true;
            radioButton1.Text = "Var";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // TxtID
            // 
            TxtID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtID.Location = new Point(164, 151);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(182, 39);
            TxtID.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 151);
            label6.Name = "label6";
            label6.Size = new Size(42, 32);
            label6.TabIndex = 15;
            label6.Text = "ID:";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(578, 29);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 29);
            radioButton2.TabIndex = 17;
            radioButton2.TabStop = true;
            radioButton2.Text = "Yok";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // ValoHesaplar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(1076, 550);
            Controls.Add(radioButton2);
            Controls.Add(TxtID);
            Controls.Add(label6);
            Controls.Add(radioButton1);
            Controls.Add(label5);
            Controls.Add(TxtFiyat);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(CmbRank);
            Controls.Add(label2);
            Controls.Add(TxtSifre);
            Controls.Add(label1);
            Controls.Add(TxtAd);
            Controls.Add(BtnListele);
            Controls.Add(BtnSil);
            Controls.Add(BtnEkle);
            Controls.Add(BtnGuncelle);
            Controls.Add(dataGridView1);
            Name = "ValoHesaplar";
            Text = "ValoHesaplar";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnGuncelle;
        private Button BtnEkle;
        private Button BtnSil;
        private Button BtnListele;
        private TextBox TxtAd;
        private Label label1;
        private Label label2;
        private TextBox TxtSifre;
        private ComboBox CmbRank;
        private Label label3;
        private Label label4;
        private TextBox TxtFiyat;
        private Label label5;
        private RadioButton radioButton1;
        private TextBox TxtID;
        private Label label6;
        private RadioButton radioButton2;
    }
}
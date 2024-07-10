using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapSatisProjem
{
    public partial class LolHesaplar : Form
    {
        public LolHesaplar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=OGKAYA\MSSQLSERVER1;Database=DbHesaplar; User Id=sa; Password=1234567890Aa;");

        private void BtnListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from TblLolStok", baglanti);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            CmbRank.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            TxtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            RchNotlar.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString() == "True")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("insert into TblLolStok (HesapKullaniciAdi,HesapSifre,Rank,Fiyat,[Not],HesapDurum) values (@p1,@p2,@p3,@p4,@p5,1)", baglanti);
            komut1.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut1.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut1.Parameters.AddWithValue("@p3", CmbRank.Text);
            komut1.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komut1.Parameters.AddWithValue("@p5", RchNotlar.Text);
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            bool hesapdurum = radioButton1.Checked;
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Update TblLolStok set HesapKullaniciAdi=@p1,HesapSifre=@p2,Rank=@p3,Fiyat=@p4,[Not]=@p7,HesapDurum=@p5 where HesapId=@p6", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", TxtSifre.Text);
            komut3.Parameters.AddWithValue("@p3", CmbRank.Text);
            komut3.Parameters.AddWithValue("@p4", TxtFiyat.Text);
            komut3.Parameters.AddWithValue("@p5", hesapdurum);
            komut3.Parameters.AddWithValue("@p6", TxtID.Text);
            komut3.Parameters.AddWithValue("@p7",RchNotlar.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Delete from TblLolStok where HesapId=@h1", baglanti);
            komut2.Parameters.AddWithValue("@h1", TxtID.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

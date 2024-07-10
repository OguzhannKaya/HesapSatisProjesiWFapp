using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HesapSatisProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=OGKAYA\MSSQLSERVER1;Database=DbHesaplar; User Id=sa; Password=1234567890Aa;");

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from TblKullanicilar where KullaniciAdi=@p1 and Sifre=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",TxtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2",TxtSifre.Text);
            baglanti.Open();
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmGirisDetay fr = new FrmGirisDetay();
                fr.name = TxtKullaniciAd.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ve ya Şifre!!");
            }
            baglanti.Close();
        }
    }
}

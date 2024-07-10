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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Server=OGKAYA\MSSQLSERVER1;Database=DbHesaplar; User Id=sa; Password=1234567890Aa;");

        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            //Valo Hesap Sayısı:
            SqlCommand komut = new SqlCommand("select Count(*) from TblValoStok",baglanti);
            int hesapsayisi = (int)komut.ExecuteScalar();
            label2.Text = hesapsayisi.ToString();

            //Valo En Yüksek Fiyatlı Hesap
            SqlCommand komut1 = new SqlCommand("Select MAX(Fiyat) from TblValoStok", baglanti);
            object result  = komut1.ExecuteScalar();
            label3.Text = result.ToString();

            //Valo istenilen ranklı hesap sayısı
            SqlCommand komut2 = new SqlCommand("Select Count(*) from TblValoStok where HesapRank=@rank", baglanti);
            komut2.Parameters.AddWithValue("@rank", "Elmas");
            object elmashesapsayisi = komut2.ExecuteScalar();
            label7.Text = elmashesapsayisi.ToString();

            //Lol Hesap Sayısı
            SqlCommand komut3 = new SqlCommand("select Count(*) from TblLolStok", baglanti);
            int hesapsayisi2 = (int)komut3.ExecuteScalar();
            label11.Text = hesapsayisi2.ToString();

            //Lol En Yüksek Fiyatlı Hesap
            SqlCommand komut4 = new SqlCommand("Select MAX(Fiyat) from TblLolStok", baglanti);
            object result2 = komut4.ExecuteScalar();
            label9.Text = result2.ToString();

            //Lol istneilen Ranklı Hesap Sayısı
            SqlCommand komut5 = new SqlCommand("Select Count(*) from TblLolStok where Rank=@rank1", baglanti);
            komut5.Parameters.AddWithValue("@rank1", "Platin");
            object plathesapsayisi = komut5.ExecuteScalar();
            label5.Text = plathesapsayisi.ToString();

            //Kullanıcı Sayısı
            SqlCommand komut6 = new SqlCommand("Select Count(*) from TblKullanicilar", baglanti);
            int kullanicisayis = (int)komut6.ExecuteScalar();
            label13.Text = kullanicisayis.ToString();

            //Hesapların Fiyatları
            SqlCommand komut7 = new SqlCommand("SELECT (SELECT ISNULL(SUM(Fiyat), 0) FROM TblValoStok WHERE HesapDurum = 'True') + (SELECT ISNULL(SUM(Fiyat), 0) FROM TblLolStok WHERE HesapDurum = 'True')",baglanti);
            int fiyat = (int)komut7.ExecuteScalar();
            label15.Text = fiyat.ToString();

            //Satılmış Hesap sayısı
            SqlCommand komut8 = new SqlCommand("SELECT (Select Count(*) from TblValoStok where HesapDurum ='False') + (Select Count(*) from TblLolStok where HesapDurum='False') ", baglanti);
            int shesap = (int)komut8.ExecuteScalar();
            label17.Text = shesap.ToString();

            baglanti.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapSatisProjem
{
    public partial class FrmGirisDetay : Form
    {
        public FrmGirisDetay()
        {
            InitializeComponent();
        }
        public string name;
        private void button1_Click(object sender, EventArgs e)
        {
            ValoHesaplar frm = new ValoHesaplar();
            frm.Show();
        }

        private void FrmGirisDetay_Load(object sender, EventArgs e)
        {
            Lblisim.Text = name;
        }

        private void BtnLol_Click(object sender, EventArgs e)
        {
            LolHesaplar fr = new LolHesaplar();
            fr.Show();
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}

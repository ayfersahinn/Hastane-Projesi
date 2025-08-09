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

namespace hastaneProjesi
{
    public partial class frmHastaKayıt : Form
    {
        public frmHastaKayıt()
        {
            InitializeComponent();
        }

       sqlBaglantisi bgl = new sqlBaglantisi();

        private void frmHastaKayıt_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(mskTel.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(cinsiyet.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM hastalar WHERE HastaTC = @p1", conn))
                {
                    kontrolKomut.Parameters.AddWithValue("@p1", mskTC.Text);
                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına sahip bir kullanıcı zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                using (SqlCommand komut = new SqlCommand("insert into hastalar (HastaAd,HastaSoyad,HastaTC, HastaTelefon,HastaSifre,HastaCinsiyet) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6)", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mskTC.Text);
                    komut.Parameters.AddWithValue("@p4", mskTel.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p6", cinsiyet.Text);
                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kayıt Başarılı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void frmHastaKayıt_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

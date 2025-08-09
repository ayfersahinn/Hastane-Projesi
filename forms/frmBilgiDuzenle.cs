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
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TcNo;
        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = TcNo;

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("select * from hastalar where HastaTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAd.Text = dr["HastaAd"].ToString();
                            txtSoyad.Text = dr["HastaSoyad"].ToString();
                            mskTel.Text = dr["HastaTelefon"].ToString();
                            cinsiyet.Text = dr["HastaCinsiyet"].ToString();
                            txtSifre.Text = dr["HastaSifre"].ToString();
                        }
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("update hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 where HastaTC=@p6", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", mskTel.Text);
                    komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p5", cinsiyet.Text);
                    komut.Parameters.AddWithValue("@p6", mskTC.Text);

                    komut.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

    }
}

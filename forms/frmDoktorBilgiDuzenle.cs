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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string drKayitTc;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("update doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 where DoktorTC=@p5", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", txtSifre.Text);
                    komut.Parameters.AddWithValue("@p5", mskTC.Text);

                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Bilgiler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }

        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTC.Text = drKayitTc;

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("select * from doktorlar where DoktorTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txtAd.Text = dr["DoktorAd"].ToString();
                            txtSoyad.Text = dr["DoktorSoyad"].ToString();
                            cmbBrans.Text = dr["DoktorBrans"].ToString();
                            txtSifre.Text = dr["DoktorSifre"].ToString();
                        }
                    }
                }
            }
        }


    }
}

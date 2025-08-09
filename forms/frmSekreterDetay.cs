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
using System.Runtime.InteropServices;

namespace hastaneProjesi
{
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();    
        public  string tck;

        private void bransGetir()
        {
            //branşları çekme
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM branslar", conn))
                {
                    da.Fill(dt);
                }
                dataGridView1.DataSource = dt;
            }
        }
        private void doktorGetir()
        {
            //Doktorları çekme
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                DataTable dt2 = new DataTable();
                using (SqlDataAdapter da2 = new SqlDataAdapter(
                    "SELECT DoktorAd, DoktorSoyad, DoktorBrans FROM doktorlar", conn))
                {
                    da2.Fill(dt2);
                }
                dataGridView2.DataSource = dt2;
            }

        }
        private void comboboxAktar()
        {
            //branşları combobox a aktarma
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut2 = new SqlCommand("SELECT BransAd FROM branslar", conn))
                using (SqlDataReader dr2 = komut2.ExecuteReader())
                {
                    while (dr2.Read())
                    {
                        cmbBrans.Items.Add(dr2[0]);
                    }
                }
            }

        }
        private void temizle()
        {
            mskTarih.Clear();
            mskSaat.Clear();
            cmbBrans.Text = "";
            cmbDoktor.Text = "";
        }
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            // sekreter ad soyadı aktarma
            LblTC.Text = tck;

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand(
                    "SELECT SekreterAdSoyad FROM sekreterler WHERE SekreterTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", LblTC.Text);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            LblAdSoyad.Text = dr[0].ToString();
                        }
                    }
                }
            }

            // fonksiyonları çağırma
            comboboxAktar();
            bransGetir();
            doktorGetir();
        }



        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTarih.Text) ||
                string.IsNullOrWhiteSpace(mskSaat.Text) ||
                string.IsNullOrWhiteSpace(cmbBrans.Text) ||
                string.IsNullOrWhiteSpace(cmbDoktor.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand(
                    "INSERT INTO randevular (RandevuTarih, RandevuSaat, RandevuBrans, RandevuDoktor) " +
                    "VALUES (@p1, @p2, @p3, @p4)", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTarih.Text);
                    komut.Parameters.AddWithValue("@p2", mskSaat.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);

                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand(
                    "SELECT DoktorAd, DoktorSoyad FROM doktorlar WHERE DoktorBrans=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", cmbBrans.Text);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
                        }
                    }
                }
            }
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rchDuyuru.Text))
            {
                using (SqlConnection conn = bgl.baglanti())
                {
                    conn.Open();
                    using (SqlCommand komut = new SqlCommand(
                        "INSERT INTO duyurular (Duyuru) VALUES (@p1)", conn))
                    {
                        komut.Parameters.AddWithValue("@p1", rchDuyuru.Text);
                        komut.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rchDuyuru.Clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir duyuru metni girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli fr = new frmDoktorPaneli();
            //doktor paneli kapndığında değişiklikler sekreter detay formunda görünecek
            fr.FormClosed += (s, args) =>
            {
                doktorGetir();
               
            };
            fr.Show();
           
        }
        private void btnBrans_Click(object sender, EventArgs e)
        {
            frmBrans fr = new frmBrans();
            fr.FormClosed += (s, args) =>
            {
                bransGetir();
                
            };
            fr.Show();

           
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi fr = new frmRandevuListesi();
            fr.Show();
            
        }

        private void btnDuyuruListe_Click(object sender, EventArgs e)
        {
            frmDuyurular frmDuyurular = new frmDuyurular();
            frmDuyurular.Show();
            
        }

        private void frmSekreterDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

      

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmGirisler frm = new frmGirisler();
            frm.Show();
            this.Hide();
        }
    }
}

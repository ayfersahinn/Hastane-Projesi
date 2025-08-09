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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void doktorGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from doktorlar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void temizle() {
            txtAd.Clear();
            txtSoyad.Clear();
            cmbBrans.Text = "";
            mskTC.Clear();
            txtSifre.Clear();
        }
        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
           doktorGetir();

            //branş çekme
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
               string.IsNullOrWhiteSpace(txtSoyad.Text) ||
               string.IsNullOrWhiteSpace(cmbBrans.Text) ||
               string.IsNullOrWhiteSpace(mskTC.Text) ||
               string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                // TC kontrolü
                using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM doktorlar WHERE DoktorTC = @p1", conn))
                {
                    kontrolKomut.Parameters.AddWithValue("@p1", mskTC.Text);
                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi > 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına sahip bir doktor zaten kayıtlı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Yeni kayıt ekleme
                using (SqlCommand komut = new SqlCommand(
                    "INSERT INTO doktorlar (DoktorAd, DoktorSoyad, DoktorBrans, DoktorTC, DoktorSifre) VALUES (@p1, @p2, @p3, @p4, @p5)", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
                    komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
                    komut.Parameters.AddWithValue("@p4", mskTC.Text);
                    komut.Parameters.AddWithValue("@p5", txtSifre.Text);
                    komut.ExecuteNonQuery();
                }

                MessageBox.Show("Doktor Bilgisi Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                doktorGetir();
            }

            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTC.Text))
            {
                MessageBox.Show("Lütfen silinecek doktorun TC'sini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                // Silinecek doktorun varlığını kontrol et
                using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM doktorlar WHERE DoktorTC = @p1", conn))
                {
                    kontrolKomut.Parameters.AddWithValue("@p1", mskTC.Text);
                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi == 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına sahip doktor bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Doktoru sil
                using (SqlCommand komut = new SqlCommand("delete from doktorlar where DoktorTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Doktor Bilgisi Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            doktorGetir();
            temizle();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTC.Text))
            {
                MessageBox.Show("Lütfen doktorun TC'sini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                // Doktorun varlığını kontrol et
                using (SqlCommand kontrolKomut = new SqlCommand("SELECT COUNT(*) FROM doktorlar WHERE DoktorTC = @p1", conn))
                {
                    kontrolKomut.Parameters.AddWithValue("@p1", mskTC.Text);
                    int kayitSayisi = Convert.ToInt32(kontrolKomut.ExecuteScalar());

                    if (kayitSayisi == 0)
                    {
                        MessageBox.Show("Bu TC kimlik numarasına sahip doktor bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Güncelleme işlemi
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

            MessageBox.Show("Doktor Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            doktorGetir();
            temizle();
        }



    }
}

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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void bransGetir()
        {
            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void frmBrans_Load(object sender, EventArgs e)
        {
           bransGetir();
        }
        private void temizle()
        {
            txtId.Clear();
            txtBransAdi.Clear();
            
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBransAdi.Text))
            {
                MessageBox.Show("Lütfen branş adını boş bırakmayınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = bgl.baglanti())
                {
                    conn.Open();
                    using (SqlCommand komut = new SqlCommand("insert into branslar (BransAd) values (@p1)", conn))
                    {
                        komut.Parameters.AddWithValue("@p1", txtBransAdi.Text);
                        komut.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Yeni Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bransGetir();
                temizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Branş eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAdi.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
           
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Lütfen silinecek branşı seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("delete from branslar where Bransid=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtId.Text);
                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransGetir();
            temizle();
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtBransAdi.Text))
            {
                MessageBox.Show("Lütfen güncellenecek branş ve ID bilgisini giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("update branslar set BransAd=@p1 where Bransid=@p2", conn))
                {
                    komut.Parameters.AddWithValue("@p1", txtBransAdi.Text);
                    komut.Parameters.AddWithValue("@p2", txtId.Text);
                    komut.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Branş Bilgisi Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bransGetir();
            temizle();
        }


        private void frmBrans_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       
    }
}

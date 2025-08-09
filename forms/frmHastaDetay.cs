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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string tc;

        private void randevuGetir()
        {
            //datagridview randevu geçmişi bunun için bağlantı açıp kapamaya gerek yok
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from randevular where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void HastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                // Ad soyad çekme
                using (SqlCommand komut = new SqlCommand("select HastaAd, HastaSoyad from hastalar where HastaTC = @p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", LblTC.Text);

                    using (SqlDataReader rd = komut.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            LblAdSoyad.Text = rd[0].ToString() + " " + rd[1].ToString();
                        }
                    }
                }

                // Branş çekme
                using (SqlCommand komut2 = new SqlCommand("select BransAd from branslar", conn))
                {
                    using (SqlDataReader dr2 = komut2.ExecuteReader())
                    {
                        while (dr2.Read())
                        {
                            cmbBrans.Items.Add(dr2[0].ToString());
                        }
                    }
                }
            }

            randevuGetir();
        }


        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                using (SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad from doktorlar where DoktorBrans=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", cmbBrans.Text);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbDoktor.Items.Add(dr[0].ToString() + " " + dr[1].ToString());
                        }
                    }
                }
            }
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from randevular where RandevuBrans=@brans and RandevuDoktor=@doktor and RandevuDurum=0", conn))
                {
                    cmd.Parameters.AddWithValue("@brans", cmbBrans.Text);
                    cmd.Parameters.AddWithValue("@doktor", cmbDoktor.Text);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            dataGridView2.DataSource = dt;
        }


        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle fr = new frmBilgiDuzenle();
            fr.TcNo = LblTC.Text;
            fr.Show();
           
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Lütfen bir randevu seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(richSikayet.Text))
            {
                MessageBox.Show("Lütfen şikayetinizi yazınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("update randevular set RandevuDurum=1, HastaTC=@p1, HastaSikayet=@p2 where Randevuid=@p3", conn))
                {
                    komut.Parameters.AddWithValue("@p1", LblTC.Text);
                    komut.Parameters.AddWithValue("@p2", richSikayet.Text);
                    komut.Parameters.AddWithValue("@p3", txtID.Text);

                    komut.ExecuteNonQuery();
                }
            }

            
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtID.Clear();
            cmbBrans.Text = "";
            cmbDoktor.Text = "";
            richSikayet.Clear();
            randevuGetir();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtID.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HastaDetay_FormClosed(object sender, FormClosedEventArgs e)
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

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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl=new sqlBaglantisi();
        public string drTC;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = drTC;

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                // Ad soyad getirme
                using (SqlCommand komut = new SqlCommand("select DoktorAd, DoktorSoyad from doktorlar where DoktorTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", LblTC.Text);
                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            LblAdSoyad.Text = dr[0] + " " + dr[1];
                        }
                    }
                }

                // Doktora ait randevular
                using (SqlCommand komut2 = new SqlCommand("select * from randevular where RandevuDoktor = @p2", conn))
                {
                    komut2.Parameters.AddWithValue("@p2", LblAdSoyad.Text);
                    using (SqlDataAdapter da = new SqlDataAdapter(komut2))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmDoktorBilgiDuzenle fr = new frmDoktorBilgiDuzenle();
            fr.drKayitTc = LblTC.Text;
            fr.Show();
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            frmGirisler frm = new frmGirisler();
            frm.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void frmDoktorDetay_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

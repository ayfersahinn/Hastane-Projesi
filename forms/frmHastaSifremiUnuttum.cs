using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneProjesi.forms
{
    public partial class frmHastaSifremiUnuttum : Form
    {
        public frmHastaSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frm = new FrmHastaGiris();
            frm.Show();
            this.Hide();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTC.Text) ||
                string.IsNullOrWhiteSpace(txtSifre.Text) ||
                string.IsNullOrWhiteSpace(txtTekrarsifre.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtSifre.Text != txtTekrarsifre.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();

                using (SqlCommand komut = new SqlCommand("select * from hastalar where HastaTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);

                    using (SqlDataReader rd = komut.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            rd.Close();

                            using (SqlCommand komut2 = new SqlCommand("update hastalar set HastaSifre=@a1 where HastaTC=@a2", conn))
                            {
                                komut2.Parameters.AddWithValue("@a1", txtSifre.Text);
                                komut2.Parameters.AddWithValue("@a2", mskTC.Text);
                                komut2.ExecuteNonQuery();
                            }

                            MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmHastaGiris frm = new FrmHastaGiris();
                            frm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Hatalı TC girdiniz. Tekrar deneyiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

    }
}

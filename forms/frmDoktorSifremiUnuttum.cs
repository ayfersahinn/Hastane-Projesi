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
    public partial class frmDoktorSifremiUnuttum : Form
    {
        public frmDoktorSifremiUnuttum()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void button1_Click(object sender, EventArgs e)
        {
            frmDoktorGiris fr = new frmDoktorGiris();
            fr.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskTC.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtTekrarsifre.Text))
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

                using (SqlCommand komut = new SqlCommand("select count(*) from doktorlar where DoktorTC=@p1", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    int count = (int)komut.ExecuteScalar();

                    if (count > 0)
                    {
                        using (SqlCommand komut2 = new SqlCommand("update doktorlar set DoktorSifre=@a1 where DoktorTC=@a2", conn))
                        {
                            komut2.Parameters.AddWithValue("@a1", txtSifre.Text);
                            komut2.Parameters.AddWithValue("@a2", mskTC.Text);
                            komut2.ExecuteNonQuery();
                        }

                        MessageBox.Show("Şifre başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmDoktorGiris fr = new frmDoktorGiris();
                        fr.Show();
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

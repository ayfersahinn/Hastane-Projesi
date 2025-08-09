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
using hastaneProjesi.forms;

namespace hastaneProjesi
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
     

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaSifremiUnuttum frm = new frmHastaSifremiUnuttum();
            frm.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("select * from hastalar where HastaTC=@p1 and HastaSifre=@p2", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

                    using (SqlDataReader rd = komut.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            HastaDetay hs = new HastaDetay();
                            hs.tc = mskTC.Text;
                            hs.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("TC veya şifre hatalı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }


        private void FrmHastaGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGirisler fr = new frmGirisler();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHastaKayıt fr = new frmHastaKayıt();
            fr.Show();
        }
    }
}

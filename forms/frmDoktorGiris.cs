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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void frmDoktorGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = bgl.baglanti())
            {
                conn.Open();
                using (SqlCommand komut = new SqlCommand("select * from doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", conn))
                {
                    komut.Parameters.AddWithValue("@p1", mskTC.Text);
                    komut.Parameters.AddWithValue("@p2", TxtSifre.Text);

                    using (SqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            frmDoktorDetay fr = new frmDoktorDetay();
                            fr.drTC = mskTC.Text;
                            fr.Show();
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

        private void frmDoktorGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGirisler fr = new frmGirisler();
            fr.Show();
            this.Hide();
        }

        private void linkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoktorSifremiUnuttum frm = new frmDoktorSifremiUnuttum();
            frm.Show();
            this.Hide();
        }
    }
}

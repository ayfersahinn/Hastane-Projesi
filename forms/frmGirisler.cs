using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastaneProjesi
{
    public partial class frmGirisler : Form
    {
        public frmGirisler()
        {
            InitializeComponent();
            this.Size = new Size(1280, 720); 

        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDoktorGiris frmDoktorGiris = new frmDoktorGiris();
            frmDoktorGiris.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSekreterGiris fr = new frmSekreterGiris();
            fr.Show();
            this.Hide();
        }

        private void frmGirisler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

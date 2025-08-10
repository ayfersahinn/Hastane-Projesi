namespace hastaneProjesi
{
    partial class frmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAdSoyad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDuyuru = new System.Windows.Forms.Button();
            this.rchDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRandevuOlustur = new System.Windows.Forms.Button();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnBrans = new System.Windows.Forms.Button();
            this.btnRandevuListe = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDuyuruListe = new System.Windows.Forms.Button();
            this.linkUyeOl = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 145);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgisi";
            // 
            // LblAdSoyad
            // 
            this.LblAdSoyad.AutoSize = true;
            this.LblAdSoyad.Location = new System.Drawing.Point(124, 89);
            this.LblAdSoyad.Name = "LblAdSoyad";
            this.LblAdSoyad.Size = new System.Drawing.Size(93, 28);
            this.LblAdSoyad.TabIndex = 3;
            this.LblAdSoyad.Text = "Null Null";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ad Soyad:";
            // 
            // LblTC
            // 
            this.LblTC.AutoSize = true;
            this.LblTC.Location = new System.Drawing.Point(124, 40);
            this.LblTC.Name = "LblTC";
            this.LblTC.Size = new System.Drawing.Size(144, 28);
            this.LblTC.TabIndex = 1;
            this.LblTC.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDuyuru);
            this.groupBox2.Controls.Add(this.rchDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 282);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // btnDuyuru
            // 
            this.btnDuyuru.Location = new System.Drawing.Point(10, 225);
            this.btnDuyuru.Name = "btnDuyuru";
            this.btnDuyuru.Size = new System.Drawing.Size(287, 45);
            this.btnDuyuru.TabIndex = 1;
            this.btnDuyuru.Text = "Oluştur";
            this.btnDuyuru.UseVisualStyleBackColor = true;
            this.btnDuyuru.Click += new System.EventHandler(this.btnDuyuru_Click);
            // 
            // rchDuyuru
            // 
            this.rchDuyuru.Location = new System.Drawing.Point(10, 43);
            this.rchDuyuru.Name = "rchDuyuru";
            this.rchDuyuru.Size = new System.Drawing.Size(287, 176);
            this.rchDuyuru.TabIndex = 0;
            this.rchDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRandevuOlustur);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.txtId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(334, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 433);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Bilgisi";
            // 
            // btnRandevuOlustur
            // 
            this.btnRandevuOlustur.Location = new System.Drawing.Point(120, 315);
            this.btnRandevuOlustur.Name = "btnRandevuOlustur";
            this.btnRandevuOlustur.Size = new System.Drawing.Size(195, 45);
            this.btnRandevuOlustur.TabIndex = 18;
            this.btnRandevuOlustur.Text = "Oluştur";
            this.btnRandevuOlustur.UseVisualStyleBackColor = true;
            this.btnRandevuOlustur.Click += new System.EventHandler(this.btnRandevuOlustur_Click);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(119, 241);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(196, 36);
            this.cmbDoktor.TabIndex = 15;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(120, 199);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(196, 36);
            this.cmbBrans.TabIndex = 14;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(120, 157);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(195, 36);
            this.mskSaat.TabIndex = 13;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(120, 115);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(195, 36);
            this.mskTarih.TabIndex = 12;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(120, 71);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(196, 36);
            this.txtId.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Doktor";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Branş";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "Saat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(710, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 292);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(520, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(707, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 270);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(520, 235);
            this.dataGridView2.TabIndex = 0;
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(6, 46);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(160, 45);
            this.btnDoktor.TabIndex = 6;
            this.btnDoktor.Text = "Doktor Paneli";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnBrans
            // 
            this.btnBrans.Location = new System.Drawing.Point(175, 46);
            this.btnBrans.Name = "btnBrans";
            this.btnBrans.Size = new System.Drawing.Size(160, 45);
            this.btnBrans.TabIndex = 7;
            this.btnBrans.Text = "Branş Paneli";
            this.btnBrans.UseVisualStyleBackColor = true;
            this.btnBrans.Click += new System.EventHandler(this.btnBrans_Click);
            // 
            // btnRandevuListe
            // 
            this.btnRandevuListe.Location = new System.Drawing.Point(344, 46);
            this.btnRandevuListe.Name = "btnRandevuListe";
            this.btnRandevuListe.Size = new System.Drawing.Size(160, 45);
            this.btnRandevuListe.TabIndex = 20;
            this.btnRandevuListe.Text = "Randevu Liste";
            this.btnRandevuListe.UseVisualStyleBackColor = true;
            this.btnRandevuListe.Click += new System.EventHandler(this.btnRandevuListe_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnDuyuruListe);
            this.groupBox6.Controls.Add(this.btnBrans);
            this.groupBox6.Controls.Add(this.btnRandevuListe);
            this.groupBox6.Controls.Add(this.btnDoktor);
            this.groupBox6.Location = new System.Drawing.Point(14, 496);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(677, 119);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnDuyuruListe
            // 
            this.btnDuyuruListe.Location = new System.Drawing.Point(513, 46);
            this.btnDuyuruListe.Name = "btnDuyuruListe";
            this.btnDuyuruListe.Size = new System.Drawing.Size(160, 45);
            this.btnDuyuruListe.TabIndex = 21;
            this.btnDuyuruListe.Text = "Duyurular";
            this.btnDuyuruListe.UseVisualStyleBackColor = true;
            this.btnDuyuruListe.Click += new System.EventHandler(this.btnDuyuruListe_Click);
            // 
            // linkUyeOl
            // 
            this.linkUyeOl.AutoSize = true;
            this.linkUyeOl.Location = new System.Drawing.Point(1140, 635);
            this.linkUyeOl.Name = "linkUyeOl";
            this.linkUyeOl.Size = new System.Drawing.Size(93, 28);
            this.linkUyeOl.TabIndex = 22;
            this.linkUyeOl.TabStop = true;
            this.linkUyeOl.Text = "Çıkış Yap";
            this.linkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUyeOl_LinkClicked);
            // 
            // frmSekreterDetay
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1255, 672);
            this.Controls.Add(this.linkUyeOl);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Detay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSekreterDetay_FormClosed);
            this.Load += new System.EventHandler(this.frmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDuyuru;
        private System.Windows.Forms.RichTextBox rchDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Button btnRandevuOlustur;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnBrans;
        private System.Windows.Forms.Button btnRandevuListe;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnDuyuruListe;
        private System.Windows.Forms.LinkLabel linkUyeOl;
    }
}
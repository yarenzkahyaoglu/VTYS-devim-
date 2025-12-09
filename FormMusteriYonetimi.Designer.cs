namespace B241210094_VTYS
{
    partial class FormMusteriYonetimi
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            btnMusteriEkle = new Button();
            btnMusteriGuncelle = new Button();
            btnMusteriSil = new Button();
            btnMusteriListele = new Button();
            dgvMusteri = new DataGridView();
            cmbArac = new ComboBox();
            cmbMusteri = new ComboBox();
            dtpTeslimTarihi = new DateTimePicker();
            btnTeslimEkle = new Button();
            btnTeslimSil = new Button();
            btnTeslimListele = new Button();
            dgvTeslimat = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeslimat).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(13, 16);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(505, 422);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvMusteri);
            tabPage1.Controls.Add(btnMusteriListele);
            tabPage1.Controls.Add(btnMusteriSil);
            tabPage1.Controls.Add(btnMusteriGuncelle);
            tabPage1.Controls.Add(btnMusteriEkle);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtTelefon);
            tabPage1.Controls.Add(txtSoyad);
            tabPage1.Controls.Add(txtAd);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(497, 384);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Müşteri";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvTeslimat);
            tabPage2.Controls.Add(btnTeslimListele);
            tabPage2.Controls.Add(btnTeslimSil);
            tabPage2.Controls.Add(btnTeslimEkle);
            tabPage2.Controls.Add(dtpTeslimTarihi);
            tabPage2.Controls.Add(cmbMusteri);
            tabPage2.Controls.Add(cmbArac);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(497, 384);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teslimat";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(17, 22);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(184, 22);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(341, 22);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 31);
            txtTelefon.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(17, 69);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(28, 127);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(139, 34);
            btnMusteriEkle.TabIndex = 4;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.Location = new Point(173, 127);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(169, 34);
            btnMusteriGuncelle.TabIndex = 5;
            btnMusteriGuncelle.Text = "Müşteri Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Location = new Point(32, 183);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(112, 34);
            btnMusteriSil.TabIndex = 6;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.UseVisualStyleBackColor = true;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Location = new Point(183, 188);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(151, 34);
            btnMusteriListele.TabIndex = 7;
            btnMusteriListele.Text = "Müşteri Listele";
            btnMusteriListele.UseVisualStyleBackColor = true;
            // 
            // dgvMusteri
            // 
            dgvMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteri.Location = new Point(32, 228);
            dgvMusteri.Name = "dgvMusteri";
            dgvMusteri.RowHeadersWidth = 62;
            dgvMusteri.Size = new Size(360, 140);
            dgvMusteri.TabIndex = 8;
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(24, 29);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(182, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(232, 29);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(182, 33);
            cmbMusteri.TabIndex = 1;
            // 
            // dtpTeslimTarihi
            // 
            dtpTeslimTarihi.Location = new Point(24, 73);
            dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            dtpTeslimTarihi.Size = new Size(300, 31);
            dtpTeslimTarihi.TabIndex = 2;
            // 
            // btnTeslimEkle
            // 
            btnTeslimEkle.Location = new Point(26, 130);
            btnTeslimEkle.Name = "btnTeslimEkle";
            btnTeslimEkle.Size = new Size(125, 34);
            btnTeslimEkle.TabIndex = 3;
            btnTeslimEkle.Text = "Teslimat Ekle";
            btnTeslimEkle.UseVisualStyleBackColor = true;
            // 
            // btnTeslimSil
            // 
            btnTeslimSil.Location = new Point(157, 130);
            btnTeslimSil.Name = "btnTeslimSil";
            btnTeslimSil.Size = new Size(112, 34);
            btnTeslimSil.TabIndex = 4;
            btnTeslimSil.Text = "Teslimat Sil";
            btnTeslimSil.UseVisualStyleBackColor = true;
            // 
            // btnTeslimListele
            // 
            btnTeslimListele.Location = new Point(275, 130);
            btnTeslimListele.Name = "btnTeslimListele";
            btnTeslimListele.Size = new Size(112, 34);
            btnTeslimListele.TabIndex = 5;
            btnTeslimListele.Text = "Teslimat Listele";
            btnTeslimListele.UseVisualStyleBackColor = true;
            // 
            // dgvTeslimat
            // 
            dgvTeslimat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeslimat.Location = new Point(27, 191);
            dgvTeslimat.Name = "dgvTeslimat";
            dgvTeslimat.RowHeadersWidth = 62;
            dgvTeslimat.Size = new Size(360, 142);
            dgvTeslimat.TabIndex = 6;
            // 
            // FormMusteriYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormMusteriYonetimi";
            Text = "FormMusteriYonetimi";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTeslimat).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnMusteriGuncelle;
        private Button btnMusteriEkle;
        private TextBox txtEmail;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TabPage tabPage2;
        private DataGridView dgvMusteri;
        private Button btnMusteriListele;
        private Button btnMusteriSil;
        private Button btnTeslimListele;
        private Button btnTeslimSil;
        private Button btnTeslimEkle;
        private DateTimePicker dtpTeslimTarihi;
        private ComboBox cmbMusteri;
        private ComboBox cmbArac;
        private DataGridView dgvTeslimat;
    }
}
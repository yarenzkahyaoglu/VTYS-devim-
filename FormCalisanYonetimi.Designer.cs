namespace B241210094_VTYS
{
    partial class FormCalisanYonetimi
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
            Departman = new TabPage();
            Çalışan = new TabPage();
            ÜretimPersoneli = new TabPage();
            Mühendis = new TabPage();
            txtUzmanlikAlani = new TextBox();
            btnPersonelKaydet = new Button();
            numYetkiSeviyesi = new NumericUpDown();
            btnMuhendisKaydet = new Button();
            txtDepartmanAdi = new TextBox();
            btnDepartmanEkle = new Button();
            btnDepartmanGuncelle = new Button();
            btnDepartmanSil = new Button();
            btnDepartmanListele = new Button();
            dgvDepartman = new DataGridView();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtPozisyon = new TextBox();
            cmbDepartman = new ComboBox();
            dgvCalisan = new DataGridView();
            btnCalisanEkle = new Button();
            btnCalisanGuncelle = new Button();
            btnCalisanSil = new Button();
            btnCalisanListele = new Button();
            tabControl1.SuspendLayout();
            Departman.SuspendLayout();
            Çalışan.SuspendLayout();
            ÜretimPersoneli.SuspendLayout();
            Mühendis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalisan).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Departman);
            tabControl1.Controls.Add(Çalışan);
            tabControl1.Controls.Add(ÜretimPersoneli);
            tabControl1.Controls.Add(Mühendis);
            tabControl1.Location = new Point(34, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(484, 400);
            tabControl1.TabIndex = 0;
            // 
            // Departman
            // 
            Departman.Controls.Add(dgvDepartman);
            Departman.Controls.Add(btnDepartmanListele);
            Departman.Controls.Add(btnDepartmanSil);
            Departman.Controls.Add(btnDepartmanGuncelle);
            Departman.Controls.Add(btnDepartmanEkle);
            Departman.Controls.Add(txtDepartmanAdi);
            Departman.Location = new Point(4, 34);
            Departman.Name = "Departman";
            Departman.Padding = new Padding(3);
            Departman.Size = new Size(476, 362);
            Departman.TabIndex = 0;
            Departman.Text = "Departman";
            Departman.UseVisualStyleBackColor = true;
            // 
            // Çalışan
            // 
            Çalışan.Controls.Add(btnCalisanListele);
            Çalışan.Controls.Add(btnCalisanSil);
            Çalışan.Controls.Add(btnCalisanGuncelle);
            Çalışan.Controls.Add(btnCalisanEkle);
            Çalışan.Controls.Add(dgvCalisan);
            Çalışan.Controls.Add(cmbDepartman);
            Çalışan.Controls.Add(txtPozisyon);
            Çalışan.Controls.Add(txtSoyad);
            Çalışan.Controls.Add(txtAd);
            Çalışan.Location = new Point(4, 34);
            Çalışan.Name = "Çalışan";
            Çalışan.Padding = new Padding(3);
            Çalışan.Size = new Size(476, 362);
            Çalışan.TabIndex = 1;
            Çalışan.Text = "Çalışan";
            Çalışan.UseVisualStyleBackColor = true;
            // 
            // ÜretimPersoneli
            // 
            ÜretimPersoneli.Controls.Add(btnPersonelKaydet);
            ÜretimPersoneli.Controls.Add(txtUzmanlikAlani);
            ÜretimPersoneli.Location = new Point(4, 34);
            ÜretimPersoneli.Name = "ÜretimPersoneli";
            ÜretimPersoneli.Size = new Size(476, 362);
            ÜretimPersoneli.TabIndex = 2;
            ÜretimPersoneli.Text = "Üretim Personeli";
            ÜretimPersoneli.UseVisualStyleBackColor = true;
            // 
            // Mühendis
            // 
            Mühendis.Controls.Add(btnMuhendisKaydet);
            Mühendis.Controls.Add(numYetkiSeviyesi);
            Mühendis.Location = new Point(4, 34);
            Mühendis.Name = "Mühendis";
            Mühendis.Size = new Size(476, 362);
            Mühendis.TabIndex = 3;
            Mühendis.Text = "Mühendis";
            Mühendis.UseVisualStyleBackColor = true;
            // 
            // txtUzmanlikAlani
            // 
            txtUzmanlikAlani.Location = new Point(76, 56);
            txtUzmanlikAlani.Name = "txtUzmanlikAlani";
            txtUzmanlikAlani.Size = new Size(150, 31);
            txtUzmanlikAlani.TabIndex = 0;
            // 
            // btnPersonelKaydet
            // 
            btnPersonelKaydet.Location = new Point(90, 120);
            btnPersonelKaydet.Name = "btnPersonelKaydet";
            btnPersonelKaydet.Size = new Size(152, 34);
            btnPersonelKaydet.TabIndex = 1;
            btnPersonelKaydet.Text = "Personel Kaydet";
            btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // numYetkiSeviyesi
            // 
            numYetkiSeviyesi.Location = new Point(81, 55);
            numYetkiSeviyesi.Name = "numYetkiSeviyesi";
            numYetkiSeviyesi.Size = new Size(180, 31);
            numYetkiSeviyesi.TabIndex = 0;
            // 
            // btnMuhendisKaydet
            // 
            btnMuhendisKaydet.Location = new Point(81, 110);
            btnMuhendisKaydet.Name = "btnMuhendisKaydet";
            btnMuhendisKaydet.Size = new Size(180, 34);
            btnMuhendisKaydet.TabIndex = 1;
            btnMuhendisKaydet.Text = "Mühendis Kayddet";
            btnMuhendisKaydet.UseVisualStyleBackColor = true;
            // 
            // txtDepartmanAdi
            // 
            txtDepartmanAdi.Location = new Point(7, 6);
            txtDepartmanAdi.Name = "txtDepartmanAdi";
            txtDepartmanAdi.Size = new Size(150, 31);
            txtDepartmanAdi.TabIndex = 0;
            // 
            // btnDepartmanEkle
            // 
            btnDepartmanEkle.Location = new Point(7, 61);
            btnDepartmanEkle.Name = "btnDepartmanEkle";
            btnDepartmanEkle.Size = new Size(182, 34);
            btnDepartmanEkle.TabIndex = 1;
            btnDepartmanEkle.Text = "Departman Ekle";
            btnDepartmanEkle.UseVisualStyleBackColor = true;
            // 
            // btnDepartmanGuncelle
            // 
            btnDepartmanGuncelle.Location = new Point(7, 112);
            btnDepartmanGuncelle.Name = "btnDepartmanGuncelle";
            btnDepartmanGuncelle.Size = new Size(182, 34);
            btnDepartmanGuncelle.TabIndex = 2;
            btnDepartmanGuncelle.Text = "Departman Güncelle";
            btnDepartmanGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnDepartmanSil
            // 
            btnDepartmanSil.Location = new Point(7, 161);
            btnDepartmanSil.Name = "btnDepartmanSil";
            btnDepartmanSil.Size = new Size(182, 34);
            btnDepartmanSil.TabIndex = 3;
            btnDepartmanSil.Text = "Departman Sil";
            btnDepartmanSil.UseVisualStyleBackColor = true;
            // 
            // btnDepartmanListele
            // 
            btnDepartmanListele.Location = new Point(7, 212);
            btnDepartmanListele.Name = "btnDepartmanListele";
            btnDepartmanListele.Size = new Size(182, 34);
            btnDepartmanListele.TabIndex = 4;
            btnDepartmanListele.Text = "Departman Listele";
            btnDepartmanListele.UseVisualStyleBackColor = true;
            // 
            // dgvDepartman
            // 
            dgvDepartman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartman.Location = new Point(207, 21);
            dgvDepartman.Name = "dgvDepartman";
            dgvDepartman.RowHeadersWidth = 62;
            dgvDepartman.Size = new Size(248, 225);
            dgvDepartman.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(24, 32);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 31);
            txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(24, 80);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(24, 126);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(150, 31);
            txtPozisyon.TabIndex = 2;
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(24, 163);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(182, 33);
            cmbDepartman.TabIndex = 3;
            // 
            // dgvCalisan
            // 
            dgvCalisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisan.Location = new Point(241, 6);
            dgvCalisan.Name = "dgvCalisan";
            dgvCalisan.RowHeadersWidth = 62;
            dgvCalisan.Size = new Size(232, 225);
            dgvCalisan.TabIndex = 4;
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.Location = new Point(6, 217);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(112, 34);
            btnCalisanEkle.TabIndex = 5;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = true;
            // 
            // btnCalisanGuncelle
            // 
            btnCalisanGuncelle.Location = new Point(24, 257);
            btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            btnCalisanGuncelle.Size = new Size(163, 34);
            btnCalisanGuncelle.TabIndex = 6;
            btnCalisanGuncelle.Text = "Çalışan Güncelle";
            btnCalisanGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnCalisanSil
            // 
            btnCalisanSil.Location = new Point(124, 217);
            btnCalisanSil.Name = "btnCalisanSil";
            btnCalisanSil.Size = new Size(112, 34);
            btnCalisanSil.TabIndex = 7;
            btnCalisanSil.Text = "Çalışan Sil";
            btnCalisanSil.UseVisualStyleBackColor = true;
            // 
            // btnCalisanListele
            // 
            btnCalisanListele.Location = new Point(42, 308);
            btnCalisanListele.Name = "btnCalisanListele";
            btnCalisanListele.Size = new Size(112, 34);
            btnCalisanListele.TabIndex = 8;
            btnCalisanListele.Text = "Çalışan Listele";
            btnCalisanListele.UseVisualStyleBackColor = true;
            // 
            // FormCalisanYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormCalisanYonetimi";
            Text = "FormCalisan";
            tabControl1.ResumeLayout(false);
            Departman.ResumeLayout(false);
            Departman.PerformLayout();
            Çalışan.ResumeLayout(false);
            Çalışan.PerformLayout();
            ÜretimPersoneli.ResumeLayout(false);
            ÜretimPersoneli.PerformLayout();
            Mühendis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCalisan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Departman;
        private TabPage Çalışan;
        private TabPage ÜretimPersoneli;
        private TabPage Mühendis;
        private TextBox txtDepartmanAdi;
        private Button btnPersonelKaydet;
        private TextBox txtUzmanlikAlani;
        private Button btnMuhendisKaydet;
        private NumericUpDown numYetkiSeviyesi;
        private DataGridView dgvDepartman;
        private Button btnDepartmanListele;
        private Button btnDepartmanSil;
        private Button btnDepartmanGuncelle;
        private Button btnDepartmanEkle;
        private TextBox txtAd;
        private TextBox txtPozisyon;
        private TextBox txtSoyad;
        private Button btnCalisanListele;
        private Button btnCalisanSil;
        private Button btnCalisanGuncelle;
        private Button btnCalisanEkle;
        private DataGridView dgvCalisan;
        private ComboBox cmbDepartman;
    }
}
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
            label1 = new Label();
            dgvDepartman = new DataGridView();
            btnDepartmanListele = new Button();
            btnDepartmanSil = new Button();
            btnDepartmanGuncelle = new Button();
            btnDepartmanEkle = new Button();
            txtDepartmanAdi = new TextBox();
            Calisan = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            gbMuhendis = new GroupBox();
            numYetkiSeviyesi = new NumericUpDown();
            btnMuhendisKaydet = new Button();
            gbUretimPersoneli = new GroupBox();
            txtUzmanlikAlani = new TextBox();
            btnPersonelKaydet = new Button();
            rbMuhendis = new RadioButton();
            rbUretimPersoneli = new RadioButton();
            rbGenel = new RadioButton();
            btnCalisanListele = new Button();
            btnCalisanSil = new Button();
            btnCalisanGuncelle = new Button();
            btnCalisanEkle = new Button();
            dgvCalisan = new DataGridView();
            cmbDepartman = new ComboBox();
            txtPozisyon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            tabControl1.SuspendLayout();
            Departman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).BeginInit();
            Calisan.SuspendLayout();
            gbMuhendis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).BeginInit();
            gbUretimPersoneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalisan).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Departman);
            tabControl1.Controls.Add(Calisan);
            tabControl1.Location = new Point(-5, -5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(985, 543);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // Departman
            // 
            Departman.Controls.Add(label1);
            Departman.Controls.Add(dgvDepartman);
            Departman.Controls.Add(btnDepartmanListele);
            Departman.Controls.Add(btnDepartmanSil);
            Departman.Controls.Add(btnDepartmanGuncelle);
            Departman.Controls.Add(btnDepartmanEkle);
            Departman.Controls.Add(txtDepartmanAdi);
            Departman.Location = new Point(4, 34);
            Departman.Name = "Departman";
            Departman.Padding = new Padding(3);
            Departman.Size = new Size(977, 505);
            Departman.TabIndex = 0;
            Departman.Text = "Departman";
            Departman.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 60);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 6;
            label1.Text = "Departman giriniz.";
            // 
            // dgvDepartman
            // 
            dgvDepartman.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDepartman.Location = new Point(389, 88);
            dgvDepartman.Name = "dgvDepartman";
            dgvDepartman.RowHeadersWidth = 62;
            dgvDepartman.Size = new Size(449, 319);
            dgvDepartman.TabIndex = 5;
            dgvDepartman.CellClick += dgvDepartman_CellClick;
            // 
            // btnDepartmanListele
            // 
            btnDepartmanListele.Location = new Point(153, 341);
            btnDepartmanListele.Name = "btnDepartmanListele";
            btnDepartmanListele.Size = new Size(214, 66);
            btnDepartmanListele.TabIndex = 4;
            btnDepartmanListele.Text = "Departman Listele";
            btnDepartmanListele.UseVisualStyleBackColor = true;
            btnDepartmanListele.Click += btnDepartmanListele_Click;
            // 
            // btnDepartmanSil
            // 
            btnDepartmanSil.Location = new Point(153, 269);
            btnDepartmanSil.Name = "btnDepartmanSil";
            btnDepartmanSil.Size = new Size(214, 66);
            btnDepartmanSil.TabIndex = 3;
            btnDepartmanSil.Text = "Departman Sil";
            btnDepartmanSil.UseVisualStyleBackColor = true;
            btnDepartmanSil.Click += btnDepartmanSil_Click;
            // 
            // btnDepartmanGuncelle
            // 
            btnDepartmanGuncelle.Location = new Point(153, 197);
            btnDepartmanGuncelle.Name = "btnDepartmanGuncelle";
            btnDepartmanGuncelle.Size = new Size(214, 66);
            btnDepartmanGuncelle.TabIndex = 2;
            btnDepartmanGuncelle.Text = "Departman Güncelle";
            btnDepartmanGuncelle.UseVisualStyleBackColor = true;
            btnDepartmanGuncelle.Click += btnDepartmanGuncelle_Click;
            // 
            // btnDepartmanEkle
            // 
            btnDepartmanEkle.Location = new Point(153, 125);
            btnDepartmanEkle.Name = "btnDepartmanEkle";
            btnDepartmanEkle.Size = new Size(214, 66);
            btnDepartmanEkle.TabIndex = 1;
            btnDepartmanEkle.Text = "Departman Ekle";
            btnDepartmanEkle.UseVisualStyleBackColor = true;
            btnDepartmanEkle.Click += btnDepartmanEkle_Click;
            // 
            // txtDepartmanAdi
            // 
            txtDepartmanAdi.Location = new Point(153, 88);
            txtDepartmanAdi.Name = "txtDepartmanAdi";
            txtDepartmanAdi.Size = new Size(214, 31);
            txtDepartmanAdi.TabIndex = 0;
            // 
            // Calisan
            // 
            Calisan.Controls.Add(label5);
            Calisan.Controls.Add(label4);
            Calisan.Controls.Add(label3);
            Calisan.Controls.Add(label2);
            Calisan.Controls.Add(gbMuhendis);
            Calisan.Controls.Add(gbUretimPersoneli);
            Calisan.Controls.Add(rbMuhendis);
            Calisan.Controls.Add(rbUretimPersoneli);
            Calisan.Controls.Add(rbGenel);
            Calisan.Controls.Add(btnCalisanListele);
            Calisan.Controls.Add(btnCalisanSil);
            Calisan.Controls.Add(btnCalisanGuncelle);
            Calisan.Controls.Add(btnCalisanEkle);
            Calisan.Controls.Add(dgvCalisan);
            Calisan.Controls.Add(cmbDepartman);
            Calisan.Controls.Add(txtPozisyon);
            Calisan.Controls.Add(txtSoyad);
            Calisan.Controls.Add(txtAd);
            Calisan.Location = new Point(4, 34);
            Calisan.Name = "Calisan";
            Calisan.Padding = new Padding(3);
            Calisan.Size = new Size(977, 505);
            Calisan.TabIndex = 1;
            Calisan.Text = "Çalışan";
            Calisan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(734, 10);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 21;
            label5.Text = "Departman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(510, 10);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 20;
            label4.Text = "Pozisyon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(337, 11);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 19;
            label3.Text = "Soyadı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 13);
            label2.Name = "label2";
            label2.Size = new Size(39, 25);
            label2.TabIndex = 18;
            label2.Text = "Adı";
            // 
            // gbMuhendis
            // 
            gbMuhendis.Controls.Add(numYetkiSeviyesi);
            gbMuhendis.Controls.Add(btnMuhendisKaydet);
            gbMuhendis.Location = new Point(483, 111);
            gbMuhendis.Name = "gbMuhendis";
            gbMuhendis.Size = new Size(178, 108);
            gbMuhendis.TabIndex = 17;
            gbMuhendis.TabStop = false;
            gbMuhendis.Text = "Yetki Seviyesi";
            // 
            // numYetkiSeviyesi
            // 
            numYetkiSeviyesi.Location = new Point(6, 31);
            numYetkiSeviyesi.Name = "numYetkiSeviyesi";
            numYetkiSeviyesi.Size = new Size(154, 31);
            numYetkiSeviyesi.TabIndex = 11;
            numYetkiSeviyesi.ValueChanged += numYetkiSeviyesi_ValueChanged;
            // 
            // btnMuhendisKaydet
            // 
            btnMuhendisKaydet.Location = new Point(6, 67);
            btnMuhendisKaydet.Name = "btnMuhendisKaydet";
            btnMuhendisKaydet.Size = new Size(154, 34);
            btnMuhendisKaydet.TabIndex = 12;
            btnMuhendisKaydet.Text = "Kaydet";
            btnMuhendisKaydet.UseVisualStyleBackColor = true;
            // 
            // gbUretimPersoneli
            // 
            gbUretimPersoneli.Controls.Add(txtUzmanlikAlani);
            gbUretimPersoneli.Controls.Add(btnPersonelKaydet);
            gbUretimPersoneli.Location = new Point(288, 111);
            gbUretimPersoneli.Name = "gbUretimPersoneli";
            gbUretimPersoneli.Size = new Size(197, 108);
            gbUretimPersoneli.TabIndex = 16;
            gbUretimPersoneli.TabStop = false;
            gbUretimPersoneli.Text = "Uzmanlık Alanı";
            // 
            // txtUzmanlikAlani
            // 
            txtUzmanlikAlani.Location = new Point(6, 30);
            txtUzmanlikAlani.Name = "txtUzmanlikAlani";
            txtUzmanlikAlani.Size = new Size(150, 31);
            txtUzmanlikAlani.TabIndex = 9;
            // 
            // btnPersonelKaydet
            // 
            btnPersonelKaydet.Location = new Point(6, 67);
            btnPersonelKaydet.Name = "btnPersonelKaydet";
            btnPersonelKaydet.Size = new Size(152, 34);
            btnPersonelKaydet.TabIndex = 10;
            btnPersonelKaydet.Text = "Kaydet";
            btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // rbMuhendis
            // 
            rbMuhendis.AutoSize = true;
            rbMuhendis.Location = new Point(546, 76);
            rbMuhendis.Name = "rbMuhendis";
            rbMuhendis.Size = new Size(115, 29);
            rbMuhendis.TabIndex = 15;
            rbMuhendis.TabStop = true;
            rbMuhendis.Text = "Mühendis";
            rbMuhendis.UseVisualStyleBackColor = true;
            rbMuhendis.CheckedChanged += rbMuhendis_CheckedChanged;
            // 
            // rbUretimPersoneli
            // 
            rbUretimPersoneli.AutoSize = true;
            rbUretimPersoneli.Location = new Point(375, 76);
            rbUretimPersoneli.Name = "rbUretimPersoneli";
            rbUretimPersoneli.Size = new Size(165, 29);
            rbUretimPersoneli.TabIndex = 14;
            rbUretimPersoneli.TabStop = true;
            rbUretimPersoneli.Text = "Üretim Personeli";
            rbUretimPersoneli.UseVisualStyleBackColor = true;
            rbUretimPersoneli.CheckedChanged += rbUretimPersoneli_CheckedChanged;
            // 
            // rbGenel
            // 
            rbGenel.AutoSize = true;
            rbGenel.Location = new Point(288, 76);
            rbGenel.Name = "rbGenel";
            rbGenel.Size = new Size(81, 29);
            rbGenel.TabIndex = 13;
            rbGenel.TabStop = true;
            rbGenel.Text = "Genel";
            rbGenel.UseVisualStyleBackColor = true;
            rbGenel.CheckedChanged += rbGenel_CheckedChanged;
            // 
            // btnCalisanListele
            // 
            btnCalisanListele.Location = new Point(633, 218);
            btnCalisanListele.Name = "btnCalisanListele";
            btnCalisanListele.Size = new Size(132, 34);
            btnCalisanListele.TabIndex = 8;
            btnCalisanListele.Text = "Çalışan Listele";
            btnCalisanListele.UseVisualStyleBackColor = true;
            btnCalisanListele.Click += btnCalisanListele_Click;
            // 
            // btnCalisanSil
            // 
            btnCalisanSil.Location = new Point(351, 218);
            btnCalisanSil.Name = "btnCalisanSil";
            btnCalisanSil.Size = new Size(112, 34);
            btnCalisanSil.TabIndex = 7;
            btnCalisanSil.Text = "Çalışan Sil";
            btnCalisanSil.UseVisualStyleBackColor = true;
            btnCalisanSil.Click += btnCalisanSil_Click;
            // 
            // btnCalisanGuncelle
            // 
            btnCalisanGuncelle.Location = new Point(464, 218);
            btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            btnCalisanGuncelle.Size = new Size(168, 34);
            btnCalisanGuncelle.TabIndex = 6;
            btnCalisanGuncelle.Text = "Çalışan Güncelle";
            btnCalisanGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnCalisanEkle
            // 
            btnCalisanEkle.Location = new Point(233, 218);
            btnCalisanEkle.Name = "btnCalisanEkle";
            btnCalisanEkle.Size = new Size(112, 34);
            btnCalisanEkle.TabIndex = 5;
            btnCalisanEkle.Text = "Çalışan Ekle";
            btnCalisanEkle.UseVisualStyleBackColor = true;
            btnCalisanEkle.Click += btnCalisanEkle_Click;
            // 
            // dgvCalisan
            // 
            dgvCalisan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalisan.Location = new Point(5, 263);
            dgvCalisan.Name = "dgvCalisan";
            dgvCalisan.RowHeadersWidth = 62;
            dgvCalisan.Size = new Size(966, 236);
            dgvCalisan.TabIndex = 4;
            dgvCalisan.CellClick += dgvCalisan_CellClick;
            // 
            // cmbDepartman
            // 
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(673, 37);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(229, 33);
            cmbDepartman.TabIndex = 3;
            // 
            // txtPozisyon
            // 
            txtPozisyon.Location = new Point(470, 39);
            txtPozisyon.Name = "txtPozisyon";
            txtPozisyon.Size = new Size(197, 31);
            txtPozisyon.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(270, 39);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(197, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(71, 41);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(193, 31);
            txtAd.TabIndex = 0;
            // 
            // FormCalisanYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 550);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCalisanYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCalisan";
            Load += FormCalisanYonetimi_Load;
            tabControl1.ResumeLayout(false);
            Departman.ResumeLayout(false);
            Departman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDepartman).EndInit();
            Calisan.ResumeLayout(false);
            Calisan.PerformLayout();
            gbMuhendis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numYetkiSeviyesi).EndInit();
            gbUretimPersoneli.ResumeLayout(false);
            gbUretimPersoneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalisan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Departman;
        private TabPage Calisan;
        private TextBox txtDepartmanAdi;
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
        private RadioButton rbMuhendis;
        private RadioButton rbUretimPersoneli;
        private RadioButton rbGenel;
        private Button btnMuhendisKaydet;
        private NumericUpDown numYetkiSeviyesi;
        private Button btnPersonelKaydet;
        private TextBox txtUzmanlikAlani;
        private GroupBox gbMuhendis;
        private GroupBox gbUretimPersoneli;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}
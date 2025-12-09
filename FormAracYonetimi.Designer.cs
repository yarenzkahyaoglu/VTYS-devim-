namespace B241210094_VTYS
{
    partial class FormAracYonetimi
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
            dgvMarka = new DataGridView();
            btnMarkaListele = new Button();
            btnMarkaSil = new Button();
            btnMarkaGuncelle = new Button();
            btnMarkaEkle = new Button();
            txtMarkaAdi = new TextBox();
            label1 = new Label();
            cmbMarka = new ComboBox();
            txtModelAdi = new TextBox();
            txtUretimYili = new TextBox();
            btnModelEkle = new Button();
            btnModelGuncelle = new Button();
            btnModelSil = new Button();
            btnModelListele = new Button();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            cmbModel = new ComboBox();
            txtSaseNo = new TextBox();
            cmbDurum = new ComboBox();
            dtpUretimBaslangic = new DateTimePicker();
            dtpUretimBitis = new DateTimePicker();
            dgvModel = new DataGridView();
            btnAracEkle = new Button();
            btnAracGuncelle = new Button();
            btnAracSil = new Button();
            btnAracListele = new Button();
            dgvArac = new DataGridView();
            btnBinekKaydet = new Button();
            btnTicariKaydet = new Button();
            numKapasite = new NumericUpDown();
            numYukKapasitesi = new NumericUpDown();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarka).BeginInit();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArac).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numKapasite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYukKapasitesi).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 35);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(648, 388);
            tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvMarka);
            tabPage1.Controls.Add(btnMarkaListele);
            tabPage1.Controls.Add(btnMarkaSil);
            tabPage1.Controls.Add(btnMarkaGuncelle);
            tabPage1.Controls.Add(btnMarkaEkle);
            tabPage1.Controls.Add(txtMarkaAdi);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(640, 350);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Marka";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvModel);
            tabPage2.Controls.Add(btnModelListele);
            tabPage2.Controls.Add(btnModelSil);
            tabPage2.Controls.Add(btnModelGuncelle);
            tabPage2.Controls.Add(btnModelEkle);
            tabPage2.Controls.Add(txtUretimYili);
            tabPage2.Controls.Add(txtModelAdi);
            tabPage2.Controls.Add(cmbMarka);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(640, 350);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Model";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMarka
            // 
            dgvMarka.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarka.Location = new Point(83, 227);
            dgvMarka.Name = "dgvMarka";
            dgvMarka.RowHeadersWidth = 62;
            dgvMarka.Size = new Size(199, 105);
            dgvMarka.TabIndex = 13;
            // 
            // btnMarkaListele
            // 
            btnMarkaListele.Location = new Point(98, 189);
            btnMarkaListele.Name = "btnMarkaListele";
            btnMarkaListele.Size = new Size(162, 45);
            btnMarkaListele.TabIndex = 12;
            btnMarkaListele.Text = "Marka Listele";
            btnMarkaListele.UseVisualStyleBackColor = true;
            // 
            // btnMarkaSil
            // 
            btnMarkaSil.Location = new Point(98, 149);
            btnMarkaSil.Name = "btnMarkaSil";
            btnMarkaSil.Size = new Size(139, 45);
            btnMarkaSil.TabIndex = 11;
            btnMarkaSil.Text = "Marka Sil";
            btnMarkaSil.UseVisualStyleBackColor = true;
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.Location = new Point(72, 109);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(188, 45);
            btnMarkaGuncelle.TabIndex = 10;
            btnMarkaGuncelle.Text = "Marka Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnMarkaEkle
            // 
            btnMarkaEkle.Location = new Point(98, 69);
            btnMarkaEkle.Name = "btnMarkaEkle";
            btnMarkaEkle.Size = new Size(139, 45);
            btnMarkaEkle.TabIndex = 9;
            btnMarkaEkle.Text = "Marka Ekle";
            btnMarkaEkle.UseVisualStyleBackColor = true;
            // 
            // txtMarkaAdi
            // 
            txtMarkaAdi.Location = new Point(83, 32);
            txtMarkaAdi.Name = "txtMarkaAdi";
            txtMarkaAdi.Size = new Size(177, 31);
            txtMarkaAdi.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 4);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Marka";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(27, 43);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(182, 33);
            cmbMarka.TabIndex = 0;
            // 
            // txtModelAdi
            // 
            txtModelAdi.Location = new Point(248, 43);
            txtModelAdi.Name = "txtModelAdi";
            txtModelAdi.Size = new Size(150, 31);
            txtModelAdi.TabIndex = 1;
            // 
            // txtUretimYili
            // 
            txtUretimYili.Location = new Point(454, 50);
            txtUretimYili.Name = "txtUretimYili";
            txtUretimYili.Size = new Size(150, 31);
            txtUretimYili.TabIndex = 2;
            // 
            // btnModelEkle
            // 
            btnModelEkle.Location = new Point(52, 111);
            btnModelEkle.Name = "btnModelEkle";
            btnModelEkle.Size = new Size(112, 34);
            btnModelEkle.TabIndex = 3;
            btnModelEkle.Text = "Model Ekle";
            btnModelEkle.UseVisualStyleBackColor = true;
            // 
            // btnModelGuncelle
            // 
            btnModelGuncelle.Location = new Point(214, 122);
            btnModelGuncelle.Name = "btnModelGuncelle";
            btnModelGuncelle.Size = new Size(112, 34);
            btnModelGuncelle.TabIndex = 4;
            btnModelGuncelle.Text = "Model Güncelle";
            btnModelGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnModelSil
            // 
            btnModelSil.Location = new Point(356, 111);
            btnModelSil.Name = "btnModelSil";
            btnModelSil.Size = new Size(112, 34);
            btnModelSil.TabIndex = 5;
            btnModelSil.Text = "Model Sil";
            btnModelSil.UseVisualStyleBackColor = true;
            // 
            // btnModelListele
            // 
            btnModelListele.Location = new Point(492, 111);
            btnModelListele.Name = "btnModelListele";
            btnModelListele.Size = new Size(112, 34);
            btnModelListele.TabIndex = 6;
            btnModelListele.Text = "Model Listele";
            btnModelListele.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvArac);
            tabPage3.Controls.Add(btnAracListele);
            tabPage3.Controls.Add(btnAracSil);
            tabPage3.Controls.Add(btnAracGuncelle);
            tabPage3.Controls.Add(btnAracEkle);
            tabPage3.Controls.Add(dtpUretimBitis);
            tabPage3.Controls.Add(dtpUretimBaslangic);
            tabPage3.Controls.Add(cmbDurum);
            tabPage3.Controls.Add(txtSaseNo);
            tabPage3.Controls.Add(cmbModel);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(640, 350);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Araç";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(numKapasite);
            tabPage4.Controls.Add(btnBinekKaydet);
            tabPage4.Location = new Point(4, 34);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(640, 350);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Binek Araç";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(numYukKapasitesi);
            tabPage5.Controls.Add(btnTicariKaydet);
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(640, 350);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Ticari Araç";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(23, 30);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(182, 33);
            cmbModel.TabIndex = 0;
            // 
            // txtSaseNo
            // 
            txtSaseNo.Location = new Point(211, 30);
            txtSaseNo.Name = "txtSaseNo";
            txtSaseNo.Size = new Size(150, 31);
            txtSaseNo.TabIndex = 1;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Taslak", "Üretimde", "Test Aşamasında", "Tamamlandı", "Teslim Edildi" });
            cmbDurum.Location = new Point(367, 28);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(182, 33);
            cmbDurum.TabIndex = 2;
            // 
            // dtpUretimBaslangic
            // 
            dtpUretimBaslangic.Location = new Point(23, 80);
            dtpUretimBaslangic.Name = "dtpUretimBaslangic";
            dtpUretimBaslangic.Size = new Size(300, 31);
            dtpUretimBaslangic.TabIndex = 3;
            // 
            // dtpUretimBitis
            // 
            dtpUretimBitis.Location = new Point(329, 80);
            dtpUretimBitis.Name = "dtpUretimBitis";
            dtpUretimBitis.Size = new Size(300, 31);
            dtpUretimBitis.TabIndex = 4;
            // 
            // dgvModel
            // 
            dgvModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModel.Location = new Point(136, 183);
            dgvModel.Name = "dgvModel";
            dgvModel.RowHeadersWidth = 62;
            dgvModel.Size = new Size(363, 153);
            dgvModel.TabIndex = 7;
            // 
            // btnAracEkle
            // 
            btnAracEkle.Location = new Point(23, 139);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(112, 34);
            btnAracEkle.TabIndex = 5;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.UseVisualStyleBackColor = true;
            // 
            // btnAracGuncelle
            // 
            btnAracGuncelle.Location = new Point(149, 143);
            btnAracGuncelle.Name = "btnAracGuncelle";
            btnAracGuncelle.Size = new Size(149, 34);
            btnAracGuncelle.TabIndex = 6;
            btnAracGuncelle.Text = "Araç Güncelle";
            btnAracGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnAracSil
            // 
            btnAracSil.Location = new Point(323, 143);
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Size = new Size(112, 34);
            btnAracSil.TabIndex = 7;
            btnAracSil.Text = "Araç Sil";
            btnAracSil.UseVisualStyleBackColor = true;
            // 
            // btnAracListele
            // 
            btnAracListele.Location = new Point(447, 146);
            btnAracListele.Name = "btnAracListele";
            btnAracListele.Size = new Size(112, 34);
            btnAracListele.TabIndex = 8;
            btnAracListele.Text = "Araç Listele";
            btnAracListele.UseVisualStyleBackColor = true;
            // 
            // dgvArac
            // 
            dgvArac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArac.Location = new Point(149, 221);
            dgvArac.Name = "dgvArac";
            dgvArac.RowHeadersWidth = 62;
            dgvArac.Size = new Size(286, 90);
            dgvArac.TabIndex = 9;
            // 
            // btnBinekKaydet
            // 
            btnBinekKaydet.Location = new Point(149, 111);
            btnBinekKaydet.Name = "btnBinekKaydet";
            btnBinekKaydet.Size = new Size(112, 34);
            btnBinekKaydet.TabIndex = 1;
            btnBinekKaydet.Text = "Kaydet";
            btnBinekKaydet.UseVisualStyleBackColor = true;
            // 
            // btnTicariKaydet
            // 
            btnTicariKaydet.Location = new Point(259, 135);
            btnTicariKaydet.Name = "btnTicariKaydet";
            btnTicariKaydet.Size = new Size(112, 34);
            btnTicariKaydet.TabIndex = 0;
            btnTicariKaydet.Text = "Kaydet";
            btnTicariKaydet.UseVisualStyleBackColor = true;
            // 
            // numKapasite
            // 
            numKapasite.Location = new Point(230, 160);
            numKapasite.Name = "numKapasite";
            numKapasite.Size = new Size(180, 31);
            numKapasite.TabIndex = 2;
            // 
            // numYukKapasitesi
            // 
            numYukKapasitesi.Location = new Point(240, 70);
            numYukKapasitesi.Name = "numYukKapasitesi";
            numYukKapasitesi.Size = new Size(180, 31);
            numYukKapasitesi.TabIndex = 1;
            // 
            // FormAracYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormAracYonetimi";
            Text = "FormArac";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarka).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArac).EndInit();
            ((System.ComponentModel.ISupportInitialize)numKapasite).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYukKapasitesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvMarka;
        private Button btnMarkaListele;
        private Button btnMarkaSil;
        private Button btnMarkaGuncelle;
        private Button btnMarkaEkle;
        private TextBox txtMarkaAdi;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txtUretimYili;
        private TextBox txtModelAdi;
        private ComboBox cmbMarka;
        private Button btnModelListele;
        private Button btnModelSil;
        private Button btnModelGuncelle;
        private Button btnModelEkle;
        private TabPage tabPage3;
        private ComboBox cmbDurum;
        private TextBox txtSaseNo;
        private ComboBox cmbModel;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private DataGridView dgvModel;
        private DataGridView dgvArac;
        private Button btnAracListele;
        private Button btnAracSil;
        private Button btnAracGuncelle;
        private Button btnAracEkle;
        private DateTimePicker dtpUretimBitis;
        private DateTimePicker dtpUretimBaslangic;
        private Button btnBinekKaydet;
        private NumericUpDown numKapasite;
        private NumericUpDown numYukKapasitesi;
        private Button btnTicariKaydet;
    }
}
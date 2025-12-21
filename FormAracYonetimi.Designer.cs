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
            tabPage3 = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            gbTicari = new GroupBox();
            numYukKapasitesi = new NumericUpDown();
            rbBinek = new RadioButton();
            gbBinek = new GroupBox();
            numKapasite = new NumericUpDown();
            rbTicari = new RadioButton();
            rbGenel = new RadioButton();
            dgvArac = new DataGridView();
            btnAracListele = new Button();
            btnAracSil = new Button();
            btnAracGuncelle = new Button();
            btnAracEkle = new Button();
            dtpUretimBitis = new DateTimePicker();
            dtpUretimBaslangic = new DateTimePicker();
            cmbDurum = new ComboBox();
            txtSaseNo = new TextBox();
            cmbModel = new ComboBox();
            tabPage2 = new TabPage();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dgvModel = new DataGridView();
            btnModelListele = new Button();
            btnModelSil = new Button();
            btnModelGuncelle = new Button();
            btnModelEkle = new Button();
            txtUretimYili = new TextBox();
            txtModelAdi = new TextBox();
            cmbMarka = new ComboBox();
            tabPage1 = new TabPage();
            label2 = new Label();
            dgvMarka = new DataGridView();
            btnMarkaListele = new Button();
            btnMarkaSil = new Button();
            btnMarkaGuncelle = new Button();
            btnMarkaEkle = new Button();
            txtMarkaAdi = new TextBox();
            tabControl1 = new TabControl();
            tabPage3.SuspendLayout();
            gbTicari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numYukKapasitesi).BeginInit();
            gbBinek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numKapasite).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvArac).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarka).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(gbTicari);
            tabPage3.Controls.Add(rbBinek);
            tabPage3.Controls.Add(gbBinek);
            tabPage3.Controls.Add(rbTicari);
            tabPage3.Controls.Add(rbGenel);
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
            tabPage3.Size = new Size(884, 474);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Araç";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(506, 85);
            label10.Name = "label10";
            label10.Size = new Size(293, 25);
            label10.TabIndex = 19;
            label10.Text = "Aracın durumu için tarihlerini giriniz.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(552, 12);
            label9.Name = "label9";
            label9.Size = new Size(209, 25);
            label9.TabIndex = 18;
            label9.Text = "Aracın durumunu seçiniz.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 85);
            label8.Name = "label8";
            label8.Size = new Size(137, 25);
            label8.TabIndex = 17;
            label8.Text = "Araç tipi seçiniz.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(209, 12);
            label7.Name = "label7";
            label7.Size = new Size(128, 25);
            label7.TabIndex = 16;
            label7.Text = "ŞaseNo giriniz.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 12);
            label6.Name = "label6";
            label6.Size = new Size(123, 25);
            label6.TabIndex = 15;
            label6.Text = "Model seçiniz.";
            label6.Click += label6_Click;
            // 
            // gbTicari
            // 
            gbTicari.Controls.Add(numYukKapasitesi);
            gbTicari.Location = new Point(121, 150);
            gbTicari.Name = "gbTicari";
            gbTicari.Size = new Size(142, 72);
            gbTicari.TabIndex = 14;
            gbTicari.TabStop = false;
            gbTicari.Text = "Yük Kapasitesi";
            // 
            // numYukKapasitesi
            // 
            numYukKapasitesi.Location = new Point(6, 30);
            numYukKapasitesi.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numYukKapasitesi.Name = "numYukKapasitesi";
            numYukKapasitesi.Size = new Size(71, 31);
            numYukKapasitesi.TabIndex = 15;
            numYukKapasitesi.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // rbBinek
            // 
            rbBinek.AutoSize = true;
            rbBinek.Location = new Point(101, 113);
            rbBinek.Name = "rbBinek";
            rbBinek.Size = new Size(79, 29);
            rbBinek.TabIndex = 11;
            rbBinek.TabStop = true;
            rbBinek.Text = "Binek";
            rbBinek.UseVisualStyleBackColor = true;
            rbBinek.CheckedChanged += rbBinek_CheckedChanged;
            // 
            // gbBinek
            // 
            gbBinek.Controls.Add(numKapasite);
            gbBinek.Location = new Point(15, 150);
            gbBinek.Name = "gbBinek";
            gbBinek.Size = new Size(106, 72);
            gbBinek.TabIndex = 13;
            gbBinek.TabStop = false;
            gbBinek.Text = "Kapasite";
            // 
            // numKapasite
            // 
            numKapasite.Location = new Point(6, 30);
            numKapasite.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numKapasite.Name = "numKapasite";
            numKapasite.Size = new Size(60, 31);
            numKapasite.TabIndex = 4;
            // 
            // rbTicari
            // 
            rbTicari.AutoSize = true;
            rbTicari.Location = new Point(186, 113);
            rbTicari.Name = "rbTicari";
            rbTicari.Size = new Size(77, 29);
            rbTicari.TabIndex = 12;
            rbTicari.TabStop = true;
            rbTicari.Text = "Ticari";
            rbTicari.UseVisualStyleBackColor = true;
            rbTicari.CheckedChanged += rbTicari_CheckedChanged;
            // 
            // rbGenel
            // 
            rbGenel.AutoSize = true;
            rbGenel.Location = new Point(15, 113);
            rbGenel.Name = "rbGenel";
            rbGenel.Size = new Size(81, 29);
            rbGenel.TabIndex = 10;
            rbGenel.TabStop = true;
            rbGenel.Text = "Genel";
            rbGenel.UseVisualStyleBackColor = true;
            rbGenel.CheckedChanged += rbGenel_CheckedChanged;
            // 
            // dgvArac
            // 
            dgvArac.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArac.Location = new Point(3, 268);
            dgvArac.Name = "dgvArac";
            dgvArac.RowHeadersWidth = 62;
            dgvArac.Size = new Size(878, 203);
            dgvArac.TabIndex = 9;
            dgvArac.CellClick += dgvArac_CellClick;
            // 
            // btnAracListele
            // 
            btnAracListele.Location = new Point(564, 228);
            btnAracListele.Name = "btnAracListele";
            btnAracListele.Size = new Size(112, 34);
            btnAracListele.TabIndex = 8;
            btnAracListele.Text = "Araç Listele";
            btnAracListele.UseVisualStyleBackColor = true;
            btnAracListele.Click += btnAracListele_Click;
            // 
            // btnAracSil
            // 
            btnAracSil.Location = new Point(448, 228);
            btnAracSil.Name = "btnAracSil";
            btnAracSil.Size = new Size(112, 34);
            btnAracSil.TabIndex = 7;
            btnAracSil.Text = "Araç Sil";
            btnAracSil.UseVisualStyleBackColor = true;
            btnAracSil.Click += btnAracSil_Click;
            // 
            // btnAracGuncelle
            // 
            btnAracGuncelle.Location = new Point(293, 228);
            btnAracGuncelle.Name = "btnAracGuncelle";
            btnAracGuncelle.Size = new Size(149, 34);
            btnAracGuncelle.TabIndex = 6;
            btnAracGuncelle.Text = "Araç Güncelle";
            btnAracGuncelle.UseVisualStyleBackColor = true;
            btnAracGuncelle.Click += btnAracGuncelle_Click;
            // 
            // btnAracEkle
            // 
            btnAracEkle.Location = new Point(175, 228);
            btnAracEkle.Name = "btnAracEkle";
            btnAracEkle.Size = new Size(112, 34);
            btnAracEkle.TabIndex = 5;
            btnAracEkle.Text = "Araç Ekle";
            btnAracEkle.UseVisualStyleBackColor = true;
            btnAracEkle.Click += btnAracEkle_Click;
            // 
            // dtpUretimBitis
            // 
            dtpUretimBitis.Location = new Point(520, 150);
            dtpUretimBitis.Name = "dtpUretimBitis";
            dtpUretimBitis.Size = new Size(279, 31);
            dtpUretimBitis.TabIndex = 4;
            // 
            // dtpUretimBaslangic
            // 
            dtpUretimBaslangic.Location = new Point(520, 113);
            dtpUretimBaslangic.Name = "dtpUretimBaslangic";
            dtpUretimBaslangic.Size = new Size(279, 31);
            dtpUretimBaslangic.TabIndex = 3;
            // 
            // cmbDurum
            // 
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Items.AddRange(new object[] { "Taslak", "Uretimde", "Test", "Tamamlandi", "Teslim Edildi" });
            cmbDurum.Location = new Point(552, 40);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(220, 33);
            cmbDurum.TabIndex = 2;
            // 
            // txtSaseNo
            // 
            txtSaseNo.Location = new Point(203, 40);
            txtSaseNo.Name = "txtSaseNo";
            txtSaseNo.Size = new Size(150, 31);
            txtSaseNo.TabIndex = 1;
            // 
            // cmbModel
            // 
            cmbModel.FormattingEnabled = true;
            cmbModel.Location = new Point(15, 40);
            cmbModel.Name = "cmbModel";
            cmbModel.Size = new Size(182, 33);
            cmbModel.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label1);
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
            tabPage2.Size = new Size(884, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Model";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 61);
            label5.Name = "label5";
            label5.Size = new Size(221, 25);
            label5.TabIndex = 11;
            label5.Text = "Aracın üretim yılınız giriniz.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(236, 61);
            label4.Name = "label4";
            label4.Size = new Size(196, 25);
            label4.TabIndex = 10;
            label4.Text = "Aracın modelini yazınız.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 59);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 9;
            label3.Text = "Aracın markasını seçiniz.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 3);
            label1.Name = "label1";
            label1.Size = new Size(404, 25);
            label1.TabIndex = 8;
            label1.Text = "Markasını girdiğiniz aracın model bilgilerini giriniz.";
            label1.Click += label1_Click;
            // 
            // dgvModel
            // 
            dgvModel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvModel.Location = new Point(24, 166);
            dgvModel.Name = "dgvModel";
            dgvModel.RowHeadersWidth = 62;
            dgvModel.Size = new Size(738, 302);
            dgvModel.TabIndex = 7;
            dgvModel.CellClick += dgvModel_CellClick;
            // 
            // btnModelListele
            // 
            btnModelListele.Location = new Point(448, 126);
            btnModelListele.Name = "btnModelListele";
            btnModelListele.Size = new Size(164, 34);
            btnModelListele.TabIndex = 6;
            btnModelListele.Text = "Model Listele";
            btnModelListele.UseVisualStyleBackColor = true;
            // 
            // btnModelSil
            // 
            btnModelSil.Location = new Point(330, 126);
            btnModelSil.Name = "btnModelSil";
            btnModelSil.Size = new Size(112, 34);
            btnModelSil.TabIndex = 5;
            btnModelSil.Text = "Model Sil";
            btnModelSil.UseVisualStyleBackColor = true;
            btnModelSil.Click += btnModelSil_Click;
            // 
            // btnModelGuncelle
            // 
            btnModelGuncelle.Location = new Point(140, 126);
            btnModelGuncelle.Name = "btnModelGuncelle";
            btnModelGuncelle.Size = new Size(184, 34);
            btnModelGuncelle.TabIndex = 4;
            btnModelGuncelle.Text = "Model Güncelle";
            btnModelGuncelle.UseVisualStyleBackColor = true;
            btnModelGuncelle.Click += btnModelGuncelle_Click;
            // 
            // btnModelEkle
            // 
            btnModelEkle.Location = new Point(27, 126);
            btnModelEkle.Name = "btnModelEkle";
            btnModelEkle.Size = new Size(112, 34);
            btnModelEkle.TabIndex = 3;
            btnModelEkle.Text = "Model Ekle";
            btnModelEkle.UseVisualStyleBackColor = true;
            btnModelEkle.Click += btnModelEkle_Click;
            // 
            // txtUretimYili
            // 
            txtUretimYili.Location = new Point(447, 89);
            txtUretimYili.Name = "txtUretimYili";
            txtUretimYili.Size = new Size(165, 31);
            txtUretimYili.TabIndex = 2;
            // 
            // txtModelAdi
            // 
            txtModelAdi.Location = new Point(237, 89);
            txtModelAdi.Name = "txtModelAdi";
            txtModelAdi.Size = new Size(184, 31);
            txtModelAdi.TabIndex = 1;
            // 
            // cmbMarka
            // 
            cmbMarka.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(27, 87);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(182, 33);
            cmbMarka.TabIndex = 0;
            cmbMarka.SelectedIndexChanged += cmbMarka_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dgvMarka);
            tabPage1.Controls.Add(btnMarkaListele);
            tabPage1.Controls.Add(btnMarkaSil);
            tabPage1.Controls.Add(btnMarkaGuncelle);
            tabPage1.Controls.Add(btnMarkaEkle);
            tabPage1.Controls.Add(txtMarkaAdi);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(884, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Marka";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(233, 25);
            label2.TabIndex = 14;
            label2.Text = "Aracın marka bilgileri giriniz.";
            // 
            // dgvMarka
            // 
            dgvMarka.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarka.Location = new Point(6, 94);
            dgvMarka.Name = "dgvMarka";
            dgvMarka.RowHeadersWidth = 62;
            dgvMarka.Size = new Size(829, 374);
            dgvMarka.TabIndex = 13;
            dgvMarka.CellClick += dgvMarka_CellClick;
            // 
            // btnMarkaListele
            // 
            btnMarkaListele.Location = new Point(673, 57);
            btnMarkaListele.Name = "btnMarkaListele";
            btnMarkaListele.Size = new Size(162, 31);
            btnMarkaListele.TabIndex = 12;
            btnMarkaListele.Text = "Marka Listele";
            btnMarkaListele.UseVisualStyleBackColor = true;
            btnMarkaListele.Click += btnMarkaListele_Click;
            // 
            // btnMarkaSil
            // 
            btnMarkaSil.Location = new Point(528, 57);
            btnMarkaSil.Name = "btnMarkaSil";
            btnMarkaSil.Size = new Size(139, 31);
            btnMarkaSil.TabIndex = 11;
            btnMarkaSil.Text = "Marka Sil";
            btnMarkaSil.UseVisualStyleBackColor = true;
            btnMarkaSil.Click += btnMarkaSil_Click;
            // 
            // btnMarkaGuncelle
            // 
            btnMarkaGuncelle.Location = new Point(373, 57);
            btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            btnMarkaGuncelle.Size = new Size(149, 31);
            btnMarkaGuncelle.TabIndex = 10;
            btnMarkaGuncelle.Text = "Marka Güncelle";
            btnMarkaGuncelle.UseVisualStyleBackColor = true;
            btnMarkaGuncelle.Click += btnMarkaGuncelle_Click;
            // 
            // btnMarkaEkle
            // 
            btnMarkaEkle.Location = new Point(245, 57);
            btnMarkaEkle.Name = "btnMarkaEkle";
            btnMarkaEkle.Size = new Size(122, 31);
            btnMarkaEkle.TabIndex = 9;
            btnMarkaEkle.Text = "Marka Ekle";
            btnMarkaEkle.UseVisualStyleBackColor = true;
            btnMarkaEkle.Click += btnMarkaEkle_Click;
            // 
            // txtMarkaAdi
            // 
            txtMarkaAdi.Location = new Point(6, 57);
            txtMarkaAdi.Name = "txtMarkaAdi";
            txtMarkaAdi.Size = new Size(233, 31);
            txtMarkaAdi.TabIndex = 8;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(892, 512);
            tabControl1.TabIndex = 7;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // FormAracYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 536);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAracYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormArac";
            Load += FormAracYonetimi_Load_1;
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            gbTicari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numYukKapasitesi).EndInit();
            gbBinek.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numKapasite).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvArac).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvModel).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMarka).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private TabPage tabPage3;
        private GroupBox gbTicari;
        private NumericUpDown numYukKapasitesi;
        private GroupBox gbBinek;
        private NumericUpDown numKapasite;
        private RadioButton rbTicari;
        private RadioButton rbBinek;
        private RadioButton rbGenel;
        private DataGridView dgvArac;
        private Button btnAracListele;
        private Button btnAracSil;
        private Button btnAracGuncelle;
        private Button btnAracEkle;
        private DateTimePicker dtpUretimBitis;
        private DateTimePicker dtpUretimBaslangic;
        private ComboBox cmbDurum;
        private TextBox txtSaseNo;
        private ComboBox cmbModel;
        private TabPage tabPage2;
        private DataGridView dgvModel;
        private Button btnModelListele;
        private Button btnModelSil;
        private Button btnModelGuncelle;
        private Button btnModelEkle;
        private TextBox txtUretimYili;
        private TextBox txtModelAdi;
        private ComboBox cmbMarka;
        private TabPage tabPage1;
        private DataGridView dgvMarka;
        private Button btnMarkaListele;
        private Button btnMarkaSil;
        private Button btnMarkaGuncelle;
        private Button btnMarkaEkle;
        private TextBox txtMarkaAdi;
        private TabControl tabControl1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
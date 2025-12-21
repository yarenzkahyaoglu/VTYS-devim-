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
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvMusteri = new DataGridView();
            btnMusteriListele = new Button();
            btnMusteriSil = new Button();
            btnMusteriGuncelle = new Button();
            btnMusteriEkle = new Button();
            txtEmail = new TextBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            tabPage2 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvTeslimat = new DataGridView();
            btnTeslimListele = new Button();
            btnTeslimSil = new Button();
            btnTeslimEkle = new Button();
            dtpTeslimTarihi = new DateTimePicker();
            cmbMusteri = new ComboBox();
            cmbArac = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTeslimat).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 461);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
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
            tabPage1.Size = new Size(867, 423);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Müşteri";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(640, 21);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 12;
            label4.Text = "E-Mail";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(480, 21);
            label3.Name = "label3";
            label3.Size = new Size(68, 25);
            label3.TabIndex = 11;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 21);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 10;
            label2.Text = "Soyadı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 9;
            label1.Text = "Adı";
            // 
            // dgvMusteri
            // 
            dgvMusteri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteri.Location = new Point(17, 139);
            dgvMusteri.Name = "dgvMusteri";
            dgvMusteri.RowHeadersWidth = 62;
            dgvMusteri.Size = new Size(834, 274);
            dgvMusteri.TabIndex = 8;
            dgvMusteri.CellClick += dgvMusteri_CellClick;
            // 
            // btnMusteriListele
            // 
            btnMusteriListele.Location = new Point(581, 97);
            btnMusteriListele.Name = "btnMusteriListele";
            btnMusteriListele.Size = new Size(151, 34);
            btnMusteriListele.TabIndex = 7;
            btnMusteriListele.Text = "Müşteri Listele";
            btnMusteriListele.UseVisualStyleBackColor = true;
            btnMusteriListele.Click += btnMusteriListele_Click;
            // 
            // btnMusteriSil
            // 
            btnMusteriSil.Location = new Point(288, 97);
            btnMusteriSil.Name = "btnMusteriSil";
            btnMusteriSil.Size = new Size(112, 34);
            btnMusteriSil.TabIndex = 6;
            btnMusteriSil.Text = "Müşteri Sil";
            btnMusteriSil.UseVisualStyleBackColor = true;
            btnMusteriSil.Click += btnMusteriSil_Click;
            // 
            // btnMusteriGuncelle
            // 
            btnMusteriGuncelle.Location = new Point(406, 97);
            btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            btnMusteriGuncelle.Size = new Size(169, 34);
            btnMusteriGuncelle.TabIndex = 5;
            btnMusteriGuncelle.Text = "Müşteri Güncelle";
            btnMusteriGuncelle.UseVisualStyleBackColor = true;
            btnMusteriGuncelle.Click += btnMusteriGuncelle_Click;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.Location = new Point(122, 97);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(139, 34);
            btnMusteriEkle.TabIndex = 4;
            btnMusteriEkle.Text = "Müşteri Ekle";
            btnMusteriEkle.UseVisualStyleBackColor = true;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(590, 49);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 3;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(434, 49);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 31);
            txtTelefon.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(278, 49);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(150, 31);
            txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(122, 49);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(150, 31);
            txtAd.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
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
            tabPage2.Size = new Size(867, 423);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Teslimat";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(579, 23);
            label7.Name = "label7";
            label7.Size = new Size(180, 25);
            label7.TabIndex = 9;
            label7.Text = "Teslimat Tarihi seçiniz.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(346, 25);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 8;
            label6.Text = "Müşteri seçiniz.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(104, 25);
            label5.Name = "label5";
            label5.Size = new Size(119, 25);
            label5.TabIndex = 7;
            label5.Text = "Araba seçiniz.";
            // 
            // dgvTeslimat
            // 
            dgvTeslimat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTeslimat.Location = new Point(14, 135);
            dgvTeslimat.Name = "dgvTeslimat";
            dgvTeslimat.RowHeadersWidth = 62;
            dgvTeslimat.Size = new Size(828, 282);
            dgvTeslimat.TabIndex = 6;
            // 
            // btnTeslimListele
            // 
            btnTeslimListele.Location = new Point(570, 88);
            btnTeslimListele.Name = "btnTeslimListele";
            btnTeslimListele.Size = new Size(189, 41);
            btnTeslimListele.TabIndex = 5;
            btnTeslimListele.Text = "Teslimat Listele";
            btnTeslimListele.UseVisualStyleBackColor = true;
            btnTeslimListele.Click += btnTeslimListele_Click;
            // 
            // btnTeslimSil
            // 
            btnTeslimSil.Location = new Point(321, 92);
            btnTeslimSil.Name = "btnTeslimSil";
            btnTeslimSil.Size = new Size(156, 41);
            btnTeslimSil.TabIndex = 4;
            btnTeslimSil.Text = "Teslimat Sil";
            btnTeslimSil.UseVisualStyleBackColor = true;
            btnTeslimSil.Click += btnTeslimSil_Click;
            // 
            // btnTeslimEkle
            // 
            btnTeslimEkle.Location = new Point(83, 92);
            btnTeslimEkle.Name = "btnTeslimEkle";
            btnTeslimEkle.Size = new Size(169, 41);
            btnTeslimEkle.TabIndex = 3;
            btnTeslimEkle.Text = "Teslimat Ekle";
            btnTeslimEkle.UseVisualStyleBackColor = true;
            btnTeslimEkle.Click += btnTeslimEkle_Click;
            // 
            // dtpTeslimTarihi
            // 
            dtpTeslimTarihi.Location = new Point(528, 51);
            dtpTeslimTarihi.Name = "dtpTeslimTarihi";
            dtpTeslimTarihi.Size = new Size(300, 31);
            dtpTeslimTarihi.TabIndex = 2;
            // 
            // cmbMusteri
            // 
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(289, 51);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(214, 33);
            cmbMusteri.TabIndex = 1;
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(70, 53);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(194, 33);
            cmbArac.TabIndex = 0;
            // 
            // FormMusteriYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 477);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMusteriYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMusteriYonetimi";
            Load += FormMusteriYonetimi_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteri).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}
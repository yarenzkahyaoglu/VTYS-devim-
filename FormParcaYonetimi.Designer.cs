namespace B241210094_VTYS
{
    partial class FormParcaYonetimi
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
            label8 = new Label();
            dgvKategori = new DataGridView();
            btnKategoriListele = new Button();
            btnKategoriSil = new Button();
            btnKategoriGuncelle = new Button();
            btnKategoriEkle = new Button();
            txtKategoriAdi = new TextBox();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvParca = new DataGridView();
            btnParcaListele = new Button();
            btnParcaSil = new Button();
            btnParcaGuncelle = new Button();
            btnParcaEkle = new Button();
            numFiyat = new NumericUpDown();
            numStok = new NumericUpDown();
            txtParcaAdi = new TextBox();
            cmbKategori = new ComboBox();
            tabPage3 = new TabPage();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dgvAracParca = new DataGridView();
            btnAracParcaListele = new Button();
            btnAracParcaSil = new Button();
            btnAracParcaEkle = new Button();
            numAdet = new NumericUpDown();
            cmbParca = new ComboBox();
            cmbArac = new ComboBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAracParca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(930, 449);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(dgvKategori);
            tabPage1.Controls.Add(btnKategoriListele);
            tabPage1.Controls.Add(btnKategoriSil);
            tabPage1.Controls.Add(btnKategoriGuncelle);
            tabPage1.Controls.Add(btnKategoriEkle);
            tabPage1.Controls.Add(txtKategoriAdi);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(922, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parça Kategori Bölümü";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 62);
            label8.Name = "label8";
            label8.Size = new Size(136, 25);
            label8.TabIndex = 6;
            label8.Text = "Parça Kategorisi";
            // 
            // dgvKategori
            // 
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(312, 90);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 62;
            dgvKategori.Size = new Size(526, 287);
            dgvKategori.TabIndex = 5;
            dgvKategori.CellClick += dgvKategori_CellClick;
            // 
            // btnKategoriListele
            // 
            btnKategoriListele.Location = new Point(123, 321);
            btnKategoriListele.Name = "btnKategoriListele";
            btnKategoriListele.Size = new Size(174, 56);
            btnKategoriListele.TabIndex = 4;
            btnKategoriListele.Text = "Kategori Listele";
            btnKategoriListele.UseVisualStyleBackColor = true;
            btnKategoriListele.Click += btnKategoriListele_Click;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.Location = new Point(123, 259);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(174, 56);
            btnKategoriSil.TabIndex = 3;
            btnKategoriSil.Text = "Kategori Sil";
            btnKategoriSil.UseVisualStyleBackColor = true;
            btnKategoriSil.Click += btnKategoriSil_Click;
            // 
            // btnKategoriGuncelle
            // 
            btnKategoriGuncelle.Location = new Point(123, 197);
            btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            btnKategoriGuncelle.Size = new Size(174, 56);
            btnKategoriGuncelle.TabIndex = 2;
            btnKategoriGuncelle.Text = "Kategori Güncelle";
            btnKategoriGuncelle.UseVisualStyleBackColor = true;
            btnKategoriGuncelle.Click += btnKategoriGuncelle_Click;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(123, 135);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(174, 56);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            btnKategoriEkle.Click += btnKategoriEkle_Click;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(123, 90);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(174, 31);
            txtKategoriAdi.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(dgvParca);
            tabPage2.Controls.Add(btnParcaListele);
            tabPage2.Controls.Add(btnParcaSil);
            tabPage2.Controls.Add(btnParcaGuncelle);
            tabPage2.Controls.Add(btnParcaEkle);
            tabPage2.Controls.Add(numFiyat);
            tabPage2.Controls.Add(numStok);
            tabPage2.Controls.Add(txtParcaAdi);
            tabPage2.Controls.Add(cmbKategori);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(922, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Parça Bölümü";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(706, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 12;
            label4.Text = "Fiyatı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(496, 36);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 11;
            label3.Text = "Stok Miktarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(310, 30);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 10;
            label2.Text = "Parça Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 34);
            label1.Name = "label1";
            label1.Size = new Size(136, 25);
            label1.TabIndex = 9;
            label1.Text = "Parça Kategorisi";
            // 
            // dgvParca
            // 
            dgvParca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParca.Location = new Point(28, 137);
            dgvParca.Name = "dgvParca";
            dgvParca.RowHeadersWidth = 62;
            dgvParca.Size = new Size(860, 266);
            dgvParca.TabIndex = 8;
            dgvParca.CellClick += dgvParca_CellClick;
            // 
            // btnParcaListele
            // 
            btnParcaListele.Location = new Point(568, 101);
            btnParcaListele.Name = "btnParcaListele";
            btnParcaListele.Size = new Size(153, 34);
            btnParcaListele.TabIndex = 7;
            btnParcaListele.Text = "Parça Listele";
            btnParcaListele.UseVisualStyleBackColor = true;
            btnParcaListele.Click += btnParcaListele_Click;
            // 
            // btnParcaSil
            // 
            btnParcaSil.Location = new Point(297, 101);
            btnParcaSil.Name = "btnParcaSil";
            btnParcaSil.Size = new Size(112, 34);
            btnParcaSil.TabIndex = 6;
            btnParcaSil.Text = "Parça Sil";
            btnParcaSil.UseVisualStyleBackColor = true;
            btnParcaSil.Click += btnParcaSil_Click;
            // 
            // btnParcaGuncelle
            // 
            btnParcaGuncelle.Location = new Point(415, 101);
            btnParcaGuncelle.Name = "btnParcaGuncelle";
            btnParcaGuncelle.Size = new Size(147, 34);
            btnParcaGuncelle.TabIndex = 5;
            btnParcaGuncelle.Text = "Parça Güncelle";
            btnParcaGuncelle.UseVisualStyleBackColor = true;
            btnParcaGuncelle.Click += btnParcaGuncelle_Click;
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.Location = new Point(179, 101);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(112, 34);
            btnParcaEkle.TabIndex = 4;
            btnParcaEkle.Text = "Parça Ekle";
            btnParcaEkle.UseVisualStyleBackColor = true;
            btnParcaEkle.Click += btnParcaEkle_Click;
            // 
            // numFiyat
            // 
            numFiyat.Location = new Point(643, 62);
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(180, 31);
            numFiyat.TabIndex = 3;
            // 
            // numStok
            // 
            numStok.Location = new Point(453, 64);
            numStok.Name = "numStok";
            numStok.Size = new Size(180, 31);
            numStok.TabIndex = 2;
            // 
            // txtParcaAdi
            // 
            txtParcaAdi.Location = new Point(246, 63);
            txtParcaAdi.Name = "txtParcaAdi";
            txtParcaAdi.Size = new Size(201, 31);
            txtParcaAdi.TabIndex = 1;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(47, 62);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(193, 33);
            cmbKategori.TabIndex = 0;
            cmbKategori.SelectedIndexChanged += cmbArac_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label7);
            tabPage3.Controls.Add(label6);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(dgvAracParca);
            tabPage3.Controls.Add(btnAracParcaListele);
            tabPage3.Controls.Add(btnAracParcaSil);
            tabPage3.Controls.Add(btnAracParcaEkle);
            tabPage3.Controls.Add(numAdet);
            tabPage3.Controls.Add(cmbParca);
            tabPage3.Controls.Add(cmbArac);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(922, 411);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Araç-Parça Bölümü";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(662, 23);
            label7.Name = "label7";
            label7.Size = new Size(105, 25);
            label7.TabIndex = 9;
            label7.Text = "Parça Adedi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(448, 24);
            label6.Name = "label6";
            label6.Size = new Size(53, 25);
            label6.TabIndex = 8;
            label6.Text = "Parça";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 24);
            label5.Name = "label5";
            label5.Size = new Size(47, 25);
            label5.TabIndex = 7;
            label5.Text = "Araç";
            // 
            // dgvAracParca
            // 
            dgvAracParca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAracParca.Location = new Point(7, 149);
            dgvAracParca.Name = "dgvAracParca";
            dgvAracParca.RowHeadersWidth = 62;
            dgvAracParca.Size = new Size(910, 259);
            dgvAracParca.TabIndex = 6;
            // 
            // btnAracParcaListele
            // 
            btnAracParcaListele.Location = new Point(543, 101);
            btnAracParcaListele.Name = "btnAracParcaListele";
            btnAracParcaListele.Size = new Size(162, 34);
            btnAracParcaListele.TabIndex = 5;
            btnAracParcaListele.Text = "Araç Parça Listele";
            btnAracParcaListele.UseVisualStyleBackColor = true;
            btnAracParcaListele.Click += btnAracParcaListele_Click;
            // 
            // btnAracParcaSil
            // 
            btnAracParcaSil.Location = new Point(399, 101);
            btnAracParcaSil.Name = "btnAracParcaSil";
            btnAracParcaSil.Size = new Size(138, 34);
            btnAracParcaSil.TabIndex = 4;
            btnAracParcaSil.Text = "Araç Parça Sil";
            btnAracParcaSil.UseVisualStyleBackColor = true;
            btnAracParcaSil.Click += btnAracParcaSil_Click;
            // 
            // btnAracParcaEkle
            // 
            btnAracParcaEkle.Location = new Point(251, 101);
            btnAracParcaEkle.Name = "btnAracParcaEkle";
            btnAracParcaEkle.Size = new Size(142, 34);
            btnAracParcaEkle.TabIndex = 3;
            btnAracParcaEkle.Text = "Araç Parça Ekle";
            btnAracParcaEkle.UseVisualStyleBackColor = true;
            btnAracParcaEkle.Click += btnAracParcaEkle_Click;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(620, 51);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(180, 31);
            numAdet.TabIndex = 2;
            // 
            // cmbParca
            // 
            cmbParca.FormattingEnabled = true;
            cmbParca.Location = new Point(360, 52);
            cmbParca.Name = "cmbParca";
            cmbParca.Size = new Size(233, 33);
            cmbParca.TabIndex = 1;
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(128, 52);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(216, 33);
            cmbArac.TabIndex = 0;
            cmbArac.SelectedIndexChanged += cmbArac_SelectedIndexChanged;
            // 
            // FormParcaYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 452);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormParcaYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormParcaYonetimi";
            Load += FormParcaYonetimi_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvParca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAracParca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dgvKategori;
        private Button btnKategoriListele;
        private Button btnKategoriSil;
        private Button btnKategoriGuncelle;
        private Button btnKategoriEkle;
        private TextBox txtKategoriAdi;
        private ComboBox cmbKategori;
        private DataGridView dgvParca;
        private Button btnParcaListele;
        private Button btnParcaSil;
        private Button btnParcaGuncelle;
        private Button btnParcaEkle;
        private NumericUpDown numFiyat;
        private NumericUpDown numStok;
        private TextBox txtParcaAdi;
        private ComboBox cmbArac;
        private ComboBox cmbParca;
        private DataGridView dgvAracParca;
        private Button btnAracParcaListele;
        private Button btnAracParcaSil;
        private Button btnAracParcaEkle;
        private NumericUpDown numAdet;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
    }
}
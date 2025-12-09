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
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            txtKategoriAdi = new TextBox();
            btnKategoriEkle = new Button();
            btnKategoriGuncelle = new Button();
            btnKategoriSil = new Button();
            btnKategoriListele = new Button();
            dgvKategori = new DataGridView();
            cmbKategori = new ComboBox();
            txtParcaAdi = new TextBox();
            numStok = new NumericUpDown();
            numFiyat = new NumericUpDown();
            btnParcaEkle = new Button();
            btnParcaGuncelle = new Button();
            btnParcaSil = new Button();
            btnParcaListele = new Button();
            dgvParca = new DataGridView();
            cmbArac = new ComboBox();
            cmbParca = new ComboBox();
            numAdet = new NumericUpDown();
            btnAracParcaEkle = new Button();
            btnAracParcaSil = new Button();
            btnAracParcaListele = new Button();
            dgvAracParca = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKategori).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvParca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAracParca).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(23, 34);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(764, 389);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvKategori);
            tabPage1.Controls.Add(btnKategoriListele);
            tabPage1.Controls.Add(btnKategoriSil);
            tabPage1.Controls.Add(btnKategoriGuncelle);
            tabPage1.Controls.Add(btnKategoriEkle);
            tabPage1.Controls.Add(txtKategoriAdi);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(756, 351);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parça Kategori Bölümü";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
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
            tabPage2.Size = new Size(756, 351);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Parça Bölümü";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvAracParca);
            tabPage3.Controls.Add(btnAracParcaListele);
            tabPage3.Controls.Add(btnAracParcaSil);
            tabPage3.Controls.Add(btnAracParcaEkle);
            tabPage3.Controls.Add(numAdet);
            tabPage3.Controls.Add(cmbParca);
            tabPage3.Controls.Add(cmbArac);
            tabPage3.Location = new Point(4, 34);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(756, 351);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Araç-Parça Bölümü";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtKategoriAdi
            // 
            txtKategoriAdi.Location = new Point(6, 6);
            txtKategoriAdi.Name = "txtKategoriAdi";
            txtKategoriAdi.Size = new Size(150, 31);
            txtKategoriAdi.TabIndex = 0;
            // 
            // btnKategoriEkle
            // 
            btnKategoriEkle.Location = new Point(6, 54);
            btnKategoriEkle.Name = "btnKategoriEkle";
            btnKategoriEkle.Size = new Size(134, 34);
            btnKategoriEkle.TabIndex = 1;
            btnKategoriEkle.Text = "Kategori Ekle";
            btnKategoriEkle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriGuncelle
            // 
            btnKategoriGuncelle.Location = new Point(6, 94);
            btnKategoriGuncelle.Name = "btnKategoriGuncelle";
            btnKategoriGuncelle.Size = new Size(174, 34);
            btnKategoriGuncelle.TabIndex = 2;
            btnKategoriGuncelle.Text = "Kategori Güncelle";
            btnKategoriGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKategoriSil
            // 
            btnKategoriSil.Location = new Point(6, 134);
            btnKategoriSil.Name = "btnKategoriSil";
            btnKategoriSil.Size = new Size(112, 34);
            btnKategoriSil.TabIndex = 3;
            btnKategoriSil.Text = "Kategori Sil";
            btnKategoriSil.UseVisualStyleBackColor = true;
            // 
            // btnKategoriListele
            // 
            btnKategoriListele.Location = new Point(6, 174);
            btnKategoriListele.Name = "btnKategoriListele";
            btnKategoriListele.Size = new Size(159, 34);
            btnKategoriListele.TabIndex = 4;
            btnKategoriListele.Text = "Kategori Listele";
            btnKategoriListele.UseVisualStyleBackColor = true;
            // 
            // dgvKategori
            // 
            dgvKategori.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKategori.Location = new Point(209, 6);
            dgvKategori.Name = "dgvKategori";
            dgvKategori.RowHeadersWidth = 62;
            dgvKategori.Size = new Size(240, 222);
            dgvKategori.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(24, 14);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(182, 33);
            cmbKategori.TabIndex = 0;
            // 
            // txtParcaAdi
            // 
            txtParcaAdi.Location = new Point(244, 14);
            txtParcaAdi.Name = "txtParcaAdi";
            txtParcaAdi.Size = new Size(150, 31);
            txtParcaAdi.TabIndex = 1;
            // 
            // numStok
            // 
            numStok.Location = new Point(26, 74);
            numStok.Name = "numStok";
            numStok.Size = new Size(180, 31);
            numStok.TabIndex = 2;
            // 
            // numFiyat
            // 
            numFiyat.Location = new Point(244, 74);
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(180, 31);
            numFiyat.TabIndex = 3;
            // 
            // btnParcaEkle
            // 
            btnParcaEkle.Location = new Point(18, 121);
            btnParcaEkle.Name = "btnParcaEkle";
            btnParcaEkle.Size = new Size(112, 34);
            btnParcaEkle.TabIndex = 4;
            btnParcaEkle.Text = "Parça Ekle";
            btnParcaEkle.UseVisualStyleBackColor = true;
            // 
            // btnParcaGuncelle
            // 
            btnParcaGuncelle.Location = new Point(136, 121);
            btnParcaGuncelle.Name = "btnParcaGuncelle";
            btnParcaGuncelle.Size = new Size(147, 34);
            btnParcaGuncelle.TabIndex = 5;
            btnParcaGuncelle.Text = "Parça Güncelle";
            btnParcaGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnParcaSil
            // 
            btnParcaSil.Location = new Point(298, 121);
            btnParcaSil.Name = "btnParcaSil";
            btnParcaSil.Size = new Size(112, 34);
            btnParcaSil.TabIndex = 6;
            btnParcaSil.Text = "Parça Sil";
            btnParcaSil.UseVisualStyleBackColor = true;
            // 
            // btnParcaListele
            // 
            btnParcaListele.Location = new Point(18, 175);
            btnParcaListele.Name = "btnParcaListele";
            btnParcaListele.Size = new Size(153, 34);
            btnParcaListele.TabIndex = 7;
            btnParcaListele.Text = "Parça Listele";
            btnParcaListele.UseVisualStyleBackColor = true;
            // 
            // dgvParca
            // 
            dgvParca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParca.Location = new Point(225, 185);
            dgvParca.Name = "dgvParca";
            dgvParca.RowHeadersWidth = 62;
            dgvParca.Size = new Size(199, 115);
            dgvParca.TabIndex = 8;
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(35, 26);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(182, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbParca
            // 
            cmbParca.FormattingEnabled = true;
            cmbParca.Location = new Point(243, 26);
            cmbParca.Name = "cmbParca";
            cmbParca.Size = new Size(182, 33);
            cmbParca.TabIndex = 1;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(37, 82);
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(180, 31);
            numAdet.TabIndex = 2;
            // 
            // btnAracParcaEkle
            // 
            btnAracParcaEkle.Location = new Point(43, 132);
            btnAracParcaEkle.Name = "btnAracParcaEkle";
            btnAracParcaEkle.Size = new Size(142, 34);
            btnAracParcaEkle.TabIndex = 3;
            btnAracParcaEkle.Text = "Araç Parça Ekle";
            btnAracParcaEkle.UseVisualStyleBackColor = true;
            // 
            // btnAracParcaSil
            // 
            btnAracParcaSil.Location = new Point(43, 181);
            btnAracParcaSil.Name = "btnAracParcaSil";
            btnAracParcaSil.Size = new Size(138, 34);
            btnAracParcaSil.TabIndex = 4;
            btnAracParcaSil.Text = "Araç Parça Sil";
            btnAracParcaSil.UseVisualStyleBackColor = true;
            // 
            // btnAracParcaListele
            // 
            btnAracParcaListele.Location = new Point(37, 221);
            btnAracParcaListele.Name = "btnAracParcaListele";
            btnAracParcaListele.Size = new Size(162, 34);
            btnAracParcaListele.TabIndex = 5;
            btnAracParcaListele.Text = "Araç Parça Listele";
            btnAracParcaListele.UseVisualStyleBackColor = true;
            // 
            // dgvAracParca
            // 
            dgvAracParca.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAracParca.Location = new Point(243, 82);
            dgvAracParca.Name = "dgvAracParca";
            dgvAracParca.RowHeadersWidth = 62;
            dgvAracParca.Size = new Size(238, 87);
            dgvAracParca.TabIndex = 6;
            // 
            // FormParcaYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "FormParcaYonetimi";
            Text = "FormParcaYonetimi";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvKategori).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvParca).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAracParca).EndInit();
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
    }
}
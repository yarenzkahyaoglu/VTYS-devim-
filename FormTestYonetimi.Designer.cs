namespace B241210094_VTYS
{
    partial class FormTestYonetimi
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
            cmbArac = new ComboBox();
            cmbMuhendis = new ComboBox();
            cmbTestSonucu = new ComboBox();
            dtpTestTarihi = new DateTimePicker();
            btnTestKaydet = new Button();
            btnTestSil = new Button();
            btnTestListele = new Button();
            dgvTest = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTest).BeginInit();
            SuspendLayout();
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(12, 56);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(193, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbMuhendis
            // 
            cmbMuhendis.FormattingEnabled = true;
            cmbMuhendis.Location = new Point(222, 56);
            cmbMuhendis.Name = "cmbMuhendis";
            cmbMuhendis.Size = new Size(226, 33);
            cmbMuhendis.TabIndex = 1;
            // 
            // cmbTestSonucu
            // 
            cmbTestSonucu.AutoCompleteCustomSource.AddRange(new string[] { "Başarılı", "Başarısız" });
            cmbTestSonucu.FormattingEnabled = true;
            cmbTestSonucu.Items.AddRange(new object[] { "Başarılı", "Başarısız" });
            cmbTestSonucu.Location = new Point(466, 56);
            cmbTestSonucu.Name = "cmbTestSonucu";
            cmbTestSonucu.Size = new Size(207, 33);
            cmbTestSonucu.TabIndex = 2;
            // 
            // dtpTestTarihi
            // 
            dtpTestTarihi.Location = new Point(688, 56);
            dtpTestTarihi.Name = "dtpTestTarihi";
            dtpTestTarihi.Size = new Size(285, 31);
            dtpTestTarihi.TabIndex = 3;
            // 
            // btnTestKaydet
            // 
            btnTestKaydet.Location = new Point(138, 108);
            btnTestKaydet.Name = "btnTestKaydet";
            btnTestKaydet.Size = new Size(163, 34);
            btnTestKaydet.TabIndex = 4;
            btnTestKaydet.Text = "Test Kaydet";
            btnTestKaydet.UseVisualStyleBackColor = true;
            btnTestKaydet.Click += btnTestKaydet_Click;
            // 
            // btnTestSil
            // 
            btnTestSil.Location = new Point(381, 108);
            btnTestSil.Name = "btnTestSil";
            btnTestSil.Size = new Size(163, 34);
            btnTestSil.TabIndex = 5;
            btnTestSil.Text = "Test Sil";
            btnTestSil.UseVisualStyleBackColor = true;
            btnTestSil.Click += btnTestSil_Click;
            // 
            // btnTestListele
            // 
            btnTestListele.Location = new Point(616, 108);
            btnTestListele.Name = "btnTestListele";
            btnTestListele.Size = new Size(163, 34);
            btnTestListele.TabIndex = 6;
            btnTestListele.Text = "Test Listele";
            btnTestListele.UseVisualStyleBackColor = true;
            btnTestListele.Click += btnTestListele_Click;
            // 
            // dgvTest
            // 
            dgvTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTest.Location = new Point(12, 148);
            dgvTest.Name = "dgvTest";
            dgvTest.RowHeadersWidth = 62;
            dgvTest.Size = new Size(961, 361);
            dgvTest.TabIndex = 7;
            dgvTest.CellClick += dgvTest_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(170, 25);
            label1.TabIndex = 8;
            label1.Text = "Test için araç seçiniz.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 28);
            label2.Name = "label2";
            label2.Size = new Size(262, 25);
            label2.TabIndex = 9;
            label2.Text = "Testi yapacak mühendisi seçiniz.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 28);
            label3.Name = "label3";
            label3.Size = new Size(164, 25);
            label3.TabIndex = 10;
            label3.Text = "Test sonucu seçiniz.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(758, 28);
            label4.Name = "label4";
            label4.Size = new Size(146, 25);
            label4.TabIndex = 11;
            label4.Text = "Test tarihi seçiniz.";
            // 
            // FormTestYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 521);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvTest);
            Controls.Add(btnTestListele);
            Controls.Add(btnTestSil);
            Controls.Add(btnTestKaydet);
            Controls.Add(dtpTestTarihi);
            Controls.Add(cmbTestSonucu);
            Controls.Add(cmbMuhendis);
            Controls.Add(cmbArac);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormTestYonetimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormTestYonetimi";
            Load += FormTestYonetimi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbArac;
        private ComboBox cmbMuhendis;
        private ComboBox cmbTestSonucu;
        private DateTimePicker dtpTestTarihi;
        private Button btnTestKaydet;
        private Button btnTestSil;
        private Button btnTestListele;
        private DataGridView dgvTest;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
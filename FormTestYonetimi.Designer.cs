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
            cmbSonuc = new ComboBox();
            dtpTestTarihi = new DateTimePicker();
            btnTestKaydet = new Button();
            btnTestSil = new Button();
            button1 = new Button();
            dgvTest = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTest).BeginInit();
            SuspendLayout();
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(12, 12);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(182, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbMuhendis
            // 
            cmbMuhendis.FormattingEnabled = true;
            cmbMuhendis.Location = new Point(12, 51);
            cmbMuhendis.Name = "cmbMuhendis";
            cmbMuhendis.Size = new Size(182, 33);
            cmbMuhendis.TabIndex = 1;
            // 
            // cmbSonuc
            // 
            cmbSonuc.AutoCompleteCustomSource.AddRange(new string[] { "Başarılı", "Başarısız" });
            cmbSonuc.FormattingEnabled = true;
            cmbSonuc.Location = new Point(12, 90);
            cmbSonuc.Name = "cmbSonuc";
            cmbSonuc.Size = new Size(182, 33);
            cmbSonuc.TabIndex = 2;
            // 
            // dtpTestTarihi
            // 
            dtpTestTarihi.Location = new Point(12, 129);
            dtpTestTarihi.Name = "dtpTestTarihi";
            dtpTestTarihi.Size = new Size(300, 31);
            dtpTestTarihi.TabIndex = 3;
            // 
            // btnTestKaydet
            // 
            btnTestKaydet.Location = new Point(23, 190);
            btnTestKaydet.Name = "btnTestKaydet";
            btnTestKaydet.Size = new Size(112, 34);
            btnTestKaydet.TabIndex = 4;
            btnTestKaydet.Text = "Test Kaydet";
            btnTestKaydet.UseVisualStyleBackColor = true;
            // 
            // btnTestSil
            // 
            btnTestSil.Location = new Point(182, 193);
            btnTestSil.Name = "btnTestSil";
            btnTestSil.Size = new Size(112, 34);
            btnTestSil.TabIndex = 5;
            btnTestSil.Text = "Test Sil";
            btnTestSil.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(340, 199);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "btnTestListele";
            button1.UseVisualStyleBackColor = true;
            // 
            // dgvTest
            // 
            dgvTest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTest.Location = new Point(40, 263);
            dgvTest.Name = "dgvTest";
            dgvTest.RowHeadersWidth = 62;
            dgvTest.Size = new Size(374, 175);
            dgvTest.TabIndex = 7;
            // 
            // FormTestYonetimi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvTest);
            Controls.Add(button1);
            Controls.Add(btnTestSil);
            Controls.Add(btnTestKaydet);
            Controls.Add(dtpTestTarihi);
            Controls.Add(cmbSonuc);
            Controls.Add(cmbMuhendis);
            Controls.Add(cmbArac);
            Name = "FormTestYonetimi";
            Text = "FormTestYonetimi";
            ((System.ComponentModel.ISupportInitialize)dgvTest).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbArac;
        private ComboBox cmbMuhendis;
        private ComboBox cmbSonuc;
        private DateTimePicker dtpTestTarihi;
        private Button btnTestKaydet;
        private Button btnTestSil;
        private Button button1;
        private DataGridView dgvTest;
    }
}
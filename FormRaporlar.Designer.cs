namespace B241210094_VTYS
{
    partial class FormRaporlar
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
            cmbRaporTuru = new ComboBox();
            btnRaporGetir = new Button();
            dgvRapor = new DataGridView();
            btnPDFAktar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // cmbRaporTuru
            // 
            cmbRaporTuru.FormattingEnabled = true;
            cmbRaporTuru.Location = new Point(185, 59);
            cmbRaporTuru.Name = "cmbRaporTuru";
            cmbRaporTuru.Size = new Size(182, 33);
            cmbRaporTuru.TabIndex = 0;
            // 
            // btnRaporGetir
            // 
            btnRaporGetir.Location = new Point(210, 103);
            btnRaporGetir.Name = "btnRaporGetir";
            btnRaporGetir.Size = new Size(112, 34);
            btnRaporGetir.TabIndex = 1;
            btnRaporGetir.Text = "Rapor Getir";
            btnRaporGetir.UseVisualStyleBackColor = true;
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(113, 143);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 62;
            dgvRapor.Size = new Size(360, 225);
            dgvRapor.TabIndex = 2;
            // 
            // btnPDFAktar
            // 
            btnPDFAktar.Location = new Point(244, 395);
            btnPDFAktar.Name = "btnPDFAktar";
            btnPDFAktar.Size = new Size(112, 34);
            btnPDFAktar.TabIndex = 3;
            btnPDFAktar.Text = "PDF Aktar";
            btnPDFAktar.UseVisualStyleBackColor = true;
            // 
            // FormRaporlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPDFAktar);
            Controls.Add(dgvRapor);
            Controls.Add(btnRaporGetir);
            Controls.Add(cmbRaporTuru);
            Name = "FormRaporlar";
            Text = "FormRapor";
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbRaporTuru;
        private Button btnRaporGetir;
        private DataGridView dgvRapor;
        private Button btnPDFAktar;
    }
}
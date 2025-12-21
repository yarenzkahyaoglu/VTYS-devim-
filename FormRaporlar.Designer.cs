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
            label1 = new Label();
            btnAra = new Button();
            btnTemizle = new Button();
            label2 = new Label();
            txtArama = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRapor).BeginInit();
            SuspendLayout();
            // 
            // cmbRaporTuru
            // 
            cmbRaporTuru.FormattingEnabled = true;
            cmbRaporTuru.Location = new Point(248, 6);
            cmbRaporTuru.Name = "cmbRaporTuru";
            cmbRaporTuru.Size = new Size(582, 33);
            cmbRaporTuru.TabIndex = 0;
            // 
            // btnRaporGetir
            // 
            btnRaporGetir.Location = new Point(856, 6);
            btnRaporGetir.Name = "btnRaporGetir";
            btnRaporGetir.Size = new Size(112, 34);
            btnRaporGetir.TabIndex = 1;
            btnRaporGetir.Text = "Rapor Getir";
            btnRaporGetir.UseVisualStyleBackColor = true;
            btnRaporGetir.Click += btnRaporGetir_Click;
            // 
            // dgvRapor
            // 
            dgvRapor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRapor.Location = new Point(12, 147);
            dgvRapor.Name = "dgvRapor";
            dgvRapor.RowHeadersWidth = 62;
            dgvRapor.Size = new Size(1120, 371);
            dgvRapor.TabIndex = 2;
            // 
            // btnPDFAktar
            // 
            btnPDFAktar.Location = new Point(534, 524);
            btnPDFAktar.Name = "btnPDFAktar";
            btnPDFAktar.Size = new Size(112, 34);
            btnPDFAktar.TabIndex = 3;
            btnPDFAktar.Text = "PDF Aktar";
            btnPDFAktar.UseVisualStyleBackColor = true;
            btnPDFAktar.Click += btnPDFAktar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 4;
            label1.Text = "Rapor seçiniz.";
            // 
            // btnAra
            // 
            btnAra.Location = new Point(718, 80);
            btnAra.Name = "btnAra";
            btnAra.Size = new Size(112, 33);
            btnAra.TabIndex = 5;
            btnAra.Text = "Ara";
            btnAra.UseVisualStyleBackColor = true;
            btnAra.Click += btnAra_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(836, 80);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(112, 32);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 7;
            label2.Text = "Kayıt Ara";
            // 
            // txtArama
            // 
            txtArama.Location = new Point(248, 81);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(450, 31);
            txtArama.TabIndex = 8;
            txtArama.TextChanged += txtArama_TextChanged;
            txtArama.KeyPress += txtArama_KeyPress;
            // 
            // FormRaporlar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 563);
            Controls.Add(txtArama);
            Controls.Add(label2);
            Controls.Add(btnTemizle);
            Controls.Add(btnAra);
            Controls.Add(label1);
            Controls.Add(btnPDFAktar);
            Controls.Add(dgvRapor);
            Controls.Add(btnRaporGetir);
            Controls.Add(cmbRaporTuru);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormRaporlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRapor";
            Load += FormRaporlar_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRapor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRaporTuru;
        private Button btnRaporGetir;
        private DataGridView dgvRapor;
        private Button btnPDFAktar;
        private Label label1;
        private Button btnAra;
        private Button btnTemizle;
        private Label label2;
        private TextBox txtArama;
    }
}
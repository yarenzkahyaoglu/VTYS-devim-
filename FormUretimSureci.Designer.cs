namespace B241210094_VTYS
{
    partial class FormUretimSureci
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
            cmbCalisan = new ComboBox();
            txtAciklama = new TextBox();
            dtpTarih = new DateTimePicker();
            btnSurecEkle = new Button();
            btnSurecSil = new Button();
            btnSurecListele = new Button();
            dgvSurec = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSurec).BeginInit();
            SuspendLayout();
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(57, 21);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(182, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbCalisan
            // 
            cmbCalisan.FormattingEnabled = true;
            cmbCalisan.Location = new Point(57, 69);
            cmbCalisan.Name = "cmbCalisan";
            cmbCalisan.Size = new Size(182, 33);
            cmbCalisan.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(57, 122);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(150, 31);
            txtAciklama.TabIndex = 2;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(57, 174);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(300, 31);
            dtpTarih.TabIndex = 3;
            // 
            // btnSurecEkle
            // 
            btnSurecEkle.Location = new Point(56, 231);
            btnSurecEkle.Name = "btnSurecEkle";
            btnSurecEkle.Size = new Size(112, 34);
            btnSurecEkle.TabIndex = 4;
            btnSurecEkle.Text = "Süreç Ekle";
            btnSurecEkle.UseVisualStyleBackColor = true;
            // 
            // btnSurecSil
            // 
            btnSurecSil.Location = new Point(200, 236);
            btnSurecSil.Name = "btnSurecSil";
            btnSurecSil.Size = new Size(112, 34);
            btnSurecSil.TabIndex = 5;
            btnSurecSil.Text = "Süreç Sil";
            btnSurecSil.UseVisualStyleBackColor = true;
            // 
            // btnSurecListele
            // 
            btnSurecListele.Location = new Point(318, 236);
            btnSurecListele.Name = "btnSurecListele";
            btnSurecListele.Size = new Size(157, 34);
            btnSurecListele.TabIndex = 6;
            btnSurecListele.Text = "Süreç Listele";
            btnSurecListele.UseVisualStyleBackColor = true;
            // 
            // dgvSurec
            // 
            dgvSurec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSurec.Location = new Point(56, 302);
            dgvSurec.Name = "dgvSurec";
            dgvSurec.RowHeadersWidth = 62;
            dgvSurec.Size = new Size(360, 125);
            dgvSurec.TabIndex = 7;
            // 
            // FormUretimSureci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSurec);
            Controls.Add(btnSurecListele);
            Controls.Add(btnSurecSil);
            Controls.Add(btnSurecEkle);
            Controls.Add(dtpTarih);
            Controls.Add(txtAciklama);
            Controls.Add(cmbCalisan);
            Controls.Add(cmbArac);
            Name = "FormUretimSureci";
            Text = "FormUretimSureci";
            ((System.ComponentModel.ISupportInitialize)dgvSurec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbArac;
        private ComboBox cmbCalisan;
        private TextBox txtAciklama;
        private DateTimePicker dtpTarih;
        private Button btnSurecEkle;
        private Button btnSurecSil;
        private Button btnSurecListele;
        private DataGridView dgvSurec;
    }
}
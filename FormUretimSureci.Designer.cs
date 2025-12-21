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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSurec).BeginInit();
            SuspendLayout();
            // 
            // cmbArac
            // 
            cmbArac.FormattingEnabled = true;
            cmbArac.Location = new Point(12, 37);
            cmbArac.Name = "cmbArac";
            cmbArac.Size = new Size(212, 33);
            cmbArac.TabIndex = 0;
            // 
            // cmbCalisan
            // 
            cmbCalisan.FormattingEnabled = true;
            cmbCalisan.Location = new Point(248, 37);
            cmbCalisan.Name = "cmbCalisan";
            cmbCalisan.Size = new Size(231, 33);
            cmbCalisan.TabIndex = 1;
            // 
            // txtAciklama
            // 
            txtAciklama.Location = new Point(503, 39);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(398, 31);
            txtAciklama.TabIndex = 2;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(256, 112);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(393, 31);
            dtpTarih.TabIndex = 3;
            // 
            // btnSurecEkle
            // 
            btnSurecEkle.Location = new Point(256, 151);
            btnSurecEkle.Name = "btnSurecEkle";
            btnSurecEkle.Size = new Size(112, 34);
            btnSurecEkle.TabIndex = 4;
            btnSurecEkle.Text = "Süreç Ekle";
            btnSurecEkle.UseVisualStyleBackColor = true;
            btnSurecEkle.Click += btnSurecEkle_Click;
            // 
            // btnSurecSil
            // 
            btnSurecSil.Location = new Point(374, 151);
            btnSurecSil.Name = "btnSurecSil";
            btnSurecSil.Size = new Size(112, 34);
            btnSurecSil.TabIndex = 5;
            btnSurecSil.Text = "Süreç Sil";
            btnSurecSil.UseVisualStyleBackColor = true;
            btnSurecSil.Click += btnSurecSil_Click;
            // 
            // btnSurecListele
            // 
            btnSurecListele.Location = new Point(492, 151);
            btnSurecListele.Name = "btnSurecListele";
            btnSurecListele.Size = new Size(157, 34);
            btnSurecListele.TabIndex = 6;
            btnSurecListele.Text = "Süreç Listele";
            btnSurecListele.UseVisualStyleBackColor = true;
            btnSurecListele.Click += btnSurecListele_Click;
            // 
            // dgvSurec
            // 
            dgvSurec.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSurec.Location = new Point(11, 189);
            dgvSurec.Name = "dgvSurec";
            dgvSurec.RowHeadersWidth = 62;
            dgvSurec.Size = new Size(890, 296);
            dgvSurec.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 25);
            label1.TabIndex = 8;
            label1.Text = "Üretimdeki Araç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 9);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 9;
            label2.Text = "Üretimi Yürüten Çalışan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(593, 11);
            label3.Name = "label3";
            label3.Size = new Size(239, 25);
            label3.TabIndex = 10;
            label3.Text = "Üretimdeki araç için açıklama";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(402, 84);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 11;
            label4.Text = "Üretim Tarihi";
            // 
            // FormUretimSureci
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 495);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvSurec);
            Controls.Add(btnSurecListele);
            Controls.Add(btnSurecSil);
            Controls.Add(btnSurecEkle);
            Controls.Add(dtpTarih);
            Controls.Add(txtAciklama);
            Controls.Add(cmbCalisan);
            Controls.Add(cmbArac);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormUretimSureci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormUretimSureci";
            Load += FormUretimSureci_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
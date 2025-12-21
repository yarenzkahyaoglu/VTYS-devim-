namespace B241210094_VTYS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAracYonetimi = new Button();
            btnParcaYonetimi = new Button();
            btnCalisanYonetimi = new Button();
            btnRaporlar = new Button();
            btnCikis = new Button();
            btnUretimSureci = new Button();
            btnTestYonetimi = new Button();
            btnMusteriTeslim = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAracYonetimi
            // 
            btnAracYonetimi.Location = new Point(115, 51);
            btnAracYonetimi.Name = "btnAracYonetimi";
            btnAracYonetimi.Size = new Size(274, 80);
            btnAracYonetimi.TabIndex = 0;
            btnAracYonetimi.Text = "Araç Yönetimi";
            btnAracYonetimi.UseVisualStyleBackColor = true;
            btnAracYonetimi.Click += btnAracYonetimi_Click;
            // 
            // btnParcaYonetimi
            // 
            btnParcaYonetimi.Location = new Point(409, 51);
            btnParcaYonetimi.Name = "btnParcaYonetimi";
            btnParcaYonetimi.Size = new Size(274, 80);
            btnParcaYonetimi.TabIndex = 1;
            btnParcaYonetimi.Text = "Parça Yönetimi";
            btnParcaYonetimi.UseVisualStyleBackColor = true;
            btnParcaYonetimi.Click += btnParcaYonetimi_Click;
            // 
            // btnCalisanYonetimi
            // 
            btnCalisanYonetimi.Location = new Point(115, 137);
            btnCalisanYonetimi.Name = "btnCalisanYonetimi";
            btnCalisanYonetimi.Size = new Size(274, 73);
            btnCalisanYonetimi.TabIndex = 2;
            btnCalisanYonetimi.Text = "Çalışan/Departman Yönetimi";
            btnCalisanYonetimi.UseVisualStyleBackColor = true;
            btnCalisanYonetimi.Click += btnCalisanYonetimi_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(237, 304);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(333, 68);
            btnRaporlar.TabIndex = 3;
            btnRaporlar.Text = "Rapor İşlemleri";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(345, 378);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(112, 34);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnUretimSureci
            // 
            btnUretimSureci.Location = new Point(409, 137);
            btnUretimSureci.Name = "btnUretimSureci";
            btnUretimSureci.Size = new Size(274, 73);
            btnUretimSureci.TabIndex = 5;
            btnUretimSureci.Text = "Üretim Süreci";
            btnUretimSureci.UseVisualStyleBackColor = true;
            btnUretimSureci.Click += btnUretimSureci_Click;
            // 
            // btnTestYonetimi
            // 
            btnTestYonetimi.Location = new Point(115, 216);
            btnTestYonetimi.Name = "btnTestYonetimi";
            btnTestYonetimi.Size = new Size(274, 82);
            btnTestYonetimi.TabIndex = 6;
            btnTestYonetimi.Text = "Test Yönetimi";
            btnTestYonetimi.UseVisualStyleBackColor = true;
            btnTestYonetimi.Click += btnTestYonetimi_Click;
            // 
            // btnMusteriTeslim
            // 
            btnMusteriTeslim.Location = new Point(409, 216);
            btnMusteriTeslim.Name = "btnMusteriTeslim";
            btnMusteriTeslim.Size = new Size(274, 82);
            btnMusteriTeslim.TabIndex = 7;
            btnMusteriTeslim.Text = "Müşteri Teslim Süreci";
            btnMusteriTeslim.UseVisualStyleBackColor = true;
            btnMusteriTeslim.Click += btnMusteriTeslim_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(218, 23);
            label1.Name = "label1";
            label1.Size = new Size(362, 25);
            label1.TabIndex = 8;
            label1.Text = "ARAÇ ÜRETİM FABRİKASI YÖNETİM SİSTEMİ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 416);
            Controls.Add(label1);
            Controls.Add(btnMusteriTeslim);
            Controls.Add(btnTestYonetimi);
            Controls.Add(btnUretimSureci);
            Controls.Add(btnCikis);
            Controls.Add(btnRaporlar);
            Controls.Add(btnCalisanYonetimi);
            Controls.Add(btnParcaYonetimi);
            Controls.Add(btnAracYonetimi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAracYonetimi;
        private Button btnParcaYonetimi;
        private Button btnCalisanYonetimi;
        private Button btnRaporlar;
        private Button btnCikis;
        private Button btnUretimSureci;
        private Button btnTestYonetimi;
        private Button btnMusteriTeslim;
        private Label label1;
    }
}

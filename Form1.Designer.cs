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
            SuspendLayout();
            // 
            // btnAracYonetimi
            // 
            btnAracYonetimi.Location = new Point(12, 12);
            btnAracYonetimi.Name = "btnAracYonetimi";
            btnAracYonetimi.Size = new Size(251, 53);
            btnAracYonetimi.TabIndex = 0;
            btnAracYonetimi.Text = "Araç Yönetimi";
            btnAracYonetimi.UseVisualStyleBackColor = true;
            btnAracYonetimi.Click += btnAracYonetimi_Click;
            // 
            // btnParcaYonetimi
            // 
            btnParcaYonetimi.Location = new Point(269, 12);
            btnParcaYonetimi.Name = "btnParcaYonetimi";
            btnParcaYonetimi.Size = new Size(186, 53);
            btnParcaYonetimi.TabIndex = 1;
            btnParcaYonetimi.Text = "Parça Yönetimi";
            btnParcaYonetimi.UseVisualStyleBackColor = true;
            btnParcaYonetimi.Click += btnParcaYonetimi_Click;
            // 
            // btnCalisanYonetimi
            // 
            btnCalisanYonetimi.Location = new Point(12, 80);
            btnCalisanYonetimi.Name = "btnCalisanYonetimi";
            btnCalisanYonetimi.Size = new Size(184, 41);
            btnCalisanYonetimi.TabIndex = 2;
            btnCalisanYonetimi.Text = "Çalışan/Departman Yönetimi";
            btnCalisanYonetimi.UseVisualStyleBackColor = true;
            btnCalisanYonetimi.Click += btnCalisanYonetimi_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(149, 254);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(167, 50);
            btnRaporlar.TabIndex = 3;
            btnRaporlar.Text = "Rapor & İşlemler";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnCikis
            // 
            btnCikis.Location = new Point(186, 325);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(112, 34);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click;
            // 
            // btnUretimSureci
            // 
            btnUretimSureci.Location = new Point(269, 71);
            btnUretimSureci.Name = "btnUretimSureci";
            btnUretimSureci.Size = new Size(211, 58);
            btnUretimSureci.TabIndex = 5;
            btnUretimSureci.Text = "Üretim Süreci";
            btnUretimSureci.UseVisualStyleBackColor = true;
            btnUretimSureci.Click += btnUretimSureci_Click;
            // 
            // btnTestYonetimi
            // 
            btnTestYonetimi.Location = new Point(12, 144);
            btnTestYonetimi.Name = "btnTestYonetimi";
            btnTestYonetimi.Size = new Size(195, 86);
            btnTestYonetimi.TabIndex = 6;
            btnTestYonetimi.Text = "Test Yönetimi";
            btnTestYonetimi.UseVisualStyleBackColor = true;
            btnTestYonetimi.Click += btnTestYonetimi_Click;
            // 
            // btnMusteriTeslim
            // 
            btnMusteriTeslim.Location = new Point(269, 151);
            btnMusteriTeslim.Name = "btnMusteriTeslim";
            btnMusteriTeslim.Size = new Size(194, 72);
            btnMusteriTeslim.TabIndex = 7;
            btnMusteriTeslim.Text = "Müşteri Teslim Süreci";
            btnMusteriTeslim.UseVisualStyleBackColor = true;
            btnMusteriTeslim.Click += btnMusteriTeslim_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMusteriTeslim);
            Controls.Add(btnTestYonetimi);
            Controls.Add(btnUretimSureci);
            Controls.Add(btnCikis);
            Controls.Add(btnRaporlar);
            Controls.Add(btnCalisanYonetimi);
            Controls.Add(btnParcaYonetimi);
            Controls.Add(btnAracYonetimi);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
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
    }
}

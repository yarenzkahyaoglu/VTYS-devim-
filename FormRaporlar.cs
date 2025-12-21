using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace B241210094_VTYS
{
    public partial class FormRaporlar : Form
    {
        private DataTable originalData; // Orijinal veriyi saklayacak

        public FormRaporlar()
        {
            InitializeComponent();
        }

        private void FormRaporlar_Load(object sender, EventArgs e)
        {
            RaporTuruDoldur();
        }

        private void RaporTuruDoldur()
        {
            cmbRaporTuru.Items.Clear();
            cmbRaporTuru.Items.Add("1 - Araç Durum Raporu");
            cmbRaporTuru.Items.Add("2 - Parça Stok Raporu");
            cmbRaporTuru.Items.Add("3 - Üretim Süreci Raporu");
            cmbRaporTuru.Items.Add("4 - Test Sonuçları Raporu");
            cmbRaporTuru.Items.Add("5 - Teslimat Raporu");
            cmbRaporTuru.Items.Add("6 - Müşteri Raporu");
            cmbRaporTuru.Items.Add("7 - Çalışan Raporu");
            cmbRaporTuru.SelectedIndex = 0;
        }

        private void btnRaporGetir_Click(object sender, EventArgs e)
        {
            if (cmbRaporTuru.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir rapor türü seçin!");
                return;
            }

            string secim = cmbRaporTuru.SelectedItem.ToString();

            try
            {
                if (secim.StartsWith("1"))
                    AracDurumRaporu();
                else if (secim.StartsWith("2"))
                    ParcaStokRaporu();
                else if (secim.StartsWith("3"))
                    UretimSureciRaporu();
                else if (secim.StartsWith("4"))
                    TestSonuclariRaporu();
                else if (secim.StartsWith("5"))
                    TeslimatRaporu();
                else if (secim.StartsWith("6"))
                    MusteriRaporu();
                else if (secim.StartsWith("7"))
                    CalisanRaporu();

                // Arama kutusunu temizle
                txtArama.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // ARAMA FONKSİYONU
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (originalData == null || originalData.Rows.Count == 0)
            {
                MessageBox.Show("Önce bir rapor getirin!");
                return;
            }

            string aramaMetni = txtArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                dgvRapor.DataSource = originalData;
                return;
            }

            try
            {
                DataTable filteredData = originalData.Clone(); // Aynı yapıda yeni tablo

                foreach (DataRow row in originalData.Rows)
                {
                    bool eslesmeVar = false;

                    // Tüm sütunlarda ara
                    foreach (DataColumn col in originalData.Columns)
                    {
                        if (row[col] != DBNull.Value &&
                            row[col].ToString().ToLower().Contains(aramaMetni))
                        {
                            eslesmeVar = true;
                            break;
                        }
                    }

                    if (eslesmeVar)
                    {
                        filteredData.ImportRow(row);
                    }
                }

                dgvRapor.DataSource = filteredData;
                MessageBox.Show($"{filteredData.Rows.Count} kayıt bulundu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama hatası: " + ex.Message);
            }
        }

        // TEMİZLE FONKSİYONU
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
            if (originalData != null)
            {
                dgvRapor.DataSource = originalData;
            }
        }

        // txtArama için Enter tuşu desteği
        private void txtArama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAra_Click(sender, e);
                e.Handled = true;
            }
        }

        // Yazdıkça otomatik arama (TextChanged event'i)
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            if (originalData == null || originalData.Rows.Count == 0)
                return;

            string aramaMetni = txtArama.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(aramaMetni))
            {
                dgvRapor.DataSource = originalData;
                return;
            }

            try
            {
                DataTable filteredData = originalData.Clone();

                foreach (DataRow row in originalData.Rows)
                {
                    bool eslesmeVar = false;

                    foreach (DataColumn col in originalData.Columns)
                    {
                        if (row[col] != DBNull.Value &&
                            row[col].ToString().ToLower().Contains(aramaMetni))
                        {
                            eslesmeVar = true;
                            break;
                        }
                    }

                    if (eslesmeVar)
                    {
                        filteredData.ImportRow(row);
                    }
                }

                dgvRapor.DataSource = filteredData;
            }
            catch
            {
                // Hata durumunda sessizce devam et
            }
        }

        private void AracDurumRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                a.aracid,
                a.saseno,
                m.modeladi,
                ma.markaadi,
                a.uretimdurumu,
                a.uretimbaslangic,
                a.uretimbitis
            FROM arac a
            JOIN model m ON m.modelid = a.modelid
            JOIN marka ma ON ma.markaid = m.markaid
            ORDER BY a.aracid";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} araç bulundu.");
        }

        private void ParcaStokRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT 
                        pk.kategoriadi AS ""Kategori"",
                        p.parcaadi AS ""Parça"",
                        p.stok AS ""Stok"",
                        p.fiyat AS ""Birim Fiyat"",
                        (p.stok * p.fiyat) as ""Toplam Değer"",
                        CASE 
                            WHEN p.stok = 0 THEN 'TÜKENDİ'
                            WHEN p.stok < 10 THEN 'DÜŞÜK'
                            WHEN p.stok < 50 THEN 'NORMAL'
                            ELSE 'BOL'
                        END as ""Stok Durumu""
                    FROM parca p
                    JOIN parcakategori pk ON pk.kategoriid = p.kategoriid
                    ORDER BY p.stok ASC, pk.kategoriadi";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} parça bulundu.");
        }

        private void UretimSureciRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT 
                        us.surecid,
                        a.saseno AS ""Şase No"",
                        m.modeladi AS ""Model"",
                        (c.ad || ' ' || c.soyad) AS ""Çalışan"",
                        us.aciklama AS ""Açıklama"",
                        us.tarih AS ""Tarih"",
                        (CURRENT_DATE - us.tarih) AS ""Kaç Gün Önce""
                    FROM uretimsureci us
                    JOIN arac a ON a.aracid = us.aracid
                    JOIN model m ON m.modelid = a.modelid
                    JOIN calisan c ON c.calisanid = us.calisanid
                    ORDER BY us.tarih DESC";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} üretim kaydı bulundu.");
        }

        private void TestSonuclariRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT 
                        tk.testid,
                        a.saseno as ""Şase No"",
                        m.modeladi as ""Model"",
                        (mu.ad || ' ' || mu.soyad) as ""Mühendis"",
                        tk.testsonucu as ""Sonuç"",
                        tk.testtarihi as ""Test Tarihi"",
                        CASE 
                            WHEN tk.testsonucu = 'Basarili' THEN '✓ BAŞARILI'
                            ELSE '✗ BAŞARISIZ'
                        END as ""Durum""
                    FROM testkaydi tk
                    JOIN arac a ON a.aracid = tk.aracid
                    JOIN model m ON m.modelid = a.modelid
                    JOIN muhendis mu ON mu.calisanid = tk.calisanid
                    ORDER BY tk.testtarihi DESC";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            // Başarı oranı hesapla
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string countSql = @"
                    SELECT 
                        COUNT(*) as toplam,
                        SUM(CASE WHEN testsonucu = 'Basarili' THEN 1 ELSE 0 END) as basarili
                    FROM testkaydi";

                using (var cmd = new NpgsqlCommand(countSql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int toplam = reader.GetInt32(0);
                        int basarili = reader.GetInt32(1);
                        double oran = toplam > 0 ? (basarili * 100.0 / toplam) : 0;
                        MessageBox.Show($"Toplam {toplam} test yapıldı.\n" +
                                      $"Başarılı: {basarili}\n" +
                                      $"Başarısız: {toplam - basarili}\n" +
                                      $"Başarı Oranı: %{oran:F2}");
                    }
                }
            }
        }

        private void TeslimatRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
            SELECT 
                t.teslimatid,
                a.saseno as ""Şase No"",
                m.modeladi as ""Model"",
                ma.markaadi as ""Marka"",
                (mu.ad || ' ' || mu.soyad) as ""Müşteri"",
                mu.telefon as ""Telefon"",
                t.teslimtarihi as ""Teslim Tarihi"",
                (CURRENT_DATE - t.teslimtarihi) as ""Kaç Gün Önce""
            FROM teslimat t
            JOIN arac a ON a.aracid = t.aracid
            JOIN model m ON m.modelid = a.modelid
            JOIN marka ma ON ma.markaid = m.markaid
            JOIN musteri mu ON mu.musteriid = t.musteriid
            ORDER BY t.teslimtarihi DESC";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} araç teslim edildi.");
        }

        private void MusteriRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
                    SELECT 
                        m.musteriid,
                        m.ad as ""Ad"",
                        m.soyad as ""Soyad"",
                        m.telefon as ""Telefon"",
                        m.email as ""Email"",
                        COUNT(t.teslimatid) as ""Aldığı Araç Sayısı"",
                        MAX(t.teslimtarihi) as ""Son Alış Tarihi""
                    FROM musteri m
                    LEFT JOIN teslimat t ON t.musteriid = m.musteriid
                    GROUP BY m.musteriid, m.ad, m.soyad, m.telefon, m.email
                    ORDER BY COUNT(t.teslimatid) DESC";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} müşteri bulundu.");
        }

        private void CalisanRaporu()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();
                string sql = @"
SELECT 
    'Genel' as ""Tip"",
    c.calisanid,
    (c.ad || ' ' || c.soyad) as ""Ad Soyad"",
    c.pozisyon as ""Pozisyon"",
    d.departmanadi as ""Departman"",
    '' as ""Özellik""
FROM calisan c
JOIN departman d ON d.departmanid = c.departmanid
WHERE c.calisanid NOT IN (SELECT calisanid FROM uretimpersoneli)
  AND c.calisanid NOT IN (SELECT calisanid FROM muhendis)

UNION ALL

SELECT 
    'Üretim Personeli' as ""Tip"",
    up.calisanid,
    (up.ad || ' ' || up.soyad) as ""Ad Soyad"",
    up.pozisyon as ""Pozisyon"",
    d.departmanadi as ""Departman"",
    'Uzmanlık: ' || up.uzmanlikAlani as ""Özellik""
FROM uretimpersoneli up
JOIN departman d ON d.departmanid = up.departmanid

UNION ALL

SELECT 
    'Mühendis' as ""Tip"",
    m.calisanid,
    (m.ad || ' ' || m.soyad) as ""Ad Soyad"",
    m.pozisyon as ""Pozisyon"",
    d.departmanadi as ""Departman"",
    'Yetki: ' || CAST(m.yetkiseviyesi AS TEXT) as ""Özellik""
FROM muhendis m
JOIN departman d ON d.departmanid = m.departmanid

ORDER BY calisanid";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    originalData = new DataTable();
                    da.Fill(originalData);
                    dgvRapor.DataSource = originalData;
                }
            }

            MessageBox.Show($"Toplam {dgvRapor.Rows.Count} çalışan bulundu.");
        }

        private void btnPDFAktar_Click(object sender, EventArgs e)
        {
            if (dgvRapor.Rows.Count == 0)
            {
                MessageBox.Show("Önce bir rapor getirin!");
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Dosyası (*.csv)|*.csv";
                saveFileDialog.FileName = $"Rapor_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder sb = new StringBuilder();

                    // Başlıklar
                    for (int i = 0; i < dgvRapor.Columns.Count; i++)
                    {
                        sb.Append(dgvRapor.Columns[i].HeaderText);
                        if (i < dgvRapor.Columns.Count - 1)
                            sb.Append(",");
                    }
                    sb.AppendLine();

                    // Veriler
                    foreach (DataGridViewRow row in dgvRapor.Rows)
                    {
                        if (row.IsNewRow) continue;

                        for (int i = 0; i < dgvRapor.Columns.Count; i++)
                        {
                            sb.Append(row.Cells[i].Value?.ToString() ?? "");
                            if (i < dgvRapor.Columns.Count - 1)
                                sb.Append(",");
                        }
                        sb.AppendLine();
                    }

                    System.IO.File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show($"Rapor başarıyla dışa aktarıldı!\n{saveFileDialog.FileName}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
    }
}
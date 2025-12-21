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
    public partial class FormTestYonetimi : Form
    {
        public FormTestYonetimi()
        {
            InitializeComponent();
        }

        private void FormTestYonetimi_Load(object sender, EventArgs e)
        {
            AracComboDoldur();
            MuhendisComboDoldur();
            TestSonucuComboDoldur();
            dtpTestTarihi.Value = DateTime.Now;
        }

        private void AracComboDoldur()
        {
            try
            {
                cmbArac.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // SADECE arac tablosundaki araçları getir
                    string sql = @"
                SELECT a.aracid, a.saseno, m.modeladi
                FROM arac a
                JOIN model m ON m.modelid = a.modelid
                WHERE a.uretimdurumu IN ('Test')
                ORDER BY aracid DESC";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbArac.Items.Add(new AracItem
                            {
                                AracID = reader.GetInt32(0),
                                SaseNo = reader.GetString(1),
                                ModelAdi = reader.GetString(2)
                            });
                        }
                    }
                }

                cmbArac.DisplayMember = "Display";
                cmbArac.ValueMember = "AracID";

                if (cmbArac.Items.Count > 0)
                    cmbArac.SelectedIndex = 0;
                else
                    MessageBox.Show("Uyarı: Test edilecek araç yok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç yüklenirken hata: " + ex.Message);
            }
        }
        private void MuhendisComboDoldur()
        {
            try
            {
                cmbMuhendis.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // SADECE Mühendisleri getir
                    string sql = @"
                        SELECT m.calisanid, m.ad, m.soyad, m.pozisyon, m.yetkiseviyesi
                        FROM muhendis m
                        ORDER BY m.ad, m.soyad";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMuhendis.Items.Add(new MuhendisItem
                            {
                                CalisanID = reader.GetInt32(0),
                                Ad = reader.GetString(1),
                                Soyad = reader.GetString(2),
                                Pozisyon = reader.GetString(3),
                                YetkiSeviyesi = reader.GetInt32(4)
                            });
                        }
                    }
                }

                cmbMuhendis.DisplayMember = "Display";
                cmbMuhendis.ValueMember = "CalisanID";

                if (cmbMuhendis.Items.Count > 0)
                    cmbMuhendis.SelectedIndex = 0;
                else
                    MessageBox.Show("Uyarı: Hiç mühendis yok! Önce mühendis ekleyin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mühendis yüklenirken hata: " + ex.Message);
            }
        }

        private void TestSonucuComboDoldur()
        {
            cmbTestSonucu.Items.Clear();
            cmbTestSonucu.Items.Add("Basarili");
            cmbTestSonucu.Items.Add("Basarisiz");
            cmbTestSonucu.SelectedIndex = 0;
        }

        // ================================================
        // TEST İŞLEMLERİ
        // ================================================

        private void TestListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    tk.testid,
                    a.saseno,
                    m.modeladi,
                    (mu.ad || ' ' || mu.soyad) as muhendis,
                    tk.testsonucu,
                    tk.testtarihi
                FROM testkaydi tk
                JOIN arac a ON a.aracid = tk.aracid
                JOIN model m ON m.modelid = a.modelid
                JOIN muhendis mu ON mu.calisanid = tk.calisanid
                ORDER BY tk.testtarihi DESC, tk.testid DESC";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTest.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
       
        private void btnTestKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyonlar
                if (cmbArac.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir araç seçin!");
                    return;
                }

                if (cmbMuhendis.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir mühendis seçin!");
                    return;
                }

                if (cmbTestSonucu.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen test sonucunu seçin!");
                    return;
                }

                AracItem secilenArac = (AracItem)cmbArac.SelectedItem;
                MuhendisItem secilenMuhendis = (MuhendisItem)cmbMuhendis.SelectedItem;
                string testSonucu = cmbTestSonucu.SelectedItem.ToString();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // ÖNEMLİ: Önce araç kontrolü yap
                    string sqlAracKontrol = "SELECT COUNT(*) FROM arac WHERE aracid = @aracid";
                    using (var cmdKontrol = new NpgsqlCommand(sqlAracKontrol, conn))
                    {
                        cmdKontrol.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        int aracSayisi = Convert.ToInt32(cmdKontrol.ExecuteScalar());

                        if (aracSayisi == 0)
                        {
                            MessageBox.Show($"HATA: AracID {secilenArac.AracID} 'arac' tablosunda bulunamadı!\n" +
                                           "Lütfen bu aracı 'arac' tablosuna ekleyin veya başka bir araç seçin.");
                            return;
                        }
                    }

                    // 1. Test kaydını ekle
                    string sqlTestEkle = @"
                INSERT INTO testkaydi(aracid, calisanid, testsonucu, testtarihi)
                VALUES (@aracid, @calisanid, @sonuc, @tarih)";

                    using (var cmd = new NpgsqlCommand(sqlTestEkle, conn))
                    {
                        cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        cmd.Parameters.AddWithValue("@calisanid", secilenMuhendis.CalisanID);
                        cmd.Parameters.AddWithValue("@sonuc", testSonucu);
                        cmd.Parameters.AddWithValue("@tarih", dtpTestTarihi.Value.Date);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Araç durumunu güncelle
                    string yeniDurum = (testSonucu == "Basarili") ? "Tamamlandi" : "Test";

                    // Arac tablosunda güncelle
                    string sqlAracGuncelle = "UPDATE arac SET uretimdurumu = @durum WHERE aracid = @aracid";
                    using (var cmd = new NpgsqlCommand(sqlAracGuncelle, conn))
                    {
                        cmd.Parameters.AddWithValue("@durum", yeniDurum);
                        cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        cmd.ExecuteNonQuery();
                    }

                    // Eğer araç binek araç ise
                    string sqlBinekKontrol = "SELECT COUNT(*) FROM binekarac WHERE aracid = @aracid";
                    using (var cmdKontrol = new NpgsqlCommand(sqlBinekKontrol, conn))
                    {
                        cmdKontrol.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        if (Convert.ToInt32(cmdKontrol.ExecuteScalar()) > 0)
                        {
                            string sqlBinekGuncelle = "UPDATE binekarac SET uretimdurumu = @durum WHERE aracid = @aracid";
                            using (var cmd = new NpgsqlCommand(sqlBinekGuncelle, conn))
                            {
                                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                                cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }

                    // Eğer araç ticari araç ise
                    string sqlTicariKontrol = "SELECT COUNT(*) FROM ticariarac WHERE aracid = @aracid";
                    using (var cmdKontrol = new NpgsqlCommand(sqlTicariKontrol, conn))
                    {
                        cmdKontrol.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        if (Convert.ToInt32(cmdKontrol.ExecuteScalar()) > 0)
                        {
                            string sqlTicariGuncelle = "UPDATE ticariarac SET uretimdurumu = @durum WHERE aracid = @aracid";
                            using (var cmd = new NpgsqlCommand(sqlTicariGuncelle, conn))
                            {
                                cmd.Parameters.AddWithValue("@durum", yeniDurum);
                                cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                if (testSonucu == "Basarili")
                {
                    MessageBox.Show("Test başarılı! Araç durumu 'Tamamlandi' olarak güncellendi.");
                }
                else
                {
                    MessageBox.Show("Test başarısız! Araç durumu 'Test' olarak güncellendi.");
                }

                dtpTestTarihi.Value = DateTime.Now;
                TestListele();
                AracComboDoldur(); // Araç listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}\n\nDetay: {ex.InnerException?.Message}");
            }
        }

        private void btnTestSil_Click(object sender, EventArgs e)
        {
            if (dgvTest.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir test kaydı seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvTest.SelectedRows[0].Cells["testid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM testkaydi WHERE testid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Test kaydı silindi!");
                TestListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTestListele_Click(object sender, EventArgs e)
        {
            TestListele();
        }

        private void dgvTest_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                // Test sonucunu göster
                var sonuc = dgvTest.Rows[e.RowIndex].Cells["testsonucu"].Value;
                if (sonuc != null)
                {
                    string sonucStr = sonuc.ToString();
                    for (int i = 0; i < cmbTestSonucu.Items.Count; i++)
                    {
                        if (cmbTestSonucu.Items[i].ToString() == sonucStr)
                        {
                            cmbTestSonucu.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Tarihi göster
                var tarih = dgvTest.Rows[e.RowIndex].Cells["testtarihi"].Value;
                if (tarih != DBNull.Value)
                {
                    dtpTestTarihi.Value = Convert.ToDateTime(tarih);
                }
            }
        }
    }
   
}

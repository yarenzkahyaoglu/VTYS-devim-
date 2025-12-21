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
    public partial class FormUretimSureci : Form
    {
        public FormUretimSureci()
        {
            InitializeComponent();
        }

        private void FormUretimSureci_Load(object sender, EventArgs e)
        {
            AracComboDoldur();
            CalisanComboDoldur();
            UretimSureciListele();

            // DateTimePicker bugünün tarihini göstersin
            dtpTarih.Value = DateTime.Now;
        }

        private void AracComboDoldur()
        {
            try
            {
                cmbArac.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
SELECT 
    a.aracid, 
    a.saseno, 
    m.modeladi
FROM arac a
JOIN model m ON m.modelid = a.modelid
WHERE a.uretimdurumu = 'Uretimde'
ORDER BY a.aracid DESC";


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
                    MessageBox.Show("Uyarı: 'Uretimde' durumunda araç yok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç yüklenirken hata: " + ex.Message);
            }
        }

        private void CalisanComboDoldur()
        {
            try
            {
                cmbCalisan.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // 🔴 INNER JOIN kullan - sadece HER İKİ tabloda da olanları getir
                    string sql = @"
                SELECT 
                    up.calisanid,
                    up.ad,
                    up.soyad,
                    up.pozisyon
                FROM uretimpersoneli up
                INNER JOIN calisan c ON c.calisanid = up.calisanid
                ORDER BY up.ad, up.soyad";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbCalisan.Items.Add(new CalisanItem
                            {
                                CalisanID = reader.GetInt32(0),
                                Ad = reader.GetString(1),
                                Soyad = reader.GetString(2),
                                Pozisyon = reader.GetString(3),
                                UzmanlikAlani = ""
                            });
                        }
                    }
                }

                cmbCalisan.DisplayMember = "Display";
                cmbCalisan.ValueMember = "CalisanID";

                if (cmbCalisan.Items.Count > 0)
                    cmbCalisan.SelectedIndex = 0;
                else
                    MessageBox.Show("Uyarı: Hiç üretim personeli yok!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private void UretimSureciListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT 
                            us.surecid,
                            a.saseno,
                            m.modeladi,
                            (c.ad || ' ' || c.soyad) as calisan,
                            us.aciklama,
                            us.tarih
                        FROM uretimsureci us
                        JOIN arac a ON a.aracid = us.aracid
                        JOIN model m ON m.modelid = a.modelid
                        JOIN calisan c ON c.calisanid = us.calisanid
                        ORDER BY us.tarih DESC, us.surecid DESC";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvSurec.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSurecEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbArac.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir araç seçin!");
                    return;
                }

                if (cmbCalisan.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir çalışan seçin!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtAciklama.Text))
                {
                    MessageBox.Show("Açıklama boş olamaz!");
                    return;
                }

                AracItem secilenArac = (AracItem)cmbArac.SelectedItem;
                CalisanItem secilenCalisan = (CalisanItem)cmbCalisan.SelectedItem;

                int aracId = secilenArac.AracID;
                int calisanId = secilenCalisan.CalisanID;
                string aciklama = txtAciklama.Text.Trim();
                DateTime tarih = dtpTarih.Value.Date;

                // 🔴 DEBUG
                MessageBox.Show($"Araç: {aracId}\nÇalışan: {calisanId}\nTarih: {tarih:yyyy-MM-dd}", "DEĞERLER");

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // 🔴 ÖNEMLİ: Explicit cast yap
                    string sql = @"
                INSERT INTO uretimsureci (aracid, calisanid, aciklama, tarih)
                VALUES (@aracid::integer, @calisanid::integer, @aciklama::text, @tarih::date)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.Add(new NpgsqlParameter("@aracid", NpgsqlTypes.NpgsqlDbType.Integer) { Value = aracId });
                        cmd.Parameters.Add(new NpgsqlParameter("@calisanid", NpgsqlTypes.NpgsqlDbType.Integer) { Value = calisanId });
                        cmd.Parameters.Add(new NpgsqlParameter("@aciklama", NpgsqlTypes.NpgsqlDbType.Text) { Value = aciklama });
                        cmd.Parameters.Add(new NpgsqlParameter("@tarih", NpgsqlTypes.NpgsqlDbType.Date) { Value = tarih });

                        int affected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Etkilenen satır sayısı: {affected}");
                    }
                }

                MessageBox.Show("Üretim süreci başarıyla eklendi!");
                txtAciklama.Clear();
                dtpTarih.Value = DateTime.Now;
                UretimSureciListele();
            }
            catch (NpgsqlException pgEx)
            {
                MessageBox.Show($"PostgreSQL Hatası:\n\n" +
                               $"Mesaj: {pgEx.Message}\n\n" +

                               $"Kod: {pgEx.SqlState}\n\n" +

                               "PostgreSQL Hatası");
                           
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Genel Hata:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                               "Hata");
            }
        }

        private void btnSurecSil_Click(object sender, EventArgs e)
        {
            if (dgvSurec.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir süreç kaydı seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvSurec.SelectedRows[0].Cells["surecid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM uretimsureci WHERE surecid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Üretim süreci silindi!");
                UretimSureciListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSurecListele_Click(object sender, EventArgs e)
        {
            UretimSureciListele();
        }
        private void dgvUretimSureci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Açıklamayı göster
                var aciklama = dgvSurec.Rows[e.RowIndex].Cells["aciklama"].Value;
                txtAciklama.Text = aciklama?.ToString() ?? "";

                // Tarihi göster
                var tarih = dgvSurec .Rows[e.RowIndex].Cells["tarih"].Value;
                if (tarih != DBNull.Value)
                {
                    dtpTarih.Value = Convert.ToDateTime(tarih);
                }
            }
        }
    }
   
}

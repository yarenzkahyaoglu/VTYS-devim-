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
    public partial class FormMusteriYonetimi : Form
    {
        public FormMusteriYonetimi()
        {
            InitializeComponent();
        }

        private void FormMusteriYonetimi_Load(object sender, EventArgs e)
        {
       
            TeslimatListele();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) // Müşteri
            {
                MusteriListele();
            }
            else if (tabControl1.SelectedTab == tabPage2) // Teslimat
            {
                AracComboDoldur();
                MusteriComboDoldur();
                TeslimatListele();
            }
        }

        private void MusteriListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM musteri ORDER BY musteriid";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMusteri.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAd.Text))
                {
                    MessageBox.Show("Ad boş olamaz!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSoyad.Text))
                {
                    MessageBox.Show("Soyad boş olamaz!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO musteri (ad, soyad, telefon, email)
                        VALUES (@ad, @soyad, @telefon, @email)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri başarıyla eklendi!");
                ClearMusteriForm();
                MusteriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvMusteri.SelectedRows[0].Cells["musteriid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM musteri WHERE musteriid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri silindi!");
                MusteriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteri.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir müşteri seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvMusteri.SelectedRows[0].Cells["musteriid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE musteri 
                        SET ad = @ad, soyad = @soyad, telefon = @telefon, email = @email
                        WHERE musteriid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@telefon", txtTelefon.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Müşteri güncellendi!");
                MusteriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }

        }

        private void btnMusteriListele_Click(object sender, EventArgs e)
        {
            MusteriListele();
        }
        private void dgvMusteri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgvMusteri.Rows[e.RowIndex].Cells["ad"].Value?.ToString() ?? "";
                txtSoyad.Text = dgvMusteri.Rows[e.RowIndex].Cells["soyad"].Value?.ToString() ?? "";
                txtTelefon.Text = dgvMusteri.Rows[e.RowIndex].Cells["telefon"].Value?.ToString() ?? "";
                txtEmail.Text = dgvMusteri.Rows[e.RowIndex].Cells["email"].Value?.ToString() ?? "";
            }
        }

        private void ClearMusteriForm()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
        }


        private void AracComboDoldur()
        {
            try
            {
                cmbArac.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // Sadece "Tamamlandi" durumundaki araçları getir
                    string sql = @"
                SELECT a.aracid, a.saseno, m.modeladi
                FROM arac a
                JOIN model m ON m.modelid = a.modelid
                WHERE a.uretimdurumu = 'Tamamlandi'
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
                    MessageBox.Show("Uyarı: Teslim edilecek araç yok (Tamamlandı durumunda)!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç yüklenirken hata: " + ex.Message);
            }
        }

        private void MusteriComboDoldur()
        {
            try
            {
                cmbMusteri.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT musteriid, ad, soyad, telefon FROM musteri ORDER BY ad, soyad";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMusteri.Items.Add(new MusteriItem
                            {
                                MusteriID = reader.GetInt32(0),
                                Ad = reader.GetString(1),
                                Soyad = reader.GetString(2),
                                Telefon = reader.IsDBNull(3) ? "" : reader.GetString(3)
                            });
                        }
                    }
                }

                cmbMusteri.DisplayMember = "Display";
                cmbMusteri.ValueMember = "MusteriID";

                if (cmbMusteri.Items.Count > 0)
                    cmbMusteri.SelectedIndex = 0;
                else
                    MessageBox.Show("Uyarı: Hiç müşteri yok! Önce müşteri ekleyin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri yüklenirken hata: " + ex.Message);
            }
        }

        private void TeslimatListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                SELECT 
                    t.teslimatid,
                    a.saseno,
                    m.modeladi,
                    (mu.ad || ' ' || mu.soyad) as musteri,
                    t.teslimtarihi
                FROM teslimat t
                JOIN arac a ON a.aracid = t.aracid
                JOIN model m ON m.modelid = a.modelid
                JOIN musteri mu ON mu.musteriid = t.musteriid
                ORDER BY t.teslimtarihi DESC";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvTeslimat.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTeslimEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbArac.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir araç seçin!");
                    return;
                }

                if (cmbMusteri.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir müşteri seçin!");
                    return;
                }

                AracItem secilenArac = (AracItem)cmbArac.SelectedItem;
                MusteriItem secilenMusteri = (MusteriItem)cmbMusteri.SelectedItem;

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 1. Teslimat ekle
                            string sql1 = "INSERT INTO teslimat (aracid, musteriid, teslimtarihi) VALUES (@aracid, @musteriid, @tarih)";
                            using (var cmd = new NpgsqlCommand(sql1, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                cmd.Parameters.AddWithValue("@musteriid", secilenMusteri.MusteriID);
                                cmd.Parameters.AddWithValue("@tarih", dtpTeslimTarihi.Value.Date);
                                cmd.ExecuteNonQuery();
                            }

                            // 2. Araç durumu güncelle
                            string sql2 = "UPDATE arac SET uretimdurumu = 'Teslim Edildi' WHERE aracid = @aracid";
                            using (var cmd = new NpgsqlCommand(sql2, conn, transaction))
                            {
                                cmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                MessageBox.Show("Araç başarıyla teslim edildi! Durum 'Teslim Edildi' olarak güncellendi.");
                dtpTeslimTarihi.Value = DateTime.Now;
                TeslimatListele();
                AracComboDoldur(); // Araç listesini yenile
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTeslimSil_Click(object sender, EventArgs e)
        {
            if (dgvTeslimat.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir teslimat kaydı seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvTeslimat.SelectedRows[0].Cells["teslimatid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM teslimat WHERE teslimatid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Teslimat kaydı silindi!");
                TeslimatListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTeslimListele_Click(object sender, EventArgs e)
        {
            TeslimatListele();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}

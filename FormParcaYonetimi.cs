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
    public partial class FormParcaYonetimi : Form
    {
        public FormParcaYonetimi()
        {
            InitializeComponent();
        }

        private void FormParcaYonetimi_Load(object sender, EventArgs e)
        {
            KategoriListele();
            ParcaListele();
            AracParcaListele();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1) // Kategori
            {
                KategoriListele();
            }
            else if (tabControl1.SelectedTab == tabPage2) // Parça
            {
                KategoriComboDoldur();
                ParcaListele();
            }
            else if (tabControl1.SelectedTab == tabPage3) // Araç-Parça
            {
                AracComboDoldur();
                ParcaComboDoldur();
                AracParcaListele();
            }
        }
        private void KategoriListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM parcakategori ORDER BY kategoriid";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvKategori.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
                {
                    MessageBox.Show("Kategori adı boş olamaz!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO parcakategori (kategoriadi) VALUES (@adi)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", txtKategoriAdi.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kategori başarıyla eklendi!");
                txtKategoriAdi.Clear();
                KategoriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvKategori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells["kategoriid"].Value);

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE parcakategori SET kategoriadi = @adi WHERE kategoriid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", txtKategoriAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kategori güncellendi!");
                KategoriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKategoriSil_Click(object sender, EventArgs e)
        {
            if (dgvKategori.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir kategori seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvKategori.SelectedRows[0].Cells["kategoriid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM parcakategori WHERE kategoriid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kategori silindi!");
                KategoriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnKategoriListele_Click(object sender, EventArgs e)
        {
            KategoriListele();
        }
        private void dgvKategori_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtKategoriAdi.Text = dgvKategori.Rows[e.RowIndex].Cells["kategoriadi"].Value?.ToString() ?? "";
            }
        }

        private void KategoriComboDoldur()
        {
            try
            {
                cmbKategori.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT kategoriid, kategoriadi FROM parcakategori ORDER BY kategoriadi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbKategori.Items.Add(new ParcaKategori
                            {
                                KategoriID = reader.GetInt32(0),
                                KategoriAdi = reader.GetString(1)
                            });
                        }
                    }
                }

                cmbKategori.DisplayMember = "KategoriAdi";
                cmbKategori.ValueMember = "KategoriID";

                if (cmbKategori.Items.Count > 0)
                    cmbKategori.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori yüklenirken hata: " + ex.Message);
            }
        }

        private void ParcaListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT p.parcaid, pk.kategoriadi, p.parcaadi, p.stok, p.fiyat
                        FROM parca p
                        JOIN parcakategori pk ON pk.kategoriid = p.kategoriid
                        ORDER BY p.parcaid";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvParca.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnParcaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbKategori.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir kategori seçin!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtParcaAdi.Text))
                {
                    MessageBox.Show("Parça adı boş olamaz!");
                    return;
                }

                if (numFiyat.Value <= 0)
                {
                    MessageBox.Show("Fiyat 0'dan büyük olmalıdır!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        INSERT INTO parca (kategoriid, parcaadi, stok, fiyat)
                        VALUES (@kid, @adi, @stok, @fiyat)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        ParcaKategori secilenKategori = (ParcaKategori)cmbKategori.SelectedItem;

                        cmd.Parameters.AddWithValue("@kid", secilenKategori.KategoriID);
                        cmd.Parameters.AddWithValue("@adi", txtParcaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@stok", (int)numStok.Value);
                        cmd.Parameters.AddWithValue("@fiyat", numFiyat.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Parça başarıyla eklendi!");
                ClearParcaForm();
                ParcaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnParcaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvParca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir parça seçin!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvParca.SelectedRows[0].Cells["parcaid"].Value);

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        UPDATE parca
                        SET kategoriid = @kid, parcaadi = @adi, stok = @stok, fiyat = @fiyat
                        WHERE parcaid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        ParcaKategori secilenKategori = (ParcaKategori)cmbKategori.SelectedItem;

                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@kid", secilenKategori.KategoriID);
                        cmd.Parameters.AddWithValue("@adi", txtParcaAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@stok", (int)numStok.Value);
                        cmd.Parameters.AddWithValue("@fiyat", numFiyat.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Parça güncellendi!");
                ParcaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnParcaSil_Click(object sender, EventArgs e)
        {
            if (dgvParca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir parça seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvParca.SelectedRows[0].Cells["parcaid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM parca WHERE parcaid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Parça silindi!");
                ParcaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnParcaListele_Click(object sender, EventArgs e)
        {
            ParcaListele();
        }
        private void dgvParca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtParcaAdi.Text = dgvParca.Rows[e.RowIndex].Cells["parcaadi"].Value?.ToString() ?? "";
                numStok.Value = Convert.ToDecimal(dgvParca.Rows[e.RowIndex].Cells["stok"].Value);
                numFiyat.Value = Convert.ToDecimal(dgvParca.Rows[e.RowIndex].Cells["fiyat"].Value);

                // Kategoriyi seç
                string kategoriAdi = dgvParca.Rows[e.RowIndex].Cells["kategoriadi"].Value?.ToString();
                if (!string.IsNullOrEmpty(kategoriAdi))
                {
                    for (int i = 0; i < cmbKategori.Items.Count; i++)
                    {
                        ParcaKategori k = (ParcaKategori)cmbKategori.Items[i];
                        if (k.KategoriAdi == kategoriAdi)
                        {
                            cmbKategori.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }
        private void ClearParcaForm()
        {
            txtParcaAdi.Clear();
            numStok.Value = 0;
            numFiyat.Value = 0;
            if (cmbKategori.Items.Count > 0)
                cmbKategori.SelectedIndex = 0;
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
                        SELECT a.aracid, a.saseno, m.modeladi
                        FROM arac a
                        JOIN model m ON m.modelid = a.modelid
                        ORDER BY a.aracid";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Araç yüklenirken hata: " + ex.Message);
            }
        }

        private void ParcaComboDoldur()
        {
            try
            {
                cmbParca.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT parcaid, parcaadi, stok FROM parca ORDER BY parcaadi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbParca.Items.Add(new ParcaItem
                            {
                                ParcaID = reader.GetInt32(0),
                                ParcaAdi = reader.GetString(1),
                                Stok = reader.GetInt32(2)
                            });
                        }
                    }
                }

                cmbParca.DisplayMember = "Display";
                cmbParca.ValueMember = "ParcaID";

                if (cmbParca.Items.Count > 0)
                    cmbParca.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Parça yüklenirken hata: " + ex.Message);
            }
        }

        private void AracParcaListele()
        {
            try
            {
                if (cmbArac.SelectedItem == null)
                    return;

                AracItem secilenArac = (AracItem)cmbArac.SelectedItem;

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                        SELECT ap.aracid, ap.parcaid, p.parcaadi, ap.adet, p.fiyat, 
                               (ap.adet * p.fiyat) as toplam
                        FROM aracparca ap
                        JOIN parca p ON p.parcaid = ap.parcaid
                        WHERE ap.aracid = @aracid
                        ORDER BY p.parcaadi";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        da.SelectCommand.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAracParca.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAracParcaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbArac.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir araç seçin!");
                    return;
                }

                if (cmbParca.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir parça seçin!");
                    return;
                }

                if (numAdet.Value <= 0)
                {
                    MessageBox.Show("Adet 0'dan büyük olmalıdır!");
                    return;
                }

                AracItem secilenArac = (AracItem)cmbArac.SelectedItem;
                ParcaItem secilenParca = (ParcaItem)cmbParca.SelectedItem;

                // Stok kontrolü
                if (secilenParca.Stok < numAdet.Value)
                {
                    MessageBox.Show($"Yetersiz stok! Mevcut stok: {secilenParca.Stok}");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // Aynı parça zaten ekliyse güncelle
                    string checkSql = "SELECT adet FROM aracparca WHERE aracid = @aracid AND parcaid = @parcaid";
                    using (var checkCmd = new NpgsqlCommand(checkSql, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                        checkCmd.Parameters.AddWithValue("@parcaid", secilenParca.ParcaID);

                        var result = checkCmd.ExecuteScalar();

                        if (result != null)
                        {
                            // Güncelle
                            string updateSql = @"
                                UPDATE aracparca 
                                SET adet = adet + @adet 
                                WHERE aracid = @aracid AND parcaid = @parcaid";

                            using (var updateCmd = new NpgsqlCommand(updateSql, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                updateCmd.Parameters.AddWithValue("@parcaid", secilenParca.ParcaID);
                                updateCmd.Parameters.AddWithValue("@adet", (int)numAdet.Value);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Yeni ekle
                            string insertSql = @"
                                INSERT INTO aracparca (aracid, parcaid, adet)
                                VALUES (@aracid, @parcaid, @adet)";

                            using (var insertCmd = new NpgsqlCommand(insertSql, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@aracid", secilenArac.AracID);
                                insertCmd.Parameters.AddWithValue("@parcaid", secilenParca.ParcaID);
                                insertCmd.Parameters.AddWithValue("@adet", (int)numAdet.Value);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Parça araca eklendi! (Stok otomatik düştü - Trigger)");
                numAdet.Value = 1;
                AracParcaListele();
                ParcaComboDoldur(); // Stok güncellemesi için
                ParcaListele(); // Ana listede de güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAracParcaSil_Click(object sender, EventArgs e)
        {
            if (dgvAracParca.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir parça seçin!");
                return;
            }

            try
            {
                int aracID = Convert.ToInt32(dgvAracParca.SelectedRows[0].Cells["aracid"].Value);
                int parcaID = Convert.ToInt32(dgvAracParca.SelectedRows[0].Cells["parcaid"].Value);

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM aracparca WHERE aracid = @aracid AND parcaid = @parcaid";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@aracid", aracID);
                        cmd.Parameters.AddWithValue("@parcaid", parcaID);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Parça araçtan kaldırıldı! (Stok otomatik arttı - Trigger)");
                AracParcaListele();
                ParcaComboDoldur(); // Stok güncellemesi için
                ParcaListele(); // Ana listede de güncelle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAracParcaListele_Click(object sender, EventArgs e)
        {
            AracParcaListele();
        }
        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            AracParcaListele();
        }
    }
  

}

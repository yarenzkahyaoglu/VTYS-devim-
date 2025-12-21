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
    public partial class FormCalisanYonetimi : Form
    {
        public FormCalisanYonetimi()
        {
            InitializeComponent();
        }

        private void numYetkiSeviyesi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormCalisanYonetimi_Load(object sender, EventArgs e)
        {
            DepartmanListele();
            CalisanListele();

            // RadioButton başlangıç durumu
            rbGenel.Checked = true;
        }
        // ========================
        // TAB CHANGED
        // ========================
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == Departman) // Departman
            {
                DepartmanListele();
            }
            else if (tabControl1.SelectedTab == Calisan) // Çalışan
            {
                DepartmanComboDoldur();
                CalisanListele();
            }
        }

        private void DepartmanListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT * FROM departman ORDER BY departmanid";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvDepartman.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDepartmanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDepartmanAdi.Text))
                {
                    MessageBox.Show("Departman adı boş olamaz!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO departman (departmanadi) VALUES (@adi)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", txtDepartmanAdi.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Departman başarıyla eklendi!");
                txtDepartmanAdi.Clear();
                DepartmanListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDepartmanGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvDepartman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir departman seçin!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvDepartman.SelectedRows[0].Cells["departmanid"].Value);

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "UPDATE departman SET departmanadi = @adi WHERE departmanid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", txtDepartmanAdi.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Departman güncellendi!");
                DepartmanListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDepartmanSil_Click(object sender, EventArgs e)
        {
            if (dgvDepartman.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir departman seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvDepartman.SelectedRows[0].Cells["departmanid"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM departman WHERE departmanid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Departman silindi!");
                DepartmanListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnDepartmanListele_Click(object sender, EventArgs e)
        {
            DepartmanListele();
        }
        private void dgvDepartman_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtDepartmanAdi.Text = dgvDepartman.Rows[e.RowIndex].Cells["departmanadi"].Value?.ToString() ?? "";
            }
        }



        private void DepartmanComboDoldur()
        {
            try
            {
                cmbDepartman.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT departmanid, departmanadi FROM departman ORDER BY departmanadi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbDepartman.Items.Add(new Departman
                            {
                                DepartmanID = reader.GetInt32(0),
                                DepartmanAdi = reader.GetString(1)
                            });
                        }
                    }
                }

                cmbDepartman.DisplayMember = "DepartmanAdi";
                cmbDepartman.ValueMember = "DepartmanID";

                if (cmbDepartman.Items.Count > 0)
                    cmbDepartman.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Departman yüklenirken hata: " + ex.Message);
            }
        }

        private void CalisanListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    string sql = @"
                SELECT c.calisanid, d.departmanadi, c.ad, c.soyad, c.pozisyon, 
                       'Genel' as tip, 
                       '' as ozellik
                FROM calisan c
                JOIN departman d ON d.departmanid = c.departmanid
                WHERE c.calisanid NOT IN (SELECT calisanid FROM uretimpersoneli)
                  AND c.calisanid NOT IN (SELECT calisanid FROM muhendis)
                
                UNION ALL
                
                SELECT up.calisanid, d.departmanadi, up.ad, up.soyad, up.pozisyon,
                       'Üretim Personeli' as tip, 
                       'Uzmanlık: ' || up.uzmanlikAlani as ozellik
                FROM uretimpersoneli up
                JOIN departman d ON d.departmanid = up.departmanid
                
                UNION ALL
                
                SELECT m.calisanid, d.departmanadi, m.ad, m.soyad, m.pozisyon,
                       'Mühendis' as tip, 
                       'Yetki: ' || CAST(m.yetkiseviyesi AS TEXT) as ozellik
                FROM muhendis m
                JOIN departman d ON d.departmanid = m.departmanid
                
                ORDER BY calisanid";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvCalisan.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasyonlar
                if (cmbDepartman.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir departman seçin!");
                    return;
                }

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

                if (string.IsNullOrWhiteSpace(txtPozisyon.Text))
                {
                    MessageBox.Show("Pozisyon boş olamaz!");
                    return;
                }

                if (!rbGenel.Checked && !rbUretimPersoneli.Checked && !rbMuhendis.Checked)
                {
                    MessageBox.Show("Lütfen çalışan tipini seçin!");
                    return;
                }

                // Üretim Personeli kontrolü
                if (rbUretimPersoneli.Checked && string.IsNullOrWhiteSpace(txtUzmanlikAlani.Text))
                {
                    MessageBox.Show("Uzmanlık alanı boş olamaz!");
                    return;
                }

                // Mühendis kontrolü
                if (rbMuhendis.Checked && numYetkiSeviyesi.Value <= 0)
                {
                    MessageBox.Show("Yetki seviyesi 0'dan büyük olmalıdır!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    Departman secilenDepartman = (Departman)cmbDepartman.SelectedItem;

                    // Genel Çalışan
                    if (rbGenel.Checked)
                    {
                        string sql = @"
                            INSERT INTO calisan (departmanid, ad, soyad, pozisyon)
                            VALUES (@did, @ad, @soyad, @pozisyon)";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@did", secilenDepartman.DepartmanID);
                            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("@pozisyon", txtPozisyon.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Genel çalışan başarıyla eklendi!");
                    }
                    // Üretim Personeli
                    else if (rbUretimPersoneli.Checked)
                    {
                        string sql = @"
                            INSERT INTO uretimpersoneli (departmanid, ad, soyad, pozisyon, uzmanlikAlani)
                            VALUES (@did, @ad, @soyad, @pozisyon, @uzmanlik)";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@did", secilenDepartman.DepartmanID);
                            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("@pozisyon", txtPozisyon.Text.Trim());
                            cmd.Parameters.AddWithValue("@uzmanlik", txtUzmanlikAlani.Text.Trim());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Üretim personeli başarıyla eklendi!");
                    }
                    // Mühendis
                    else if (rbMuhendis.Checked)
                    {
                        string sql = @"
                            INSERT INTO muhendis (departmanid, ad, soyad, pozisyon, yetkiseviyesi)
                            VALUES (@did, @ad, @soyad, @pozisyon, @yetki)";

                        using (var cmd = new NpgsqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@did", secilenDepartman.DepartmanID);
                            cmd.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                            cmd.Parameters.AddWithValue("@pozisyon", txtPozisyon.Text.Trim());
                            cmd.Parameters.AddWithValue("@yetki", (int)numYetkiSeviyesi.Value);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Mühendis başarıyla eklendi!");
                    }
                }

                ClearCalisanForm();
                CalisanListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCalisanSil_Click(object sender, EventArgs e)
        {
            if (dgvCalisan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir çalışan seçin!");
                return;
            }

            try
            {
                int id = Convert.ToInt32(dgvCalisan.SelectedRows[0].Cells["calisanid"].Value);
                string tip = dgvCalisan.SelectedRows[0].Cells["tip"].Value?.ToString() ?? "Genel";

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "";

                    if (tip == "Genel")
                        sql = "DELETE FROM calisan WHERE calisanid = @id";
                    else if (tip == "Üretim Personeli")
                        sql = "DELETE FROM uretimpersoneli WHERE calisanid = @id";
                    else if (tip == "Mühendis")
                        sql = "DELETE FROM muhendis WHERE calisanid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Çalışan silindi!");
                CalisanListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnCalisanListele_Click(object sender, EventArgs e)
        {
            CalisanListele();

        }

        private void dgvCalisan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtAd.Text = dgvCalisan.Rows[e.RowIndex].Cells["ad"].Value?.ToString() ?? "";
                txtSoyad.Text = dgvCalisan.Rows[e.RowIndex].Cells["soyad"].Value?.ToString() ?? "";
                txtPozisyon.Text = dgvCalisan.Rows[e.RowIndex].Cells["pozisyon"].Value?.ToString() ?? "";

                // Departman seç
                string departmanAdi = dgvCalisan.Rows[e.RowIndex].Cells["departmanadi"].Value?.ToString();
                if (!string.IsNullOrEmpty(departmanAdi))
                {
                    for (int i = 0; i < cmbDepartman.Items.Count; i++)
                    {
                        Departman d = (Departman)cmbDepartman.Items[i];
                        if (d.DepartmanAdi == departmanAdi)
                        {
                            cmbDepartman.SelectedIndex = i;
                            break;
                        }
                    }
                }

                // Tip'e göre RadioButton seç
                string tip = dgvCalisan.Rows[e.RowIndex].Cells["tip"].Value?.ToString() ?? "Genel";

                if (tip == "Genel")
                {
                    rbGenel.Checked = true;
                }
                else if (tip == "Üretim Personeli")
                {
                    rbUretimPersoneli.Checked = true;

                    // Özellik sütununu parse et: "Uzmanlık: Motor Montajı"
                    var ozellikStr = dgvCalisan.Rows[e.RowIndex].Cells["ozellik"].Value?.ToString() ?? "";
                    if (ozellikStr.StartsWith("Uzmanlık: "))
                    {
                        txtUzmanlikAlani.Text = ozellikStr.Replace("Uzmanlık: ", "");
                    }
                }
                else if (tip == "Mühendis")
                {
                    rbMuhendis.Checked = true;

                    // Özellik sütununu parse et: "Yetki: 5"
                    var ozellikStr = dgvCalisan.Rows[e.RowIndex].Cells["ozellik"].Value?.ToString() ?? "";
                    if (ozellikStr.StartsWith("Yetki: "))
                    {
                        string yetkiStr = ozellikStr.Replace("Yetki: ", "");
                        if (int.TryParse(yetkiStr, out int yetki))
                        {
                            numYetkiSeviyesi.Value = yetki;
                        }
                    }
                }
            }
        }

        private void rbGenel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenel.Checked)
            {
                gbUretimPersoneli.Enabled = false;
                gbMuhendis.Enabled = false;
            }
        }

        private void rbUretimPersoneli_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUretimPersoneli.Checked)
            {
                gbUretimPersoneli.Enabled = true;
                gbMuhendis.Enabled = false;
            }
        }

        private void rbMuhendis_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMuhendis.Checked)
            {
                gbUretimPersoneli.Enabled = false;
                gbMuhendis.Enabled = true;
            }
        }

        // ================================================
        // YARDIMCI METODLAR
        // ================================================

        private void ClearCalisanForm()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtPozisyon.Clear();
            txtUzmanlikAlani.Clear();
            numYetkiSeviyesi.Value = 1;
            rbGenel.Checked = true;

            if (cmbDepartman.Items.Count > 0)
                cmbDepartman.SelectedIndex = 0;
        }
    }
  
}

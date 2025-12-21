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

    public partial class FormAracYonetimi : Form
    {
        public FormAracYonetimi()
        {
            InitializeComponent();
        }

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            string yeniMarkaAdi = txtMarkaAdi.Text.Trim(); // Boşlukları temizle

            if (string.IsNullOrEmpty(yeniMarkaAdi))
            {
                MessageBox.Show("Marka adı boş olamaz!");
                return;
            }

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();

                    // 1. Markanın zaten var olup olmadığını kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM Marka WHERE MarkaAdi = @adi";
                    using (var checkCmd = new NpgsqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@adi", yeniMarkaAdi);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Marka zaten varsa hata mesajı göster ve işlemi durdur
                            MessageBox.Show($"Hata: '{yeniMarkaAdi}' markası zaten mevcut.", "Ekleme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // 2. Marka mevcut değilse ekleme işlemini yap
                    string insertQuery = "INSERT INTO Marka (MarkaAdi) VALUES (@adi)";
                    using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@adi", yeniMarkaAdi);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Marka başarıyla eklendi.");
                MarkaListele();
            }
            catch (Exception ex)
            {
                // PostgreSQL'den gelen benzersizlik hatasını yakalasa bile, ön kontrol bunu engellerdi.
                // Yine de genel hata yönetimi önemlidir.
                MessageBox.Show("Ekleme işlemi sırasında bir hata oluştu: " + ex.Message);
            }
        }
        private void btnMarkaSil_Click(object sender, EventArgs e)
        {
            if (dgvMarka.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir marka seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvMarka.SelectedRows[0].Cells["MarkaID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Marka WHERE MarkaID = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Marka silindi.");
                MarkaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMarka.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir marka seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvMarka.SelectedRows[0].Cells["MarkaID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string query = "UPDATE Marka SET MarkaAdi = @adi WHERE MarkaID = @id";
                    using (var cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@adi", txtMarkaAdi.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Marka güncellendi.");
                MarkaListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void MarkaListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Marka ORDER BY MarkaID";
                    using (var da = new NpgsqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMarka.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void dgvMarka_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMarka.Rows.Count)
            {
                txtMarkaAdi.Text = dgvMarka.Rows[e.RowIndex].Cells["MarkaAdi"].Value?.ToString();
            }
        }

        private void ModelListele()
        {
            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"
                SELECT m.ModelID, m.MarkaID, ma.MarkaAdi, m.ModelAdi, m.UretimYili
                FROM Model m
                JOIN Marka ma ON ma.MarkaID = m.MarkaID
                ORDER BY m.ModelID";

                    using (var da = new NpgsqlDataAdapter(sql, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvModel.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbMarka.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir marka seçin!");
                    return;
                }

                if (string.IsNullOrEmpty(txtModelAdi.Text))
                {
                    MessageBox.Show("Model adı boş olamaz!");
                    return;
                }

                if (string.IsNullOrEmpty(txtUretimYili.Text))
                {
                    MessageBox.Show("Üretim yılı boş olamaz!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "INSERT INTO Model (MarkaID, ModelAdi, UretimYili) VALUES (@mid, @adi, @yil)";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Marka objesini al
                        Marka secilenMarka = (Marka)cmbMarka.SelectedItem;

                        cmd.Parameters.AddWithValue("@mid", secilenMarka.MarkaID);
                        cmd.Parameters.AddWithValue("@adi", txtModelAdi.Text);
                        cmd.Parameters.AddWithValue("@yil", Convert.ToInt32(txtUretimYili.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Model başarıyla eklendi.");
                ModelListele();

                // Formu temizle
                txtModelAdi.Clear();
                txtUretimYili.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnModelSil_Click(object sender, EventArgs e)
        {
            if (dgvModel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir model seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvModel.SelectedRows[0].Cells["ModelID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "DELETE FROM Model WHERE ModelID = @id";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Model silindi.");
                ModelListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnModelGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvModel.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir model seçin.");
                return;
            }

            if (cmbMarka.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir marka seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvModel.SelectedRows[0].Cells["ModelID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = @"UPDATE Model 
                   SET MarkaID = @mid, ModelAdi = @adi, UretimYili = @yil 
                   WHERE ModelID = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        // Marka objesini al
                        Marka secilenMarka = (Marka)cmbMarka.SelectedItem;
                        cmd.Parameters.AddWithValue("@mid", secilenMarka.MarkaID);

                        cmd.Parameters.AddWithValue("@adi", txtModelAdi.Text);
                        cmd.Parameters.AddWithValue("@yil", Convert.ToInt32(txtUretimYili.Text));
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Model güncellendi.");
                ModelListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void dgvModel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // TextBox'lar
            txtModelAdi.Text = dgvModel.Rows[e.RowIndex].Cells["ModelAdi"].Value?.ToString();
            txtUretimYili.Text = dgvModel.Rows[e.RowIndex].Cells["UretimYili"].Value?.ToString();

            // MarkaAdi'yi al (MarkaID değil!)
            string markaAdi = dgvModel.Rows[e.RowIndex].Cells["MarkaAdi"].Value?.ToString();

            // ComboBox'ta bu markayı bul ve seç
            if (!string.IsNullOrEmpty(markaAdi))
            {
                for (int i = 0; i < cmbMarka.Items.Count; i++)
                {
                    Marka m = (Marka)cmbMarka.Items[i];
                    if (m.MarkaAdi == markaAdi)
                    {
                        cmbMarka.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnMarkaListele_Click(object sender, EventArgs e)
        {
            MarkaListele();
        }
        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer bir öğe seçiliyse işlem yap
            if (cmbMarka.SelectedValue != null && cmbMarka.SelectedValue.ToString() != "")
            {
                // Seçili marka ID'sini alabilirsiniz
                int selectedMarkaId = Convert.ToInt32(cmbMarka.SelectedValue);
            }
        }

        private void MarkaComboDoldur()
        {
            try
            {
                cmbMarka.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT MarkaID, MarkaAdi FROM Marka ORDER BY MarkaAdi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbMarka.Items.Add(new Marka
                            {
                                MarkaID = reader.GetInt32(0),
                                MarkaAdi = reader.GetString(1)
                            });
                        }
                    }
                }

                cmbMarka.DisplayMember = "MarkaAdi";
                cmbMarka.ValueMember = "MarkaID";

                if (cmbMarka.Items.Count > 0)
                {
                    cmbMarka.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Marka yüklenirken hata: " + ex.Message);
            }
        }
        private void FormAracYonetimi_Load(object sender, EventArgs e)
        {
            numKapasite.Minimum = 1;
            numKapasite.Maximum = 50;
            numKapasite.Value = 4;

            numYukKapasitesi.Minimum = 0;
            numYukKapasitesi.Maximum = 50000;
            numYukKapasitesi.Value = 1000;
            MarkaListele();
            ModelListele();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl1.SelectedTab == tabPage1)
            {
                MarkaListele();
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                MarkaComboDoldur();
                ModelListele();
                // MessageBox.Show satırını SİL!
            }
            else if (tabControl1.SelectedTab == tabPage3)
            {
                ModelComboDoldur();
                AracListele();
            }
        }

        private void ModelComboDoldur()
        {
            try
            {
                cmbModel.Items.Clear();

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    string sql = "SELECT ModelID, ModelAdi FROM Model ORDER BY ModelAdi";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbModel.Items.Add(new Model
                            {
                                ModelID = reader.GetInt32(0),
                                ModelAdi = reader.GetString(1)
                            });
                        }
                    }
                }

                cmbModel.DisplayMember = "ModelAdi";
                cmbModel.ValueMember = "ModelID";

                if (cmbModel.Items.Count > 0)
                {
                    cmbModel.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Model listesi yüklenirken hata: " + ex.Message);
            }
        }
        private void AracListele()
        {
            using (var conn = Db.GetConnection())
            {
                conn.Open();

                string sql = @"
SELECT 
    aracid,
    saseno,
    modeladi,
    uretimdurumu,
    uretimbaslangic,
    uretimbitis,
    aractipi,
    kapasite,
    yukkapasitesi
FROM (
    SELECT 
        a.aracid,
        a.saseno,
        m.modeladi,
        a.uretimdurumu,
        a.uretimbaslangic,
        a.uretimbitis,
        'Genel' AS aractipi,
        NULL::int AS kapasite,
        NULL::numeric AS yukkapasitesi
    FROM arac a
    JOIN model m ON m.modelid = a.modelid

    UNION ALL

    SELECT 
        b.aracid,
        b.saseno,
        m.modeladi,
        b.uretimdurumu,
        b.uretimbaslangic,
        b.uretimbitis,
        'Binek',
        b.kapasite,
        NULL::numeric
    FROM binekarac b
    JOIN model m ON m.modelid = b.modelid

    UNION ALL

    SELECT 
        t.aracid,
        t.saseno,
        m.modeladi,
        t.uretimdurumu,
        t.uretimbaslangic,
        t.uretimbitis,
        'Ticari',
        NULL::int,
        t.yükkapasitesi
    FROM ticariarac t
    JOIN model m ON m.modelid = t.modelid
) x
ORDER BY aracid DESC;
";

                using (var da = new NpgsqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvArac.DataSource = dt;
                }
            }
        }

        private void rbGenel_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenel.Checked)
            {
                gbBinek.Enabled = false;
                gbTicari.Enabled = false;

                // 🔴 ÖNEMLİ: Değerleri temizle
                numKapasite.Value = numKapasite.Minimum;
                numYukKapasitesi.Value = numYukKapasitesi.Minimum;
            }
        }

        private void rbBinek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBinek.Checked)
            {
                gbBinek.Enabled = true;
                gbTicari.Enabled = false;

                // 🔴 Ticari alanı sıfırla
                numYukKapasitesi.Value = numYukKapasitesi.Minimum;
            }
        }

        private void rbTicari_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTicari.Checked)
            {
                gbBinek.Enabled = false;
                gbTicari.Enabled = true;

                // 🔴 Binek alanını sıfırla
                numKapasite.Value = numKapasite.Minimum;
            }
        }
        private void FormTemizle()
        {
            txtSaseNo.Clear();
            cmbDurum.SelectedIndex = -1;
            rbGenel.Checked = true;
            numKapasite.Value = 4;
            numYukKapasitesi.Value = 1000;
            dtpUretimBaslangic.Value = DateTime.Now;
            dtpUretimBitis.Value = DateTime.Now.AddMonths(1);

            if (cmbModel.Items.Count > 0)
                cmbModel.SelectedIndex = 0;
        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {

            try
            {
                // Validasyonlar
                if (cmbModel.SelectedItem == null)
                {
                    MessageBox.Show("Lütfen bir model seçin!");
                    return;
                }

                if (string.IsNullOrEmpty(txtSaseNo.Text))
                {
                    MessageBox.Show("Şase No boş olamaz!");
                    return;
                }

                if (string.IsNullOrEmpty(cmbDurum.Text))
                {
                    MessageBox.Show("Lütfen bir durum seçin!");
                    return;
                }

                if (!rbGenel.Checked && !rbBinek.Checked && !rbTicari.Checked)
                {
                    MessageBox.Show("Lütfen araç tipini seçin!");
                    return;
                }

                if (rbBinek.Checked && numKapasite.Value <= 0)
                {
                    MessageBox.Show("Kapasite 0'dan büyük olmalıdır!");
                    return;
                }

                if (rbTicari.Checked && numYukKapasitesi.Value <= 0)
                {
                    MessageBox.Show("Yük kapasitesi 0'dan büyük olmalıdır!");
                    return;
                }

                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    Model secilenModel = (Model)cmbModel.SelectedItem;

                    int yeniAracId;

                    // 1️⃣ HER ZAMAN ÖNCE ARAC TABLOSU
                    string sqlArac = @"
        INSERT INTO arac (modelid, saseno, uretimdurumu, uretimbaslangic, uretimbitis)
        VALUES (@mid, @sase, @durum, @bas, @bit)
        RETURNING aracid";

                    using (var cmd = new NpgsqlCommand(sqlArac, conn))
                    {
                        cmd.Parameters.AddWithValue("@mid", secilenModel.ModelID);
                        cmd.Parameters.AddWithValue("@sase", txtSaseNo.Text);
                        cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);
                        cmd.Parameters.AddWithValue("@bas", dtpUretimBaslangic.Value);
                        cmd.Parameters.AddWithValue("@bit", dtpUretimBitis.Value);

                        yeniAracId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // 2️⃣ ARAÇ TİPİNE GÖRE ALT TABLO
                    if (rbBinek.Checked)
                    {
                        string sqlBinek =
                            "INSERT INTO binekarac (aracid, kapasite) VALUES (@id, @kap)";

                        using (var cmd = new NpgsqlCommand(sqlBinek, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", yeniAracId);
                            cmd.Parameters.AddWithValue("@kap", numKapasite.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else if (rbTicari.Checked)
                    {
                        string sqlTicari =
                            "INSERT INTO ticariarac (aracid, yükkapasitesi) VALUES (@id, @yuk)";

                        using (var cmd = new NpgsqlCommand(sqlTicari, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", yeniAracId);
                            cmd.Parameters.AddWithValue("@yuk", numYukKapasitesi.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show($"Araç başarıyla eklendi! Araç ID: {yeniAracId}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void btnAracSil_Click(object sender, EventArgs e)
        {
            if (dgvArac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir araç seçin.");
                return;
            }

            int id = Convert.ToInt32(dgvArac.SelectedRows[0].Cells["AracID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    // TABLO ve SÜTUN isimlerini küçük harf yap
                    string sql = "DELETE FROM arac WHERE aracid = @id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç silindi.");
                AracListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnAracGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvArac.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir araç seçin.");
                return;
            }

            if (cmbModel.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir model seçin!");
                return;
            }

            int id = Convert.ToInt32(dgvArac.SelectedRows[0].Cells["AracID"].Value);

            try
            {
                using (var conn = Db.GetConnection())
                {
                    conn.Open();
                    // TABLO ve SÜTUN isimlerini küçük harf yap
                    string sql = @"
                UPDATE arac
                SET modelid=@mid, saseno=@sase, uretimdurumu=@durum,
                    uretimbaslangic=@bas, uretimbitis=@bit
                WHERE aracid=@id";

                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        Model secilenModel = (Model)cmbModel.SelectedItem;
                        cmd.Parameters.AddWithValue("@mid", secilenModel.ModelID);

                        cmd.Parameters.AddWithValue("@sase", txtSaseNo.Text);
                        cmd.Parameters.AddWithValue("@durum", cmbDurum.Text);  // Parametre adı değişti
                        cmd.Parameters.AddWithValue("@bas", dtpUretimBaslangic.Value);
                        cmd.Parameters.AddWithValue("@bit", dtpUretimBitis.Value);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Araç güncellendi.");
                AracListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }
        private void dgvArac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtSaseNo.Text =
                dgvArac.Rows[e.RowIndex].Cells["saseno"].Value?.ToString();

            cmbDurum.Text =
                dgvArac.Rows[e.RowIndex].Cells["uretimdurumu"].Value?.ToString();

            dtpUretimBaslangic.Value =
                Convert.ToDateTime(dgvArac.Rows[e.RowIndex].Cells["uretimbaslangic"].Value);

            dtpUretimBitis.Value =
                Convert.ToDateTime(dgvArac.Rows[e.RowIndex].Cells["uretimbitis"].Value);

            // Model ComboBox
            string modelAdi =
                dgvArac.Rows[e.RowIndex].Cells["modeladi"].Value.ToString();

            for (int i = 0; i < cmbModel.Items.Count; i++)
            {
                if (((Model)cmbModel.Items[i]).ModelAdi == modelAdi)
                {
                    cmbModel.SelectedIndex = i;
                    break;
                }
            }

            // Araç tipi
            string aracTipi =
                dgvArac.Rows[e.RowIndex].Cells["aractipi"].Value.ToString();

            if (aracTipi == "Binek")
            {
                rbBinek.Checked = true;
                numKapasite.Value =
                    Convert.ToDecimal(dgvArac.Rows[e.RowIndex].Cells["kapasite"].Value);
            }
            else if (aracTipi == "Ticari")
            {
                rbTicari.Checked = true;
                numYukKapasitesi.Value =
                    Convert.ToDecimal(dgvArac.Rows[e.RowIndex].Cells["yukkapasitesi"].Value);
            }
            else
            {
                rbGenel.Checked = true;
            }
        }

        private void btnAracListele_Click(object sender, EventArgs e)
        {
            AracListele();
        }
        private void FormuTemizle()
        {
            txtSaseNo.Clear();
            cmbDurum.SelectedIndex = -1;
            rbGenel.Checked = true; // Varsayılan
            numKapasite.Value = 4;
            numYukKapasitesi.Value = 1000;
            dtpUretimBaslangic.Value = DateTime.Now;
            dtpUretimBitis.Value = DateTime.Now.AddMonths(1);

            if (cmbModel.Items.Count > 0)
                cmbModel.SelectedIndex = 0;
        }

        private void FormAracYonetimi_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }

}

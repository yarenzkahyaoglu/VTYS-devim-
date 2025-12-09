namespace B241210094_VTYS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAracYonetimi f = new FormAracYonetimi();
            f.ShowDialog();
            this.Show();
        }

        private void btnParcaYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormParcaYonetimi f = new FormParcaYonetimi();
            f.ShowDialog();
            this.Show();
        }

        private void btnCalisanYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCalisanYonetimi f = new FormCalisanYonetimi();
            f.ShowDialog();
            this.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRaporlar f = new FormRaporlar();
            f.ShowDialog();
            this.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnUretimSureci_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUretimSureci f = new FormUretimSureci();
            f.ShowDialog();
            this.Show();
        }

        private void btnTestYonetimi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTestYonetimi f = new FormTestYonetimi();
            f.ShowDialog();
            this.Show();
        }

        private void btnMusteriTeslim_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMusteriYonetimi f = new FormMusteriYonetimi();
            f.ShowDialog();
            this.Show();
        }
    }
}

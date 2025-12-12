using GajianKuy.Database;
using GajianKuy.Models;
using GajianKuy.Services;

namespace GajianKuy
{
    public partial class Form1 : Form
    {
        private readonly DeveloperService ds;
        private readonly ProyekService ps;
        private const string CONNECTION_STRING = "Host=localhost;Port=5432;Username=riyan;Passwordd=???;Database=gajiankuy-responsi";
        public Form1()
        {
            InitializeComponent();

            var db = new DatabaseManager(CONNECTION_STRING);
            ds = new DeveloperService(db);
            ps = new ProyekService(db);

            LoadProyek();
            SetupGridSelection();
            SetupDataGridView();
        }

        void LoadProyek()
        {
            var (dt, error) = ps.GetAll();
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show("Error");
                return;
            }
            cbPilihProyek.DataSource = dt;
            cbPilihProyek.DisplayMember = "nama";
            cbPilihProyek.ValueMember = "id";
        }

        private void SetupGridSelection()
        {
            dgPerforma.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgPerforma.MultiSelect = false;

            dgPerforma.CellClick += (s, e) =>
            {
                try
                {
                    if (e.RowIndex > -0 && e.RowIndex < dgPerforma.Rows.Count)){
                        var row = dgPerforma.Rows[e.RowIndex];
                        if (row.Cells["nama"].Value != null)
                        {
                            tbNama.Text = row.Cells["nama"].Value?.ToString() ?? "";
                        }
                        if (row.Cells["proyek_id"].Value != null)
                        {
                            cbPilihProyek.SelectedValue = row.Cells["proyek_id"].Value.ToString();
                        }
                        else cbPilihProyek.SelectedIndex = -1;
                        if (row.Cells["status_kontrak"].Value != null)
                        {
                            cbStatusKontrak.SelectedValue = row.Cells["status_proyek"].Value.ToString();
                        }
                        else cbStatusKontrak.SelectedIndex = -1;
                        if (row.Cells["fitur_selesai"].Value != null)
                        {
                            tbFiturSelesai.Text = row.Cells["fitur_selesai"].Value.ToString();
                        }
                        if (row.Cells["jumlah_bug"].Value != null)
                        {
                            tbJumlahBug.Text = row.Cells["jumlah_bug"].Value.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                dgPerforma.DataBindingComplete += (s, e) => SetupDataGridView();
            };
        }

        private void SetupDataGridView()
        {
            try
            {
                if (dgPerforma.Columns.Count == 0) return;
                foreach (DataGridViewColumn column in dgPerforma.Columns)
                {
                    column.ReadOnly = true;
                }
                if (dgPerforma.Columns.Contains("id")) dgPerforma.Columns["id"].Visible = false;
                if (dgPerforma.Columns.Contains("proyek_id")) dgPerforma.Columns["proyek_id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ResetForm()
        {
            tbNama.Clear();
            if (cbPilihProyek.Items.Count > 0) cbPilihProyek.SelectedIndex = -1;
            if (cbStatusKontrak.Items.Count > 0) cbStatusKontrak.SelectedIndex = -1;
            tbFiturSelesai.Clear();
            tbJumlahBug.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text.Trim();
            int proyekId = cbPilihProyek.SelectedIndex >= 0 ? (int)Convert.ToInt32(cbPilihProyek.SelectedValue) : 1;

            Developer d = new Developer
            {
                Nama = nama,
                ProyekId = proyekId
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
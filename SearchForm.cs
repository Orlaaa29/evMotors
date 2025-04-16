using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace frmSearch
{
    public partial class frmSearch : Form
    {
        private string connectionString = "Server=LAPTOP-9HB9G5PS\\SQLEXPRESS;Database=EVMotors;Trusted_Connection=True;TrustServerCertificate=True;";
        private DataTable dataTable = null;
        private bool dataChanged = false;

        public frmSearch()
        {
            InitializeComponent();
            StyleDataGrid();
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            cmbField.Items.AddRange(new string[] { "VehicleRegNo", "Make", "EngineSize", "RegisteredDate", "RentalPerDay", "Available" });
            cmbOperator.Items.AddRange(new string[] { "=", "LIKE", ">", "<" });
            LoadData();
            MessageBox.Show("Connected to Database
            DisplayRecords;
        }

        private void LoadData()
        {
            if (dataChanged == true)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT * FROM VehicleRegister";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        dataTable = new DataTable();
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DisplayRecords()
    {
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM VehicleRegister";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvResults.DataSource = dt;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to display records: {ex.Message}", "Display Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

        private void StyleDataGrid()
        {
            dgvResults.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                string field = cmbField.Text;
                string op = cmbOperator.Text;
                string value = txtValue.Text;

                if (string.IsNullOrWhiteSpace(field) || string.IsNullOrWhiteSpace(op))
                {
                    MessageBox.Show("Please select a field and operator.");
                    return;
                }

                string query = $"SELECT * FROM VehicleRegister WHERE {field} {op} @value";
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvResults.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

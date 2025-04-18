using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmSearch
{
    public partial class SearchForm : Form
    {
        public SearchForm()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eVMotorsDataSet.VehicleRegister' table. You can move, or remove it, as needed.
            this.vehicleRegisterTableAdapter.Fill(this.eVMotorsDataSet.VehicleRegister);
            if (cmbField.Items.Count > 0)
                cmbField.SelectedIndex = 0;

            if (cmbOperator.Items.Count > 0)
                cmbOperator.SelectedIndex = 0;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string field = cmbField.SelectedItem?.ToString();
            string op = cmbOperator.SelectedItem?.ToString();
            string value = txtValue.Text;

            if (string.IsNullOrWhiteSpace(field) || string.IsNullOrWhiteSpace(op) || string.IsNullOrWhiteSpace(value))
            {
                MessageBox.Show("Please fill all search criteria.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string filter;

            // Handle LIKE operator with wildcard
            if (op == "LIKE")
            {
                filter = $"{field} LIKE '%{value}%'";
            }
            else if (IsNumericField(field))
            {
                if (double.TryParse(value, out _))
                    filter = $"[{field}] {op} {value}";
                else
                {
                    MessageBox.Show("Please enter a valid numeric value.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            else if (IsDateField(field))
            {
                if (DateTime.TryParse(value, out DateTime date))
                    filter = $"[{field}] {op} #{date:MM/dd/yyyy}#";
                else
                {
                    MessageBox.Show("Please enter a valid date (e.g., 01/01/2024).", "Date Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            else
            {
                filter = $"{field} {op} '{value.Replace("'", "''")}'";
            }

            try
            {
                vehicleRegisterBindingSource.Filter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid filter expression.\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private bool IsNumericField(string field)
        {
            return field == "Year" || field == "Mileage"; // example numeric fields
        }

        private bool IsDateField(string field)
        {
            return field == "RegistrationDate" || field == "InspectionDate"; // example date fields
        }

        private void SetupDataGridView()
        {

            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvResults.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvResults.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvResults.EnableHeadersVisualStyles = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

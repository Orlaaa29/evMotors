namespace frmSearch
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.lblForm = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.vehicleRegNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRegisteredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalPerDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehicleRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eVMotorsDataSet = new frmSearch.EVMotorsDataSet();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperaror = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.vehicleRegisterTableAdapter = new frmSearch.EVMotorsDataSetTableAdapters.VehicleRegisterTableAdapter();
            this.grpForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegisterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVMotorsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.lblForm);
            this.grpForm.Controls.Add(this.btnClose);
            this.grpForm.Controls.Add(this.btnRun);
            this.grpForm.Controls.Add(this.dgvResults);
            this.grpForm.Controls.Add(this.txtValue);
            this.grpForm.Controls.Add(this.cmbOperator);
            this.grpForm.Controls.Add(this.cmbField);
            this.grpForm.Controls.Add(this.lblValue);
            this.grpForm.Controls.Add(this.lblOperaror);
            this.grpForm.Controls.Add(this.lblField);
            this.grpForm.Location = new System.Drawing.Point(-1, 1);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(801, 448);
            this.grpForm.TabIndex = 0;
            this.grpForm.TabStop = false;
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForm.Location = new System.Drawing.Point(300, 18);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(163, 29);
            this.lblForm.TabIndex = 9;
            this.lblForm.Text = "Search EVMotors";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(485, 153);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(194, 153);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 7;
            this.btnRun.Text = "Run Search";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoGenerateColumns = false;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleRegNoDataGridViewTextBoxColumn,
            this.makeDataGridViewTextBoxColumn,
            this.engineSizeDataGridViewTextBoxColumn,
            this.dateRegisteredDataGridViewTextBoxColumn,
            this.rentalPerDayDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.dgvResults.DataSource = this.vehicleRegisterBindingSource;
            this.dgvResults.Location = new System.Drawing.Point(0, 191);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(795, 251);
            this.dgvResults.TabIndex = 6;
            // 
            // vehicleRegNoDataGridViewTextBoxColumn
            // 
            this.vehicleRegNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.HeaderText = "VehicleRegNo";
            this.vehicleRegNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleRegNoDataGridViewTextBoxColumn.Name = "vehicleRegNoDataGridViewTextBoxColumn";
            this.vehicleRegNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // makeDataGridViewTextBoxColumn
            // 
            this.makeDataGridViewTextBoxColumn.DataPropertyName = "Make";
            this.makeDataGridViewTextBoxColumn.HeaderText = "Make";
            this.makeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.makeDataGridViewTextBoxColumn.Name = "makeDataGridViewTextBoxColumn";
            this.makeDataGridViewTextBoxColumn.Width = 125;
            // 
            // engineSizeDataGridViewTextBoxColumn
            // 
            this.engineSizeDataGridViewTextBoxColumn.DataPropertyName = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.HeaderText = "EngineSize";
            this.engineSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.engineSizeDataGridViewTextBoxColumn.Name = "engineSizeDataGridViewTextBoxColumn";
            this.engineSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateRegisteredDataGridViewTextBoxColumn
            // 
            this.dateRegisteredDataGridViewTextBoxColumn.DataPropertyName = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.HeaderText = "DateRegistered";
            this.dateRegisteredDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateRegisteredDataGridViewTextBoxColumn.Name = "dateRegisteredDataGridViewTextBoxColumn";
            this.dateRegisteredDataGridViewTextBoxColumn.Width = 125;
            // 
            // rentalPerDayDataGridViewTextBoxColumn
            // 
            this.rentalPerDayDataGridViewTextBoxColumn.DataPropertyName = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.HeaderText = "RentalPerDay";
            this.rentalPerDayDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentalPerDayDataGridViewTextBoxColumn.Name = "rentalPerDayDataGridViewTextBoxColumn";
            this.rentalPerDayDataGridViewTextBoxColumn.Width = 125;
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            this.availableDataGridViewCheckBoxColumn.Width = 125;
            // 
            // vehicleRegisterBindingSource
            // 
            this.vehicleRegisterBindingSource.DataMember = "VehicleRegister";
            this.vehicleRegisterBindingSource.DataSource = this.eVMotorsDataSet;
            // 
            // eVMotorsDataSet
            // 
            this.eVMotorsDataSet.DataSetName = "EVMotorsDataSet";
            this.eVMotorsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(643, 93);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(122, 22);
            this.txtValue.TabIndex = 5;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "=",
            "LIKE",
            "<",
            "<=",
            ">",
            ">="});
            this.cmbOperator.Location = new System.Drawing.Point(324, 91);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 24);
            this.cmbOperator.TabIndex = 4;
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Items.AddRange(new object[] {
            "VehicleRegNo",
            "Make",
            "EngineSize",
            "DateRegistered",
            "RentalPerDay",
            "Available"});
            this.cmbField.Location = new System.Drawing.Point(24, 91);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 24);
            this.cmbField.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(686, 62);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 16);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // lblOperaror
            // 
            this.lblOperaror.AutoSize = true;
            this.lblOperaror.Location = new System.Drawing.Point(350, 62);
            this.lblOperaror.Name = "lblOperaror";
            this.lblOperaror.Size = new System.Drawing.Size(60, 16);
            this.lblOperaror.TabIndex = 1;
            this.lblOperaror.Text = "Operator";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(53, 62);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(37, 16);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Field";
            // 
            // vehicleRegisterTableAdapter
            // 
            this.vehicleRegisterTableAdapter.ClearBeforeFill = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpForm);
            this.Name = "SearchForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpForm.ResumeLayout(false);
            this.grpForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegisterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eVMotorsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperaror;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridView dgvResults;
        private EVMotorsDataSet eVMotorsDataSet;
        private System.Windows.Forms.BindingSource vehicleRegisterBindingSource;
        private EVMotorsDataSetTableAdapters.VehicleRegisterTableAdapter vehicleRegisterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleRegNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn makeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRegisteredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalPerDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
    }
}


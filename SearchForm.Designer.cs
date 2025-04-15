namespace frmSearch
{
    partial class frmSearch
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.VehicleRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.cmbField = new System.Windows.Forms.ComboBox();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.vehicleRegisterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegisterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.dgvResults);
            this.grpSearch.Controls.Add(this.btnClose);
            this.grpSearch.Controls.Add(this.btnRun);
            this.grpSearch.Controls.Add(this.txtValue);
            this.grpSearch.Controls.Add(this.cmbOperator);
            this.grpSearch.Controls.Add(this.cmbField);
            this.grpSearch.Controls.Add(this.lblValue);
            this.grpSearch.Controls.Add(this.lblOperator);
            this.grpSearch.Controls.Add(this.lblField);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(776, 426);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehicleRegNo,
            this.Make,
            this.EngineSize,
            this.RegisteredDate,
            this.RentalPerDay,
            this.Available});
            this.dgvResults.Location = new System.Drawing.Point(6, 174);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(753, 246);
            this.dgvResults.TabIndex = 8;
            // 
            // VehicleRegNo
            // 
            this.VehicleRegNo.HeaderText = "VehicleRegNo";
            this.VehicleRegNo.MinimumWidth = 6;
            this.VehicleRegNo.Name = "VehicleRegNo";
            this.VehicleRegNo.Width = 140;
            // 
            // Make
            // 
            this.Make.HeaderText = "Make";
            this.Make.MinimumWidth = 6;
            this.Make.Name = "Make";
            this.Make.Width = 125;
            // 
            // EngineSize
            // 
            this.EngineSize.HeaderText = "EngineSize";
            this.EngineSize.MinimumWidth = 6;
            this.EngineSize.Name = "EngineSize";
            this.EngineSize.Width = 125;
            // 
            // RegisteredDate
            // 
            this.RegisteredDate.HeaderText = "RegisteredDate";
            this.RegisteredDate.MinimumWidth = 6;
            this.RegisteredDate.Name = "RegisteredDate";
            this.RegisteredDate.Width = 125;
            // 
            // RentalPerDay
            // 
            this.RentalPerDay.HeaderText = "RentalPerDay";
            this.RentalPerDay.MinimumWidth = 6;
            this.RentalPerDay.Name = "RentalPerDay";
            this.RentalPerDay.Width = 125;
            // 
            // Available
            // 
            this.Available.HeaderText = "Available";
            this.Available.MinimumWidth = 6;
            this.Available.Name = "Available";
            this.Available.Width = 125;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(428, 131);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(149, 131);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(105, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Search";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(634, 74);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 22);
            this.txtValue.TabIndex = 5;
            // 
            // cmbOperator
            // 
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(323, 74);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(121, 24);
            this.cmbOperator.TabIndex = 4;
            // 
            // cmbField
            // 
            this.cmbField.FormattingEnabled = true;
            this.cmbField.Location = new System.Drawing.Point(64, 74);
            this.cmbField.Name = "cmbField";
            this.cmbField.Size = new System.Drawing.Size(121, 24);
            this.cmbField.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(656, 36);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(42, 16);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(341, 36);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(60, 16);
            this.lblOperator.TabIndex = 1;
            this.lblOperator.Text = "Operator";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(61, 36);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(37, 16);
            this.lblField.TabIndex = 0;
            this.lblField.Text = "Field";
            // 
            // vehicleRegisterBindingSource
            // 
            this.vehicleRegisterBindingSource.DataMember = "VehicleRegister";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpSearch);
            this.Name = "frmSearch";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRegisterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.ComboBox cmbField;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Make;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.BindingSource vehicleRegisterBindingSource;
    }
}


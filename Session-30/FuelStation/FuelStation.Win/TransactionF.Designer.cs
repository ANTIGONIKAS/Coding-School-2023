namespace FuelStation.Win
{
    partial class TransactionF
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
            this.grvTransactions = new System.Windows.Forms.DataGridView();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransactions
            // 
            this.grvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colPayMethod,
            this.colTotalValue,
            this.colCustomer,
            this.colEmployee});
            this.grvTransactions.Location = new System.Drawing.Point(47, 62);
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RowTemplate.Height = 25;
            this.grvTransactions.Size = new System.Drawing.Size(572, 259);
            this.grvTransactions.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Width = 120;
            // 
            // colPayMethod
            // 
            this.colPayMethod.DataPropertyName = "PayMethod";
            this.colPayMethod.HeaderText = "PayMethod";
            this.colPayMethod.Name = "colPayMethod";
            // 
            // colTotalValue
            // 
            this.colTotalValue.DataPropertyName = "TotalValue";
            this.colTotalValue.HeaderText = "TotalValue";
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTotalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "CustomerId";
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            // 
            // colEmployee
            // 
            this.colEmployee.DataPropertyName = "EmployeeId";
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.Name = "colEmployee";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(47, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(158, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvTransactions);
            this.Name = "TransactionF";
            this.Text = "Transaction Form";
            this.Load += new System.EventHandler(this.TransactionF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvTransactions;
        private BindingSource bsTransactions;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colPayMethod;
        private DataGridViewTextBoxColumn colTotalValue;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colEmployee;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
    }
}
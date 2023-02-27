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
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPayMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lblPayMethod = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.cbPayMethod = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransactions
            // 
            this.grvTransactions.AllowUserToResizeColumns = false;
            this.grvTransactions.AllowUserToResizeRows = false;
            this.grvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colPayMethod,
            this.colTotalValue,
            this.colCustomer,
            this.colEmployee});
            this.grvTransactions.Location = new System.Drawing.Point(21, 52);
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
            this.btnSave.Location = new System.Drawing.Point(146, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 339);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(518, 339);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransactions.Location = new System.Drawing.Point(21, 18);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(116, 25);
            this.lblTransactions.TabIndex = 4;
            this.lblTransactions.Text = "Transactions";
            // 
            // lblPayMethod
            // 
            this.lblPayMethod.AutoSize = true;
            this.lblPayMethod.Location = new System.Drawing.Point(599, 161);
            this.lblPayMethod.Name = "lblPayMethod";
            this.lblPayMethod.Size = new System.Drawing.Size(68, 15);
            this.lblPayMethod.TabIndex = 5;
            this.lblPayMethod.Text = "PayMethod";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(599, 125);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(31, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(673, 122);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 23);
            this.txtDate.TabIndex = 9;
            // 
            // cbPayMethod
            // 
            this.cbPayMethod.FormattingEnabled = true;
            this.cbPayMethod.Location = new System.Drawing.Point(673, 158);
            this.cbPayMethod.Name = "cbPayMethod";
            this.cbPayMethod.Size = new System.Drawing.Size(100, 23);
            this.cbPayMethod.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 339);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbPayMethod);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPayMethod);
            this.Controls.Add(this.lblTransactions);
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
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvTransactions;
        private BindingSource bsTransactions;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private Label lblTransactions;
        private Label lblPayMethod;
        private Label lblDate;
        private TextBox txtDate;
        private ComboBox cbPayMethod;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colPayMethod;
        private DataGridViewTextBoxColumn colTotalValue;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colEmployee;
        private Button btnAdd;
    }
}
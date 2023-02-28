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
            this.btnAdd = new System.Windows.Forms.Button();
            this.bsLines = new System.Windows.Forms.BindingSource(this.components);
            this.grvLines = new System.Windows.Forms.DataGridView();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveLine = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.lblLines = new System.Windows.Forms.Label();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
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
            this.grvTransactions.Location = new System.Drawing.Point(21, 37);
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
            this.btnSave.Location = new System.Drawing.Point(122, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 316);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(518, 316);
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
            this.lblTransactions.Location = new System.Drawing.Point(21, 9);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(116, 25);
            this.lblTransactions.TabIndex = 4;
            this.lblTransactions.Text = "Transactions";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(21, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add new";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grvLines
            // 
            this.grvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colDiscountPercent,
            this.colItemPrice,
            this.colNetValue,
            this.colDiscountValue,
            this.dataGridViewTextBoxColumn1,
            this.colTransaction,
            this.colItem});
            this.grvLines.Location = new System.Drawing.Point(21, 410);
            this.grvLines.Name = "grvLines";
            this.grvLines.RowTemplate.Height = 25;
            this.grvLines.Size = new System.Drawing.Size(856, 185);
            this.grvLines.TabIndex = 13;
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.DataPropertyName = "DiscountPercent";
            this.colDiscountPercent.HeaderText = "DiscountPercent";
            this.colDiscountPercent.Name = "colDiscountPercent";
            // 
            // colItemPrice
            // 
            this.colItemPrice.DataPropertyName = "ItemPrice";
            this.colItemPrice.HeaderText = "ItemPrice";
            this.colItemPrice.Name = "colItemPrice";
            // 
            // colNetValue
            // 
            this.colNetValue.DataPropertyName = "NetValue";
            this.colNetValue.HeaderText = "NetValue";
            this.colNetValue.Name = "colNetValue";
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.DataPropertyName = "DiscountValue";
            this.colDiscountValue.HeaderText = "DiscountValue";
            this.colDiscountValue.Name = "colDiscountValue";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalValue";
            this.dataGridViewTextBoxColumn1.HeaderText = "TotalValue";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colTransaction
            // 
            this.colTransaction.DataPropertyName = "TransactionId";
            this.colTransaction.HeaderText = "Transaction";
            this.colTransaction.Name = "colTransaction";
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "ItemId";
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            // 
            // btnSaveLine
            // 
            this.btnSaveLine.Location = new System.Drawing.Point(21, 617);
            this.btnSaveLine.Name = "btnSaveLine";
            this.btnSaveLine.Size = new System.Drawing.Size(75, 23);
            this.btnSaveLine.TabIndex = 14;
            this.btnSaveLine.Text = "Save";
            this.btnSaveLine.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.Location = new System.Drawing.Point(122, 617);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteLine.TabIndex = 15;
            this.btnDeleteLine.Text = "Delete";
            this.btnDeleteLine.UseVisualStyleBackColor = true;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLines.Location = new System.Drawing.Point(21, 374);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(125, 21);
            this.lblLines.TabIndex = 16;
            this.lblLines.Text = "TransactionLines";
            // 
            // TransactionF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 660);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.btnSaveLine);
            this.Controls.Add(this.grvLines);
            this.Controls.Add(this.btnAdd);
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
            ((System.ComponentModel.ISupportInitialize)(this.bsLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
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
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colPayMethod;
        private DataGridViewTextBoxColumn colTotalValue;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colEmployee;
        private Button btnAdd;
        private BindingSource bsLines;
        private DataGridView grvLines;
        private Button btnSaveLine;
        private Button btnDeleteLine;
        private Label lblLines;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colDiscountPercent;
        private DataGridViewTextBoxColumn colItemPrice;
        private DataGridViewTextBoxColumn colNetValue;
        private DataGridViewTextBoxColumn colDiscountValue;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colTransaction;
        private DataGridViewTextBoxColumn colItem;
        private BindingSource bsItems;
    }
}
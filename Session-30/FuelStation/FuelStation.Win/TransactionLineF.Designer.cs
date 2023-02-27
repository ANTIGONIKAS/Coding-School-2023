namespace FuelStation.Win
{
    partial class TransactionLineF
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
            this.grvLines = new System.Windows.Forms.DataGridView();
            this.bsLines = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTransactionLines = new System.Windows.Forms.Label();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscountValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTransaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLines)).BeginInit();
            this.SuspendLayout();
            // 
            // grvLines
            // 
            this.grvLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colQuantity,
            this.colItemPrice,
            this.colNetValue,
            this.colDiscountValue,
            this.colTotalValue,
            this.ColTransaction,
            this.colItem});
            this.grvLines.Location = new System.Drawing.Point(27, 46);
            this.grvLines.Name = "grvLines";
            this.grvLines.RowTemplate.Height = 25;
            this.grvLines.Size = new System.Drawing.Size(761, 239);
            this.grvLines.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(27, 301);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 310);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(127, 301);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(77, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblTransactionLines
            // 
            this.lblTransactionLines.AutoSize = true;
            this.lblTransactionLines.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransactionLines.Location = new System.Drawing.Point(27, 9);
            this.lblTransactionLines.Name = "lblTransactionLines";
            this.lblTransactionLines.Size = new System.Drawing.Size(151, 25);
            this.lblTransactionLines.TabIndex = 5;
            this.lblTransactionLines.Text = "TransactionLines";
            this.lblTransactionLines.Click += new System.EventHandler(this.lblTransactionLines_Click);
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.Name = "colQuantity";
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
            // colTotalValue
            // 
            this.colTotalValue.DataPropertyName = "TotalValue";
            this.colTotalValue.HeaderText = "TotalValue";
            this.colTotalValue.Name = "colTotalValue";
            // 
            // ColTransaction
            // 
            this.ColTransaction.DataPropertyName = "TransactionId";
            this.ColTransaction.HeaderText = "Transaction";
            this.ColTransaction.Name = "ColTransaction";
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "ItemId";
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            // 
            // TransactionLineF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTransactionLines);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvLines);
            this.Name = "TransactionLineF";
            this.Text = "TransactionLine Form";
            this.Load += new System.EventHandler(this.TransactionLineF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvLines;
        private Button btnSave;
        private Button btnClose;
        private Button btnDelete;
        public BindingSource bsLines;
        private Label lblTransactionLines;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colItemPrice;
        private DataGridViewTextBoxColumn colNetValue;
        private DataGridViewTextBoxColumn colDiscountValue;
        private DataGridViewTextBoxColumn colTotalValue;
        private DataGridViewTextBoxColumn ColTransaction;
        private DataGridViewTextBoxColumn colItem;
    }
}
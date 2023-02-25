namespace FuelStation.Win
{
    partial class TransactionAndLineList
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
            this.colCustomer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPayMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadTrans = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // grvTransactions
            // 
            this.grvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colCustomer,
            this.colPayMethod,
            this.colTotalValue});
            this.grvTransactions.Location = new System.Drawing.Point(49, 48);
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RowTemplate.Height = 25;
            this.grvTransactions.Size = new System.Drawing.Size(598, 275);
            this.grvTransactions.TabIndex = 0;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.Name = "colDate";
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "CustomerId";
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            // 
            // colPayMethod
            // 
            this.colPayMethod.DataPropertyName = "PayMethod";
            this.colPayMethod.HeaderText = "PayMethod";
            this.colPayMethod.Name = "colPayMethod";
            this.colPayMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPayMethod.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTotalValue
            // 
            this.colTotalValue.DataPropertyName = "TotalValue";
            this.colTotalValue.HeaderText = "TotalValue";
            this.colTotalValue.Name = "colTotalValue";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(49, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoadTrans
            // 
            this.btnLoadTrans.Location = new System.Drawing.Point(534, 12);
            this.btnLoadTrans.Name = "btnLoadTrans";
            this.btnLoadTrans.Size = new System.Drawing.Size(113, 23);
            this.btnLoadTrans.TabIndex = 2;
            this.btnLoadTrans.Text = "Load Transactions";
            this.btnLoadTrans.UseVisualStyleBackColor = true;
            this.btnLoadTrans.Click += new System.EventHandler(this.btnLoadTrans_Click);
            // 
            // TransactionAndLineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoadTrans);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grvTransactions);
            this.Name = "TransactionAndLineList";
            this.Text = "TransactionAndLineList";
            this.Load += new System.EventHandler(this.TransactionAndLineList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvTransactions;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewComboBoxColumn colCustomer;
        private DataGridViewComboBoxColumn colPayMethod;
        private DataGridViewTextBoxColumn colTotalValue;
        private BindingSource bsTransactions;
        private Button btnLoadTrans;
    }
}
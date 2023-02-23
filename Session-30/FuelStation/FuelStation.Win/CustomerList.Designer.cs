namespace FuelStation.Win
{
    partial class CustomerList
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
            this.grvCustomers = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadCustomers = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // grvCustomers
            // 
            this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colCardNumber});
            this.grvCustomers.Location = new System.Drawing.Point(32, 48);
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.RowTemplate.Height = 25;
            this.grvCustomers.Size = new System.Drawing.Size(462, 295);
            this.grvCustomers.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 150;
            // 
            // colCardNumber
            // 
            this.colCardNumber.DataPropertyName = "CardNumber";
            this.colCardNumber.HeaderText = "CardNumber";
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.Width = 170;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(32, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoadCustomers
            // 
            this.btnLoadCustomers.Location = new System.Drawing.Point(360, 12);
            this.btnLoadCustomers.Name = "btnLoadCustomers";
            this.btnLoadCustomers.Size = new System.Drawing.Size(123, 23);
            this.btnLoadCustomers.TabIndex = 2;
            this.btnLoadCustomers.Text = "Load Customers";
            this.btnLoadCustomers.UseVisualStyleBackColor = true;
            this.btnLoadCustomers.Click += new System.EventHandler(this.btnLoadCustomers_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(32, 373);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btnAddCustomer.TabIndex = 3;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(134, 373);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(72, 23);
            this.btnDeleteCustomer.TabIndex = 4;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnLoadCustomers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grvCustomers);
            this.Name = "CustomerList";
            this.Text = "CustomerList";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvCustomers;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colCardNumber;
        private Button btnRefresh;
        private BindingSource bsCustomers;
        private Button btnLoadCustomers;
        private Button btnAddCustomer;
        private Button btnDeleteCustomer;
    }
}
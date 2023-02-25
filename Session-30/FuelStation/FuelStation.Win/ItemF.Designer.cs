namespace FuelStation.Win
{
    partial class ItemF
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
            this.grvItems = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.cbItemType = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grvItems
            // 
            this.grvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice,
            this.colCost});
            this.grvItems.Location = new System.Drawing.Point(26, 46);
            this.grvItems.Name = "grvItems";
            this.grvItems.RowTemplate.Height = 25;
            this.grvItems.Size = new System.Drawing.Size(587, 276);
            this.grvItems.TabIndex = 0;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Width = 120;
            // 
            // colDescription
            // 
            this.colDescription.DataPropertyName = "Description";
            this.colDescription.HeaderText = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Width = 150;
            // 
            // colItemType
            // 
            this.colItemType.DataPropertyName = "ItemType";
            this.colItemType.HeaderText = "ItemType";
            this.colItemType.Name = "colItemType";
            this.colItemType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colItemType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            // 
            // colCost
            // 
            this.colCost.DataPropertyName = "Cost";
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(124, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(524, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(649, 107);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 15);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(646, 147);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(649, 188);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(58, 15);
            this.lblItemType.TabIndex = 6;
            this.lblItemType.Text = "Item Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(651, 220);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(651, 257);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(748, 107);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(110, 23);
            this.txtCode.TabIndex = 9;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(748, 144);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(110, 23);
            this.txtDes.TabIndex = 10;
            // 
            // cbItemType
            // 
            this.cbItemType.FormattingEnabled = true;
            this.cbItemType.Location = new System.Drawing.Point(748, 185);
            this.cbItemType.Name = "cbItemType";
            this.cbItemType.Size = new System.Drawing.Size(110, 23);
            this.cbItemType.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(748, 220);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(110, 23);
            this.txtPrice.TabIndex = 12;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(748, 257);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(110, 23);
            this.txtCost.TabIndex = 13;
            // 
            // ItemF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.cbItemType);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvItems);
            this.Name = "ItemF";
            this.Text = "Item Form";
            this.Load += new System.EventHandler(this.ItemF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grvItems;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colDescription;
        private DataGridViewComboBoxColumn colItemType;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colCost;
        private BindingSource bsItems;
        private Button btnSave;
        private Button btnDelete;
        private Button btnClose;
        private Label lblCode;
        private Label lblDescription;
        private Label lblItemType;
        private Label lblPrice;
        private Label lblCost;
        private TextBox txtCode;
        private TextBox txtDes;
        private ComboBox cbItemType;
        private TextBox txtPrice;
        private TextBox txtCost;
    }
}
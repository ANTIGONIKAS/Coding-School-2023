namespace FuelStation.Win
{
    partial class ItemList
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoadItems = new System.Windows.Forms.Button();
            this.lblCode = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblItemType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.grvItems.Location = new System.Drawing.Point(12, 72);
            this.grvItems.Name = "grvItems";
            this.grvItems.RowTemplate.Height = 25;
            this.grvItems.Size = new System.Drawing.Size(538, 239);
            this.grvItems.TabIndex = 0;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.Name = "colCode";
            this.colCode.Width = 170;
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
            // 
            // colPrice
            // 
            this.colPrice.DataPropertyName = "Price";
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colCost
            // 
            this.colCost.DataPropertyName = "Cost";
            this.colCost.HeaderText = "Cost";
            this.colCost.Name = "colCost";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(467, 369);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 26);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(31, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoadItems
            // 
            this.btnLoadItems.Location = new System.Drawing.Point(450, 12);
            this.btnLoadItems.Name = "btnLoadItems";
            this.btnLoadItems.Size = new System.Drawing.Size(100, 27);
            this.btnLoadItems.TabIndex = 3;
            this.btnLoadItems.Text = "Load Items";
            this.btnLoadItems.UseVisualStyleBackColor = true;
            this.btnLoadItems.Click += new System.EventHandler(this.btnLoadItems_Click);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(590, 84);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(35, 15);
            this.lblCode.TabIndex = 4;
            this.lblCode.Text = "Code";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(590, 124);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(67, 15);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.Location = new System.Drawing.Point(590, 170);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(58, 15);
            this.lblItemType.TabIndex = 6;
            this.lblItemType.Text = "Item Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(590, 209);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(33, 15);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(594, 254);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 15);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(336, 371);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 491);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.btnLoadItems);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.grvItems);
            this.Name = "ItemList";
            this.Text = "ItemList";
            this.Load += new System.EventHandler(this.ItemList_Load);
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
        private Button btnOk;
        private Button btnRefresh;
        private BindingSource bsItems;
        private Button btnLoadItems;
        private Label lblCode;
        private Label lblDescription;
        private Label lblItemType;
        private Label lblPrice;
        private Label lblCost;
        private TextBox txtCode;
        private TextBox txtDes;
        private TextBox txtPrice;
        private TextBox txtCost;
        private ComboBox cbItemType;
        private Button btnAdd;
    }
}
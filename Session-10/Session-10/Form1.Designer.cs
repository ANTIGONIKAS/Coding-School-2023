namespace Session_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUndergraduate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colAge,
            this.colUndergraduate,
            this.colGender});
            this.grvStudents.Location = new System.Drawing.Point(12, 25);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(519, 248);
            this.grvStudents.TabIndex = 0;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 120;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 170;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Width = 70;
            // 
            // colUndergraduate
            // 
            this.colUndergraduate.DataPropertyName = "Undergraduate";
            this.colUndergraduate.HeaderText = "Undergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            this.colUndergraduate.Width = 50;
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colGender.Width = 80;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(456, 297);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 29);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 655);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvStudents;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewCheckBoxColumn colUndergraduate;
        private DataGridViewComboBoxColumn colGender;
        private Button btnOK;
    }
}
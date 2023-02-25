namespace FuelStation.Win
{
    partial class MainMenu
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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblFuelStation = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCn = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sidePanel.CausesValidation = false;
            this.sidePanel.Controls.Add(this.btnStaff);
            this.sidePanel.Controls.Add(this.btnCashier);
            this.sidePanel.Controls.Add(this.btnManager);
            this.sidePanel.Controls.Add(this.panelLogo);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sidePanel.ForeColor = System.Drawing.SystemColors.Control;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(194, 450);
            this.sidePanel.TabIndex = 0;
            // 
            // btnStaff
            // 
            this.btnStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStaff.Location = new System.Drawing.Point(3, 267);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(179, 62);
            this.btnStaff.TabIndex = 4;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            // 
            // btnCashier
            // 
            this.btnCashier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCashier.Location = new System.Drawing.Point(3, 191);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(179, 70);
            this.btnCashier.TabIndex = 3;
            this.btnCashier.Text = "Cashier";
            this.btnCashier.UseVisualStyleBackColor = true;
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnManager
            // 
            this.btnManager.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnManager.Location = new System.Drawing.Point(3, 121);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(179, 64);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.lblFuelStation);
            this.panelLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(194, 102);
            this.panelLogo.TabIndex = 0;
            // 
            // lblFuelStation
            // 
            this.lblFuelStation.AutoSize = true;
            this.lblFuelStation.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFuelStation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFuelStation.Location = new System.Drawing.Point(38, 47);
            this.lblFuelStation.Name = "lblFuelStation";
            this.lblFuelStation.Size = new System.Drawing.Size(117, 20);
            this.lblFuelStation.TabIndex = 0;
            this.lblFuelStation.Text = "Fuel Station";
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(253, 51);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(163, 51);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnItems
            // 
            this.btnItems.Location = new System.Drawing.Point(253, 134);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(163, 51);
            this.btnItems.TabIndex = 2;
            this.btnItems.Text = "Item";
            this.btnItems.UseVisualStyleBackColor = true;
            // 
            // btnTransaction
            // 
            this.btnTransaction.Location = new System.Drawing.Point(253, 219);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(163, 42);
            this.btnTransaction.TabIndex = 3;
            this.btnTransaction.Text = "Transaction";
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(296, 280);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(79, 15);
            this.lblCardNumber.TabIndex = 4;
            this.lblCardNumber.Text = "Card Number";
            // 
            // txtCn
            // 
            this.txtCn.Location = new System.Drawing.Point(265, 306);
            this.txtCn.Name = "txtCn";
            this.txtCn.Size = new System.Drawing.Size(139, 23);
            this.txtCn.TabIndex = 5;
            this.txtCn.TextChanged += new System.EventHandler(this.txtCn_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(276, 352);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(99, 29);
            this.btnGo.TabIndex = 6;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtCn);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.btnTransaction);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.sidePanel);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.sidePanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel sidePanel;
        private Button btnCashier;
        private Button btnManager;
        private Panel panelLogo;
        private Label lblFuelStation;
        private Button btnStaff;
        private Button btnCustomer;
        private Button btnItems;
        private Button btnTransaction;
        private Label lblCardNumber;
        private TextBox txtCn;
        private Button btnGo;
    }
}
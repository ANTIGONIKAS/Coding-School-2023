namespace Session_09
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
            this.btnZero = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.ctrlDisplay = new System.Windows.Forms.TextBox();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnSqR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(9, 296);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(54, 39);
            this.btnZero.TabIndex = 0;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(129, 296);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(54, 39);
            this.btnEqual.TabIndex = 1;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(189, 296);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(54, 39);
            this.btnAddition.TabIndex = 2;
            this.btnAddition.Tag = "";
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(9, 251);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(54, 39);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(69, 251);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(54, 39);
            this.btnTwo.TabIndex = 4;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(129, 251);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(54, 39);
            this.btnThree.TabIndex = 5;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(129, 196);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(54, 39);
            this.btnSix.TabIndex = 8;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(69, 196);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 39);
            this.btnFive.TabIndex = 7;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(9, 196);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 39);
            this.btnFour.TabIndex = 6;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(129, 140);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(54, 39);
            this.btnNine.TabIndex = 11;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(69, 140);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(54, 39);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Location = new System.Drawing.Point(9, 140);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 39);
            this.btnSeven.TabIndex = 9;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(189, 251);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(54, 39);
            this.btnMinus.TabIndex = 12;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(189, 140);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(54, 39);
            this.btnDiv.TabIndex = 14;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(189, 196);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(54, 39);
            this.btnMulti.TabIndex = 13;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // ctrlDisplay
            // 
            this.ctrlDisplay.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrlDisplay.Location = new System.Drawing.Point(9, 21);
            this.ctrlDisplay.Name = "ctrlDisplay";
            this.ctrlDisplay.Size = new System.Drawing.Size(253, 34);
            this.ctrlDisplay.TabIndex = 15;
            // 
            // btnDot
            // 
            this.btnDot.Location = new System.Drawing.Point(69, 296);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(54, 39);
            this.btnDot.TabIndex = 16;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnPower
            // 
            this.btnPower.Location = new System.Drawing.Point(189, 95);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(54, 39);
            this.btnPower.TabIndex = 19;
            this.btnPower.Text = "2X";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnSqR
            // 
            this.btnSqR.Location = new System.Drawing.Point(129, 95);
            this.btnSqR.Name = "btnSqR";
            this.btnSqR.Size = new System.Drawing.Size(54, 39);
            this.btnSqR.TabIndex = 18;
            this.btnSqR.Text = "√";
            this.btnSqR.UseVisualStyleBackColor = true;
            this.btnSqR.Click += new System.EventHandler(this.btnSqR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 351);
            this.Controls.Add(this.btnPower);
            this.Controls.Add(this.btnSqR);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.ctrlDisplay);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnZero;
        private Button btnEqual;
        private Button btnAddition;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnMinus;
        private Button btnDiv;
        private Button btnMulti;
        private TextBox ctrlDisplay;
        private Button btnDot;
        private Button btnPower;
        private Button btnSqR;
    }
}
namespace DiceRolls
{
    partial class Form1
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.rdD6 = new System.Windows.Forms.RadioButton();
            this.rdD10 = new System.Windows.Forms.RadioButton();
            this.rdD12 = new System.Windows.Forms.RadioButton();
            this.rdD20 = new System.Windows.Forms.RadioButton();
            this.rdOne = new System.Windows.Forms.RadioButton();
            this.rdTwo = new System.Windows.Forms.RadioButton();
            this.rdThree = new System.Windows.Forms.RadioButton();
            this.rdFour = new System.Windows.Forms.RadioButton();
            this.grpSides = new System.Windows.Forms.GroupBox();
            this.grpNumber = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSides.SuspendLayout();
            this.grpNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(64, 47);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(164, 44);
            this.txtResult.TabIndex = 0;
            this.txtResult.TabStop = false;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(42, 246);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(75, 23);
            this.btnRoll.TabIndex = 1;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // rdD6
            // 
            this.rdD6.AutoSize = true;
            this.rdD6.Checked = true;
            this.rdD6.Location = new System.Drawing.Point(6, 22);
            this.rdD6.Name = "rdD6";
            this.rdD6.Size = new System.Drawing.Size(39, 17);
            this.rdD6.TabIndex = 2;
            this.rdD6.TabStop = true;
            this.rdD6.Text = "D6";
            this.rdD6.UseVisualStyleBackColor = true;
            // 
            // rdD10
            // 
            this.rdD10.AutoSize = true;
            this.rdD10.Location = new System.Drawing.Point(6, 45);
            this.rdD10.Name = "rdD10";
            this.rdD10.Size = new System.Drawing.Size(45, 17);
            this.rdD10.TabIndex = 3;
            this.rdD10.Text = "D10";
            this.rdD10.UseVisualStyleBackColor = true;
            // 
            // rdD12
            // 
            this.rdD12.AutoSize = true;
            this.rdD12.Location = new System.Drawing.Point(6, 68);
            this.rdD12.Name = "rdD12";
            this.rdD12.Size = new System.Drawing.Size(45, 17);
            this.rdD12.TabIndex = 4;
            this.rdD12.Text = "D12";
            this.rdD12.UseVisualStyleBackColor = true;
            // 
            // rdD20
            // 
            this.rdD20.AutoSize = true;
            this.rdD20.Location = new System.Drawing.Point(6, 91);
            this.rdD20.Name = "rdD20";
            this.rdD20.Size = new System.Drawing.Size(45, 17);
            this.rdD20.TabIndex = 5;
            this.rdD20.Text = "D20";
            this.rdD20.UseVisualStyleBackColor = true;
            // 
            // rdOne
            // 
            this.rdOne.AutoSize = true;
            this.rdOne.Checked = true;
            this.rdOne.Location = new System.Drawing.Point(6, 23);
            this.rdOne.Name = "rdOne";
            this.rdOne.Size = new System.Drawing.Size(31, 17);
            this.rdOne.TabIndex = 6;
            this.rdOne.TabStop = true;
            this.rdOne.Text = "1";
            this.rdOne.UseVisualStyleBackColor = true;
            // 
            // rdTwo
            // 
            this.rdTwo.AutoSize = true;
            this.rdTwo.Location = new System.Drawing.Point(6, 46);
            this.rdTwo.Name = "rdTwo";
            this.rdTwo.Size = new System.Drawing.Size(31, 17);
            this.rdTwo.TabIndex = 7;
            this.rdTwo.Text = "2";
            this.rdTwo.UseVisualStyleBackColor = true;
            // 
            // rdThree
            // 
            this.rdThree.AutoSize = true;
            this.rdThree.Location = new System.Drawing.Point(6, 69);
            this.rdThree.Name = "rdThree";
            this.rdThree.Size = new System.Drawing.Size(31, 17);
            this.rdThree.TabIndex = 8;
            this.rdThree.Text = "3";
            this.rdThree.UseVisualStyleBackColor = true;
            // 
            // rdFour
            // 
            this.rdFour.AutoSize = true;
            this.rdFour.Location = new System.Drawing.Point(6, 92);
            this.rdFour.Name = "rdFour";
            this.rdFour.Size = new System.Drawing.Size(31, 17);
            this.rdFour.TabIndex = 9;
            this.rdFour.Text = "4";
            this.rdFour.UseVisualStyleBackColor = true;
            // 
            // grpSides
            // 
            this.grpSides.Controls.Add(this.rdD20);
            this.grpSides.Controls.Add(this.rdD12);
            this.grpSides.Controls.Add(this.rdD10);
            this.grpSides.Controls.Add(this.rdD6);
            this.grpSides.Location = new System.Drawing.Point(27, 126);
            this.grpSides.Name = "grpSides";
            this.grpSides.Size = new System.Drawing.Size(107, 114);
            this.grpSides.TabIndex = 10;
            this.grpSides.TabStop = false;
            this.grpSides.Text = "How Many Sides?";
            // 
            // grpNumber
            // 
            this.grpNumber.Controls.Add(this.rdFour);
            this.grpNumber.Controls.Add(this.rdThree);
            this.grpNumber.Controls.Add(this.rdOne);
            this.grpNumber.Controls.Add(this.rdTwo);
            this.grpNumber.Location = new System.Drawing.Point(173, 125);
            this.grpNumber.Name = "grpNumber";
            this.grpNumber.Size = new System.Drawing.Size(105, 115);
            this.grpNumber.TabIndex = 11;
            this.grpNumber.TabStop = false;
            this.grpNumber.Text = "How Many Die?";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(188, 246);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(314, 296);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpNumber);
            this.Controls.Add(this.grpSides);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.txtResult);
            this.Name = "Form1";
            this.Text = "Dice Roller";
            this.grpSides.ResumeLayout(false);
            this.grpSides.PerformLayout();
            this.grpNumber.ResumeLayout(false);
            this.grpNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.RadioButton rdD6;
        private System.Windows.Forms.RadioButton rdD10;
        private System.Windows.Forms.RadioButton rdD12;
        private System.Windows.Forms.RadioButton rdD20;
        private System.Windows.Forms.RadioButton rdOne;
        private System.Windows.Forms.RadioButton rdTwo;
        private System.Windows.Forms.RadioButton rdThree;
        private System.Windows.Forms.RadioButton rdFour;
        private System.Windows.Forms.GroupBox grpSides;
        private System.Windows.Forms.GroupBox grpNumber;
        private System.Windows.Forms.Button btnExit;
    }
}


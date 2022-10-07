namespace calculator2ndTime
{
    partial class Calculator
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
            this.lblCalcul = new System.Windows.Forms.Label();
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoMinus = new System.Windows.Forms.RadioButton();
            this.rdoMultip = new System.Windows.Forms.RadioButton();
            this.rdoDiv = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalcul
            // 
            this.lblCalcul.AutoSize = true;
            this.lblCalcul.Font = new System.Drawing.Font("Showcard Gothic", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalcul.Location = new System.Drawing.Point(146, 46);
            this.lblCalcul.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCalcul.Name = "lblCalcul";
            this.lblCalcul.Size = new System.Drawing.Size(230, 43);
            this.lblCalcul.TabIndex = 0;
            this.lblCalcul.Text = "Calculator";
            this.lblCalcul.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum1.Location = new System.Drawing.Point(31, 186);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(139, 28);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Enter Num1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Showcard Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNum2.Location = new System.Drawing.Point(31, 284);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(140, 28);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "ENTER NUM2";
            this.lblNum2.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(203, 191);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(125, 32);
            this.txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(203, 283);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(125, 32);
            this.txtNum2.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(181, 381);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 45);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Checked = true;
            this.rdoAdd.Location = new System.Drawing.Point(411, 182);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(43, 29);
            this.rdoAdd.TabIndex = 8;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "+";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoMinus
            // 
            this.rdoMinus.AutoSize = true;
            this.rdoMinus.Location = new System.Drawing.Point(411, 224);
            this.rdoMinus.Name = "rdoMinus";
            this.rdoMinus.Size = new System.Drawing.Size(38, 29);
            this.rdoMinus.TabIndex = 9;
            this.rdoMinus.Text = "-";
            this.rdoMinus.UseVisualStyleBackColor = true;
            // 
            // rdoMultip
            // 
            this.rdoMultip.AutoSize = true;
            this.rdoMultip.Location = new System.Drawing.Point(411, 266);
            this.rdoMultip.Name = "rdoMultip";
            this.rdoMultip.Size = new System.Drawing.Size(38, 29);
            this.rdoMultip.TabIndex = 10;
            this.rdoMultip.Text = "*";
            this.rdoMultip.UseVisualStyleBackColor = true;
            // 
            // rdoDiv
            // 
            this.rdoDiv.AutoSize = true;
            this.rdoDiv.Location = new System.Drawing.Point(412, 308);
            this.rdoDiv.Name = "rdoDiv";
            this.rdoDiv.Size = new System.Drawing.Size(37, 29);
            this.rdoDiv.TabIndex = 11;
            this.rdoDiv.Text = "/";
            this.rdoDiv.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Choose the operation:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.Color.Yellow;
            this.lblDisplay.Location = new System.Drawing.Point(146, 462);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(212, 51);
            this.lblDisplay.TabIndex = 13;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(550, 563);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoDiv);
            this.Controls.Add(this.rdoMultip);
            this.Controls.Add(this.rdoMinus);
            this.Controls.Add(this.rdoAdd);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblCalcul);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalcul;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoMinus;
        private System.Windows.Forms.RadioButton rdoMultip;
        private System.Windows.Forms.RadioButton rdoDiv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
    }
}


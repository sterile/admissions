namespace admissions
{
    partial class AdmissionsCalculator
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
            this.gpaLabel = new System.Windows.Forms.Label();
            this.testScoreLabel = new System.Windows.Forms.Label();
            this.gpaTxtBox = new System.Windows.Forms.TextBox();
            this.testTxtBox = new System.Windows.Forms.TextBox();
            this.calcAdmButton = new System.Windows.Forms.Button();
            this.acceptedLabel = new System.Windows.Forms.Label();
            this.rejectedLabel = new System.Windows.Forms.Label();
            this.acceptedCountLabel = new System.Windows.Forms.Label();
            this.rejectedCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(82, 76);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(29, 13);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "GPA";
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.AutoSize = true;
            this.testScoreLabel.Location = new System.Drawing.Point(52, 103);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(59, 13);
            this.testScoreLabel.TabIndex = 1;
            this.testScoreLabel.Text = "Test Score";
            // 
            // gpaTxtBox
            // 
            this.gpaTxtBox.Location = new System.Drawing.Point(123, 73);
            this.gpaTxtBox.Name = "gpaTxtBox";
            this.gpaTxtBox.Size = new System.Drawing.Size(100, 20);
            this.gpaTxtBox.TabIndex = 2;
            // 
            // testTxtBox
            // 
            this.testTxtBox.Location = new System.Drawing.Point(123, 100);
            this.testTxtBox.Name = "testTxtBox";
            this.testTxtBox.Size = new System.Drawing.Size(100, 20);
            this.testTxtBox.TabIndex = 3;
            // 
            // calcAdmButton
            // 
            this.calcAdmButton.Location = new System.Drawing.Point(108, 126);
            this.calcAdmButton.Name = "calcAdmButton";
            this.calcAdmButton.Size = new System.Drawing.Size(115, 23);
            this.calcAdmButton.TabIndex = 4;
            this.calcAdmButton.Text = "Calculate Admission";
            this.calcAdmButton.UseVisualStyleBackColor = true;
            this.calcAdmButton.Click += new System.EventHandler(this.calcAdmButton_Click);
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(197, 18);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(53, 13);
            this.acceptedLabel.TabIndex = 5;
            this.acceptedLabel.Text = "Accepted";
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(197, 41);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(50, 13);
            this.rejectedLabel.TabIndex = 6;
            this.rejectedLabel.Text = "Rejected";
            // 
            // acceptedCountLabel
            // 
            this.acceptedCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedCountLabel.Location = new System.Drawing.Point(256, 18);
            this.acceptedCountLabel.Name = "acceptedCountLabel";
            this.acceptedCountLabel.Size = new System.Drawing.Size(35, 13);
            this.acceptedCountLabel.TabIndex = 7;
            // 
            // rejectedCountLabel
            // 
            this.rejectedCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedCountLabel.Location = new System.Drawing.Point(256, 40);
            this.rejectedCountLabel.Name = "rejectedCountLabel";
            this.rejectedCountLabel.Size = new System.Drawing.Size(35, 13);
            this.rejectedCountLabel.TabIndex = 8;
            // 
            // AdmissionsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 198);
            this.Controls.Add(this.rejectedCountLabel);
            this.Controls.Add(this.acceptedCountLabel);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.calcAdmButton);
            this.Controls.Add(this.testTxtBox);
            this.Controls.Add(this.gpaTxtBox);
            this.Controls.Add(this.testScoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Name = "AdmissionsCalculator";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.Label testScoreLabel;
        private System.Windows.Forms.TextBox gpaTxtBox;
        private System.Windows.Forms.TextBox testTxtBox;
        private System.Windows.Forms.Button calcAdmButton;
        private System.Windows.Forms.Label acceptedLabel;
        private System.Windows.Forms.Label rejectedLabel;
        private System.Windows.Forms.Label acceptedCountLabel;
        private System.Windows.Forms.Label rejectedCountLabel;
    }
}


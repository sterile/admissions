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
            this.gpaLabel.Location = new System.Drawing.Point(164, 146);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(56, 25);
            this.gpaLabel.TabIndex = 0;
            this.gpaLabel.Text = "GPA";
            // 
            // testScoreLabel
            // 
            this.testScoreLabel.AutoSize = true;
            this.testScoreLabel.Location = new System.Drawing.Point(104, 198);
            this.testScoreLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.testScoreLabel.Name = "testScoreLabel";
            this.testScoreLabel.Size = new System.Drawing.Size(116, 25);
            this.testScoreLabel.TabIndex = 1;
            this.testScoreLabel.Text = "Test Score";
            // 
            // gpaTxtBox
            // 
            this.gpaTxtBox.Location = new System.Drawing.Point(246, 140);
            this.gpaTxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gpaTxtBox.Name = "gpaTxtBox";
            this.gpaTxtBox.Size = new System.Drawing.Size(196, 31);
            this.gpaTxtBox.TabIndex = 2;
            // 
            // testTxtBox
            // 
            this.testTxtBox.Location = new System.Drawing.Point(246, 192);
            this.testTxtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.testTxtBox.Name = "testTxtBox";
            this.testTxtBox.Size = new System.Drawing.Size(196, 31);
            this.testTxtBox.TabIndex = 3;
            // 
            // calcAdmButton
            // 
            this.calcAdmButton.Location = new System.Drawing.Point(216, 242);
            this.calcAdmButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.calcAdmButton.Name = "calcAdmButton";
            this.calcAdmButton.Size = new System.Drawing.Size(230, 44);
            this.calcAdmButton.TabIndex = 4;
            this.calcAdmButton.Text = "Calculate Admission";
            this.calcAdmButton.UseVisualStyleBackColor = true;
            this.calcAdmButton.Click += new System.EventHandler(this.calcAdmButton_Click);
            // 
            // acceptedLabel
            // 
            this.acceptedLabel.AutoSize = true;
            this.acceptedLabel.Location = new System.Drawing.Point(394, 35);
            this.acceptedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.acceptedLabel.Name = "acceptedLabel";
            this.acceptedLabel.Size = new System.Drawing.Size(102, 25);
            this.acceptedLabel.TabIndex = 5;
            this.acceptedLabel.Text = "Accepted";
            // 
            // rejectedLabel
            // 
            this.rejectedLabel.AutoSize = true;
            this.rejectedLabel.Location = new System.Drawing.Point(394, 79);
            this.rejectedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rejectedLabel.Name = "rejectedLabel";
            this.rejectedLabel.Size = new System.Drawing.Size(97, 25);
            this.rejectedLabel.TabIndex = 6;
            this.rejectedLabel.Text = "Rejected";
            // 
            // acceptedCountLabel
            // 
            this.acceptedCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedCountLabel.Location = new System.Drawing.Point(512, 35);
            this.acceptedCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.acceptedCountLabel.Name = "acceptedCountLabel";
            this.acceptedCountLabel.Size = new System.Drawing.Size(68, 23);
            this.acceptedCountLabel.TabIndex = 7;
            // 
            // rejectedCountLabel
            // 
            this.rejectedCountLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedCountLabel.Location = new System.Drawing.Point(512, 77);
            this.rejectedCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.rejectedCountLabel.Name = "rejectedCountLabel";
            this.rejectedCountLabel.Size = new System.Drawing.Size(68, 23);
            this.rejectedCountLabel.TabIndex = 8;
            // 
            // AdmissionsCalculator
            // 
            this.AcceptButton = this.calcAdmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 381);
            this.Controls.Add(this.rejectedCountLabel);
            this.Controls.Add(this.acceptedCountLabel);
            this.Controls.Add(this.rejectedLabel);
            this.Controls.Add(this.acceptedLabel);
            this.Controls.Add(this.calcAdmButton);
            this.Controls.Add(this.testTxtBox);
            this.Controls.Add(this.gpaTxtBox);
            this.Controls.Add(this.testScoreLabel);
            this.Controls.Add(this.gpaLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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


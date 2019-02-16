/*
 * Grading ID: M5477
 * Lab: 4
 * Due Date: Feb 17 2019
 * Course Section: 01
 * Description: This program determines and keeps track of admissions.
 */

using System;
using System.Windows.Forms;

namespace admissions
{
    public partial class AdmissionsCalculator : Form
    {
        private int accepted, // Count of students accepted
            rejected;         // Count of students rejected

        public AdmissionsCalculator()
        {
            InitializeComponent();
        }

        // Performs tests when the calculate button is clicked
        private void calcAdmButton_Click(object sender, EventArgs e)
        {
            /* REQUIREMENTS:
             * GPA must be 3.0 or above AND test score must be 60 or above
             * OR
             * Test score must be 80 or above
             */

            const double MINIMUM_GPA = 3.0,  // The minimum GPA needed for lower test scores
                MINIMUM_SCORE_WITH_GPA = 60, // The minimum test score when factoring GPA
                MINIMUM_SCORE_LOW_GPA = 80;  // The minimum test score w/o factoring GPA

            bool gpaIsDouble,  // Bool ensuring the users GPA input is a double.
                scoreIsInt; // Bool ensuring the users score input is an integer.

            double gpa; // The student's GPA.
            int testScore; // The student's test score.

            // Attempts to set variables
            gpaIsDouble = double.TryParse(gpaTxtBox.Text, out gpa);
            scoreIsInt = int.TryParse(testTxtBox.Text, out testScore);

            if(gpaIsDouble && scoreIsInt)
            {
                if (gpa >= MINIMUM_GPA)
                {
                    if (testScore >= MINIMUM_SCORE_WITH_GPA)
                    {
                        // Student has met GPA and score requirements, admitted.
                        accepted++;
                        MessageBox.Show("This student has been accepted!", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Student met GPA requirements but failed admissions test.
                        rejected++;
                        MessageBox.Show("This student has been rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (testScore >= MINIMUM_SCORE_LOW_GPA)
                {
                    // Student has failed GPA but met higher score requirements, admitted.
                    accepted++;
                    MessageBox.Show("This student has been accepted!", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Student has failed both GPA and higher score requirements.
                    rejected++;
                    MessageBox.Show("This student has been rejected.", "Rejected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please check the validity of your data.", "Form Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Updates form counters
            acceptedCountLabel.Text = accepted.ToString();
            rejectedCountLabel.Text = rejected.ToString();
        }
    }
}

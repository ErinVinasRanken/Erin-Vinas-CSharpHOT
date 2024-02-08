using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HOT3_2
{
    public partial class frmTestScores : Form
    {
        const int MINSCORE = 0;
        const int MAXSCORE = 100;
        private ScoreTracker scoreTracker = new ScoreTracker();

        public frmTestScores()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string input = txtEnterScore.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                ShowErrorMessage("Please Enter A Score.", "ERROR IN INPUT");
                return;
            }

            try
            {
                double score = Convert.ToDouble(input);

                if (score < MINSCORE || score > MAXSCORE)
                {
                    ShowErrorMessage("Please Enter A Score Between 0 and 100.", "ERROR IN INPUT");
                    return;
                }

                scoreTracker.AddScore(score);
                UpdateStatistics();
            }
            catch (FormatException)
            {
                ShowErrorMessage("Please Enter A Numeric Score.", "ERROR IN INPUT");
            }
        }
        
        private void UpdateStatistics()
        {
            lblResults.Text = ($"Number Of Scores: {scoreTracker.NumberOfScores}\n" +
                              $"Sum Of Test Scores: {scoreTracker.Sum}\n" +
                              $"Average Test Score: {scoreTracker.Average}\n" +
                              $"Lowest Test Score: {scoreTracker.Min}\n" +
                              $"Highest Test Score: {scoreTracker.Max}\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEnterScore.Text = "";
            txtEnterScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
            "Do You Really Want To Exit The Program?",
            "EXIT NOW?",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        public class ScoreTracker
        {
            private List<double> scores;

            public ScoreTracker()
            {
                scores = new List<double>();
            }

            public void AddScore(double score)
            {
                scores.Add(score);
            }

            public int NumberOfScores => scores.Count;

            public double Sum => scores.Sum();

            public double Average => scores.Average();

            public double Min => scores.Min();

            public double Max => scores.Max();
        }
    }
}

using System;
using System.Windows.Forms;

namespace HOT2_1
{
    public partial class frmDistanceConverter : Form
    {
        // Declare and initialize program constants
        const int INCHES_PER_YARD = 36;
        const decimal MININCH = 0;
        const decimal MAXINCH = 1000m;
        const string DIIMNBE = "Distance In Inches Must not Be Empty";
        const string EII = "ERROR IN INPUT";
        const string DIIMBN = "Distance In Inches Must Be Numeric";
        const string DIIOOR = "Distance In Inches has Out-Of-Range Input";

        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        private void btnConverToYrads_Click(object sender, EventArgs e)
        {
            PerformConversion();
        }

        private void PerformConversion()
        {
            decimal inches;
            decimal yards;

            // If textbox left empty, return
            if (txtDistanceInInches.Text.Trim() == "")
            {
                ShowErrorMessage(DIIMNBE, EII);
                txtDistanceInInches.Focus();
                return;
            }

            // Check textbox is numeric
            bool result = decimal.TryParse(txtDistanceInInches.Text, out inches);

            if (!result)
            {
                ShowErrorMessage(DIIMBN, EII);
                txtDistanceInInches.Focus();
                return;
            }

            // Check textbox is in range
            if (inches < MININCH || inches > MAXINCH) 
            {
                ShowErrorMessage(DIIOOR, EII);
                txtDistanceInInches.Focus();
                return;
            }

            inches = Convert.ToDecimal(txtDistanceInInches.Text);
            yards = inches / INCHES_PER_YARD;

            lblResult.Text = inches.ToString("n2") + " inches " + yards.ToString("n2") + " yards.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDistanceInInches.Text = "";
            lblResult.Text = "";
            txtDistanceInInches.Focus();
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
    }
}

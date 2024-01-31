using System;
using System.Windows.Forms;

namespace HOT2_2
{
    public partial class frmLetterGrade : Form
    {
        // Declare and initialize program constants
        const decimal MINGPA = 0.0m;
        const decimal MAXGPA = 4.0m;
        const string EII = "ERROR IN INPUT";
        const string GPAMBWR = "GPA Must Be Within Range. 0.0 - 4.0";
        const string GPAMBN = "GPA Must Be Numeric";

        public frmLetterGrade()
        {
            InitializeComponent();
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            CalculateGPA();
        }

        private void CalculateGPA()
        {
            decimal gpa;

            // Check textbox is numeric
            if (!decimal.TryParse(txtGPA.Text, out gpa))
            {
                ShowErrorMessage(GPAMBN, EII);
                txtGPA.Focus();
                return;
            }

            // Range check
            if (gpa < MINGPA || gpa > MAXGPA)
            {
                ShowErrorMessage(GPAMBWR, EII);
                txtGPA.Text = "";
                txtGPA.Focus();
                return;
            }

            if (gpa > 3.0m)
            {
                lblResult.Text = "Letter Grade A";
            }
            else if (gpa > 2.0m)
            {
                lblResult.Text = "Letter Grade B";
            }
            else if (gpa > 1.0m)
            {
                lblResult.Text = "Letter Grade C";
            }
            else if (gpa > 0.0m)
            {
                lblResult.Text = "Letter Grade D";
            }
            else if (gpa <= 0.0m)
            {
                lblResult.Text = "Letter Grade F";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtGPA.Text = "";
            lblResult.Text = "";
            txtGPA.Focus();
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

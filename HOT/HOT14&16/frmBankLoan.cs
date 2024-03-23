using System;
using System.Windows.Forms;
using LoanLibrary;

namespace HOT14_16
{
    public partial class frmBankLoan : Form
    {
        private ILoan currentLoan;
        private ShortTermLoan currentShortTermLoan;
        private LongTermLoan currentLongTermLoan;

        public frmBankLoan()
        {
            InitializeComponent();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
        {
            if (!Validator.IsPresent(txtName.Text, "Loan Name") || !Validator.IsDecimal(txtAmount.Text, "Loan Amount") ||
               (!radShortTerm.Checked && !radLongTerm.Checked))
            {
                ShowErrorMessage("Please Enter Valid Loan Details.", "ERROR IN INPUT");
                return;
            }

            double loanAmount;
            if (!double.TryParse(txtAmount.Text, out loanAmount) || loanAmount < 0)
            {
                ShowErrorMessage("Please Enter A Positive Loan Amount.", "ERROR IN INPUT");
                return;
            }

            if (radShortTerm.Checked)
            {
                currentShortTermLoan = new ShortTermLoan(txtName.Text, loanAmount);
                currentLoan = (ILoan)currentShortTermLoan;
                Console.WriteLine("Short-term loan created.");
            }
            else
            {
                currentLongTermLoan = new LongTermLoan(txtName.Text, loanAmount);
                currentLoan = (ILoan)currentLongTermLoan;
                Console.WriteLine("Long-term loan created.");
            }

            if (currentLoan != null)
            {
                lblNameResults.Text = currentLoan.Name;
                lblLoanTypeResults.Text = currentLoan.Type;
                lblAmountResults.Text = currentLoan.Balance.ToString("C");
                lblCurrentResults.Text = currentLoan.Balance.ToString("C");
                lblDueResults.Text = (currentLoan is ShortTermLoan) ? "450.00" : "200.00";
            }
            else
            {
                ShowErrorMessage("Failed To Create Loan.", "ERROR IN INPUT");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtAmount.Text = "";
            radShortTerm.Checked = false;
            radLongTerm.Checked = false;
            lblNameResults.Text = "";
            lblLoanTypeResults.Text = "";
            lblAmountResults.Text = "";
            lblCurrentResults.Text = "";
            lblDueResults.Text = "";
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            if (currentLoan == null)
            {
                ShowErrorMessage("Please Create A Loan First.", "ERROR IN INPUT");
                return;
            }

            if (!Validator.IsDecimal(txtAmount.Text, "Payment Amount") || double.Parse(txtAmount.Text) <= 0)
            {
                ShowErrorMessage("Please Enter A Valid Positive Payment Amount.", "ERROR IN INPUT");
                return;
            }

            double paymentAmount = double.Parse(txtAmount.Text);
            currentLoan.MakePayment(paymentAmount);

            lblCurrentResults.Text = currentLoan.Balance.ToString("c");

            if (currentLoan.Balance <= 0)
            {
                MessageBox.Show("Congratulations! Your loan has been fully paid off.", "Loan Paid Off",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNOt();
        }

        private void ExitProgramOrNOt()
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

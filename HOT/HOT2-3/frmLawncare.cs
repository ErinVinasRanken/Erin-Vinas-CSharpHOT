using System;
using System.Windows.Forms;

namespace HOT2_3
{
    public partial class frmLawncare : Form
    {
        // Declare and intiialize program constants
        const int WeeksInSeason = 20;
        const decimal FeeLargeLot = 50m;
        const decimal FeeMediumLot = 35m;
        const decimal FeeSmallLot = 25m;
      
        public frmLawncare()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {// Check Length and width from user
            if (decimal.TryParse(txtLength.Text, out decimal length) &&
                decimal.TryParse(txtWidth.Text, out decimal width))
            {
                // Calculate area
                decimal area = length * width;

                // Display the total area of the lawn
                lblArea.Text = $"Area: {area} Square Feet";

                // Calculate weekly mowing fee
                decimal weeklyFee = CalculateWeeklyFee(area);

                // Display the weekly mowing fee
                lblWeeklyFee.Text = $"Weekly Fee: ${weeklyFee.ToString("F2")}";

                // Display length of season
                lblSeasonLength.Text = $"Season Length: {WeeksInSeason} Weeks";

                // Calculate total fee for 20 week season
                decimal totalSeasonFee = weeklyFee * WeeksInSeason;

                // Display total fee for 20 week season
                lblTotalCost.Text = $"Total Cost: ${totalSeasonFee}";
            }
            else
            {
                // Display an error message if not valid
                MessageBox.Show("Invalid Input. Please Enter Valid Numeric Values For Length And Width", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal CalculateWeeklyFee(decimal area)
        {
            if (area >= 600)
            {
                return FeeLargeLot;
            }
            else if (area >= 400)
            {
                return FeeMediumLot;
            }
            else
            {
                return FeeSmallLot;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearForm();
        }

        private void ClearForm()
        {
            txtLength.Text = "";
            txtWidth.Text = "";
            lblArea.Text = "";
            lblWeeklyFee.Text = "";
            lblSeasonLength.Text = "";
            lblTotalCost.Text = "";
            txtLength.Focus();
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
    }
}

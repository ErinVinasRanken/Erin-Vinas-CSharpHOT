using System;
using System.Windows.Forms;

namespace HOT3_1
{
    public partial class frmCustomDesk : Form
    {
        // Declare and initialize constants
        const decimal CherryCost = 125m;
        const decimal MapleCost = 150m;
        const decimal OakCost = 140m;
        const decimal PineCost = 100m;
        const decimal DrawerCost = 30m;

        public frmCustomDesk()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string woodType = txtWood.Text.Trim().ToLower();
            string drawerInput = txtDrawers.Text.Trim();
            int numDrawers;

            // Check if both text boxes are empty
            if (woodType == "" && drawerInput == "")
            {
                ShowErrorMessage("Please Enter Wood Type And Number Of Drawers.", "ERROR IN INPUT");
                return;
            }

            // Check wood type validity
            if (!IsWoodTypeValid(woodType))
            {
                ShowErrorMessage("Invalid Wood Type. Please Enter 'c', 'm', 'o', Or 'p'.", "ERROR IN INPUT");
                return;
            }

            // Check drawer count validity
            if (!IsDrawerCountValid(drawerInput, out numDrawers))
            {
                return;
            }

            // Calculate costs and display
            decimal woodCost = CalculateWoodCost(woodType);
            decimal drawerCost = CalculateDrawerCost(numDrawers);
            decimal totalCost = woodCost + drawerCost;

            lblResults.Text = $"Wood Cost: ${woodCost}\nDrawer Cost: ${drawerCost}\nTotal Cost: ${totalCost}";
        }

        // Method to check is wood count is valid
        private bool IsWoodTypeValid(string woodType)
        {
            return woodType == "c" || woodType == "m" || woodType == "o" || woodType == "p";
        }

        // method to check if drawer count is valid
        private bool IsDrawerCountValid(string input, out int numDrawer)
        {
            if (int.TryParse(input, out numDrawer))
            {
                if (numDrawer >= 1 && numDrawer <= 9)
                {
                    return true;
                }
                else
                {
                    ShowErrorMessage("Invalid Number Of Drawers. Please Enter A Number Between 1 And 9.", "ERROR IN INPUT");
                    return false;
                }
            }
            else
            {
                ShowErrorMessage("Invalid Number Of Drawers. Please Enter A Number Between 1 And 9.", "ERROR IN INPUT");
                return false;
            }
        }

        // Method to calculate cost of wood
        private decimal CalculateWoodCost(string woodType)
        {
            switch (woodType)
            {
                case "c":
                    return CherryCost;
                case "m":
                    return MapleCost;
                case "o":
                    return OakCost;
                case "p":
                    return PineCost;
                default:
                    return 0m;
            }
        }

        // Method to Calculate cost of drawers
        private decimal CalculateDrawerCost(int numDrawers)
        {
            return numDrawers * DrawerCost;
        }

        // Method to calculate desk total
        private decimal CalculateTotalCost(string woodType, int numDrawers)
        {
            decimal woodCost = CalculateWoodCost(woodType);
            decimal drawerCost = CalculateDrawerCost(numDrawers);
            return woodCost + drawerCost;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtWood.Text = "";
            txtDrawers.Text = "";
            lblResults.Text = "";
            txtWood.Focus();
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

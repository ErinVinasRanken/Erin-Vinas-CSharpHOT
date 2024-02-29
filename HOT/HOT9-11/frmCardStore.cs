using System;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace HOT9_11
{
    public partial class frmCardStore : Form
    {
        const decimal BIRTHDAYCARDCOST = 2.50m;
        const decimal GETWELLCARDCOST = 2.75m;
        const decimal SYMPATHYCARDCOST = 3.00m;
        const decimal THANKYOUCARDCOST = 3.50m;

        const decimal EnvelopeCost = 0.25m;
        const decimal StampCost = 0.50m;
        const decimal CustomMessageCost = 0.25m;

        string[] birthdayCards = { "Birthday Card 1", "Birthday Card 2", "Birthday Card 3" };
        string[] getWellCards = { "Get Well Card 1", "Get Well Card 2", "Get Well Card 3" };
        string[] sympathyCards = { "Sympathy Card 1", "Sympathy Card 2", "Sympathy Card 3" };
        string[] thankYouCards = { "Thank You Card 1", "Thank You Card 2", "Thank You Card 3" };

        string[] birthdayCardImages =
        {
            @"C:\Users\rinla\Desktop\HOT911Images\BirthdayCard1.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\BirthdayCard2.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\BirthdayCard3.jpg"
        };

        string[] getWellCardImages =
        {
            @"C:\Users\rinla\Desktop\HOT911Images\GetWellSoonCard1.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\GetWellSoonCard2.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\GetWellSoonCard3.jpg"
        };

        string[] sympathyCardImages =                                       // I tried to resize the photos with paint like last semester however,
                                                                            // I think they changed how to do it and it only ended up cropping the
                                                                            // photos rather than resize.
        {
            @"C:\Users\rinla\Desktop\HOT911Images\SympathyCard1.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\SympathyCard2.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\SympathyCard3.jpg"
        };

        string[] thankYouCardImages =
        {
            @"C:\Users\rinla\Desktop\HOT911Images\ThankYouCard1.jpg",
            @"C:\Users\rinla\Desktop\HOT911Images\ThankYouCard2.png",
            @"C:\Users\rinla\Desktop\HOT911Images\ThankYouCard3.jpg"
        };

        decimal totalCost = 0.00m;

        public frmCardStore()
        {
            InitializeComponent();

            txtCustomMessage.TextChanged += txtCustomMessage_TextChanged;

            txtCustomMessage.KeyPress += txtCustomMessage_KeyPress;

            cbOccasion.Items.Add("Birthday");
            cbOccasion.Items.Add("Get Well Soon");
            cbOccasion.Items.Add("Sympathy");
            cbOccasion.Items.Add("Thank You");

            rbCustomMessage.CheckedChanged += rbCustomMessage_CheckedChanged;
        }

        private void cbOccasion_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleOccasionChange();
        }

        private void HandleOccasionChange()
        {
            cbStyle.Items.Clear();
            cbStyle.SelectedIndex = -1;

            switch (cbOccasion.SelectedIndex)
            {
                case -1:
                    return;

                case 0:
                    for (int lcv = 0; lcv < birthdayCards.Length; ++lcv)
                    {
                        cbStyle.Items.Add(birthdayCards[lcv]);
                    }
                    break;

                case 1:
                    for (int lcv = 0; lcv < getWellCards.Length; ++lcv)
                    {
                        cbStyle.Items.Add(getWellCards[lcv]);
                    }
                    break;

                case 2:
                    for (int lcv = 0; lcv < sympathyCards.Length; ++lcv)
                    {
                        cbStyle.Items.Add(sympathyCards[lcv]);
                    }
                    break;

                case 3:
                    for (int lcv = 0; lcv < thankYouCards.Length; ++lcv)
                    {
                        cbStyle.Items.Add(thankYouCards[lcv]);
                    }
                    break;

                default:
                    break;
            }
        }

        private void cbStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalCost = 0.00m;

            HandleStyleChange();

            UpdateCost();
        }

        private void HandleStyleChange()
        {
            if (cbOccasion.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Choose An Occasion",
                            "NO OCCASION SELECTED",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return;
            }

            if (cbStyle.SelectedIndex == -1)
            {
                MessageBox.Show("You Must Choose A Style",
                            "NO STYLE SELECTED",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                return;
            }

            if (!rbCustomMessage.Checked)
            {
                txtCustomMessage.Enabled = false;
            }

            switch (cbOccasion.SelectedIndex)
            {
                case -1:
                    return;

                case 0:
                    totalCost += BIRTHDAYCARDCOST;

                    pbCardImage.Image =
                        System.Drawing.Image.FromFile(birthdayCardImages[cbStyle.SelectedIndex]);
                    break;


                case 1:
                    totalCost += GETWELLCARDCOST;

                    pbCardImage.Image =
                        System.Drawing.Image.FromFile(getWellCardImages[cbStyle.SelectedIndex]);
                    break;

                case 2:
                    totalCost += SYMPATHYCARDCOST;

                    pbCardImage.Image =
                        System.Drawing.Image.FromFile(sympathyCardImages[cbStyle.SelectedIndex]);
                    break;

                case 3:
                    totalCost += THANKYOUCARDCOST;

                    pbCardImage.Image =
                        System.Drawing.Image.FromFile(thankYouCardImages[cbStyle.SelectedIndex]);
                    break;

                default:
                    break;
            }
        }

        private void frmCardStore_Load(object sender, EventArgs e)
        {
            txtCustomMessage.KeyPress += txtCustomMessage_KeyPress;
        }

        private void rbCustomMessage_CheckedChanged(object sender, EventArgs e)
        {
            txtCustomMessage.Enabled = rbCustomMessage.Checked;
            UpdateCost();
        }

        private void rbEnvelope_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void rbStamp_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCost();
        }

        private void UpdateCost()
        {
            decimal baseCost = 0m;

            if (cbStyle.SelectedItem != null)
            {
                string selectedStyle = cbStyle.SelectedItem.ToString();


                switch (selectedStyle)
                {
                    case "Birthday Card 1":
                    case "Birthday Card 2":
                    case "Birthday Card 3":
                        baseCost = BIRTHDAYCARDCOST;
                        break;
                    case "Get Well Card 1":
                    case "Get Well Card 2":
                    case "Get Well Card 3":
                        baseCost = GETWELLCARDCOST;
                        break;
                    case "Sympathy Card 1":
                    case "Sympathy Card 2":
                    case "Sympathy Card 3":
                        baseCost = SYMPATHYCARDCOST;
                        break;
                    case "Thank You Card 1":
                    case "Thank You Card 2":
                    case "Thank You Card 3":
                        baseCost = THANKYOUCARDCOST;
                        break;
                }
            }

            decimal extraCost = 0m;

            if (rbEnvelope.Checked)
            {
                extraCost += EnvelopeCost;
            }

            if (rbStamp.Checked)
            {
                extraCost += StampCost;
            }

            if (rbCustomMessage.Checked)
            {
                extraCost += CustomMessageCost;
            }

            totalCost = baseCost + extraCost;

            lblCost.Text = $"Total Cost: ${totalCost}"; // I can not get the total cost to show up on the form. I think I have the correct code,
                                                        // I'm not finding any errors in my code anywhere.
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


        }

        private void txtCustomMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string customMessage = txtCustomMessage.Text;

                if (!string.IsNullOrEmpty(customMessage))
                {
                    MessageBox.Show(customMessage, "Custom Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

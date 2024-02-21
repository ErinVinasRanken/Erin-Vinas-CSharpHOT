using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOT8_1
{
    public partial class frmAddressBook : Form
    {
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> phoneNumbers = new List<string>();

        public frmAddressBook()
        {
            InitializeComponent();

            PopulateContactData();
        }

        private void PopulateContactData()
        {
            firstNames.Add("Markel");
            lastNames.Add("Diggory");
            phoneNumbers.Add("555-8390");

            firstNames.Add("Luiza");
            lastNames.Add("Gunnar");
            phoneNumbers.Add("555-4618");

            firstNames.Add("Bryony");
            lastNames.Add("Hester");
            phoneNumbers.Add("555-4440");

            firstNames.Add("Giraldo");
            lastNames.Add("Addy");
            phoneNumbers.Add("555-1687");

            firstNames.Add("Lowri");
            lastNames.Add("Hari");
            phoneNumbers.Add("555-7763");
        }

        private void SearchContacts(string searchName)
        {
            bool found = false;

            for (int i = 0; i < firstNames.Count; i++)
            {
                if (firstNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase) ||
                    lastNames[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    txtResults.Text = ($"First name: {firstNames[i]}\n\tLast Name: {lastNames[i]}\n\tPhone Number: {phoneNumbers[i]}");

                    found = true;
                    break;
                                       
                }
            }

            if (!found)
            {
                ShowErrorMessage("Contact Not Found.", "NOT FOUND");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtNames.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                SearchContacts(searchName);
            }
            else
            {
                ShowErrorMessage("Please Enter A First Or Last Name To Search.",
                                 "EMPTY SEARCH");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNames.Text = "";
            txtResults.Text = "";
            txtNames.Focus();
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

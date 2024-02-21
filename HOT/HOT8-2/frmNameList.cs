using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HOT8_2
{
    public partial class frmNameList : Form
    {
        // Declare class varibales
        List<string> firstNames = new List<string>();
        
        public frmNameList()
        {
            InitializeComponent();

            lvNames.View = View.Details;
            lvNames.Columns.Add("First Name", 250);
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            bool keepGoing = ValidateName();

            if (keepGoing)
            {
                AddNewName();
            }
        }

        private void AddNewName()
        {
            string firstName = txtEnterAName.Text.Trim();

            if (firstNames.Contains(firstName))
            {
                ShowErrorMessage("Name already exists.", "Duplicate Name");
                return;
            }

            firstNames.Add(firstName);

            ClearForm();
            UpdateListView();
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            if(firstNames.Count <= 0)
            {
                ShowErrorMessage("No Name To Update",
                                 "LIST IS EMPTY");
                btnUpdateName.Enabled = false;
                return;
            }
            else
            {
                btnUpdateName.Enabled = true;

                bool keepGoing = ValidateName();

                if(keepGoing)
                {
                    UpdateExistingName();                                                                                                                                                                                                                                                                                                                                                                                                                  
                }
            }
        }

        private void UpdateExistingName()
        {
            if (lvNames.SelectedItems.Count > 0)
            {
                int selectedIndex = lvNames.SelectedIndices[0];

                lvNames.Items[selectedIndex].Text = txtEnterAName.Text.Trim();

                firstNames[selectedIndex] = txtEnterAName.Text.Trim();

                ClearForm();
                UpdateListView();
            }
        }

        private void btnDeleteName_Click(object sender, EventArgs e)
        {
            if (firstNames.Count <= 0)
            {
                ShowErrorMessage("No Employee To Delete",
                                 "LIST IS EMPTY");
                btnDeleteName.Enabled = false;
                return;
            }
            else
            {
                btnDeleteName.Enabled = true;
                DeleteExistingEmployee();
            }
        }

        private void DeleteExistingEmployee()
        {
            int selectedIndex = lvNames.SelectedIndices[0];

            DialogResult dialog = MessageBox.Show(
                         "Do You Really Want To Delete This Name?",
                         "DELETE NAME?",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                firstNames.RemoveAt(selectedIndex);

                ClearForm();
                UpdateListView();
            }
        }

        private bool ValidateName()
        {
            bool result;

            try
            {
                if (txtEnterAName.Text.Trim() == "")
                {
                    throw new ArgumentNullException();
                }

                return true;
            }
            catch (ArgumentNullException ane)
            {
                ShowErrorMessage("System Message:\t" + "\n" +
                                 ane.Message + "\n\n" +
                                 "Feild Cannot Be Empty",
                                 "ARGUMENTNULLEXCEPTION");
                result = false;
            }

            return result;
        }

        private void UpdateListView()
        {
            lvNames.Items.Clear();

            for (int i = 0; i < firstNames.Count; i++)
            {
                ListViewItem item = new ListViewItem(firstNames[i]);

                lvNames.Items.Add(item);
            }

            if (firstNames.Count > 0)
            {
                EnableUpdateAndDeleteButtons();
            }
            else
            {
                DisableUpdateAndDeleteButtons();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtEnterAName.Text = "";
            txtEnterAName.Focus();
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

        private void lvNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewChanged();
        }

        private void ListViewChanged()
        {
            if (lvNames.SelectedItems.Count > 0)
            {
                int selectedIndex = lvNames.SelectedIndices[0];
                txtEnterAName.Text = firstNames[selectedIndex];
            }
        }

        private void frmNameList_Load(object sender, EventArgs e)
        {
            UserMessage();
            DisableUpdateAndDeleteButtons();
        }

        private void UserMessage()
        {
            ShowErrorMessage("To Update Or DeleteAn Existing Name\n" +
                             "Click On The Name To 'Activate'",
                             "PLEASE READ THIS CAREFULLY!");
        }

        private void EnableUpdateAndDeleteButtons()
        {
            btnUpdateName.Enabled = true;
            btnDeleteName.Enabled = true;
        }

        private void DisableUpdateAndDeleteButtons()
        {
            btnUpdateName.Enabled = false;
            btnDeleteName.Enabled = false;
        }
    }
}

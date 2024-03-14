namespace Homework12_01
{
    public partial class frmPassworkCrack : Form
    {
        private Dictionary<string, string> passwordTable;

        public frmPassworkCrack()
        {
            InitializeComponent();
            InitializePasswordTable();
        }

        private void InitializePasswordTable()
        {
            passwordTable = new Dictionary<string, string>
            {
                { "e10adc3949ba59abbe56e057f20f883e", "123456" },
                { "25f9e794323b453885f5181f1b624d0b", "123456789" },
                { "d8578edf8458ce06fbc5bb76a58c5ca4", "qwerty" },
                { "96e79218965eb72c92a549dd5a330112", "111111" },
                { "5f4dcc3b5aa765d61d8327deb882cf99", "password" },
                { "6eea9b7ef19179a06954edd0f6c05ceb", "qwertyuiop" },
                { "c8837b23ff8aaa8a2dde915473ce0991", "123321" },
                { "c822c1b63853ed273b89687ac505f9fa", "google" },
                { "161ebd7d45089b3446ee4e0d86dbcf92", "P@ssw0rd" },
                { "4ece57a61323b52ccffdbef021956754", "Tr0ub4dor&3" },
            };
        }

        private void btnCrack_Click(object sender, EventArgs e)
        {
            string hashedPassword = txtMD5Hash.Text.Trim();

            string crackedPassword = CrackPassword(hashedPassword);

            if (crackedPassword != null)
            {
                lblResults.Text = $"The Raw Password Is: {crackedPassword}";
            }
            else
            {
                lblResults.Text = "* FAIL *";
            }
        }

        public string CrackPassword(string hashedPassword)
        {
            if (passwordTable.ContainsKey(hashedPassword))
            {
                return passwordTable[hashedPassword];
            }
            else
            {
                return null;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtMD5Hash.Text = "";
            lblResults.Text = "";
            txtMD5Hash.Focus();
        }
    }
}

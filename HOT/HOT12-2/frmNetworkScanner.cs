namespace HOT12_2
{
    public partial class frmNetworkScanner : Form
    {
        class Computer
        {
            public string Name { get; set; }
            public string IPAddress { get; set; }
            public Dictionary<int, string> Services { get; set; }
        }

        static List<Computer> computers = new List<Computer>()
        {
            new Computer() { Name = "My - Desktop", IPAddress = "127.0.0.1", Services = new Dictionary<int, string>(){ {20, "\r\n\r\nFTP_DATA" }, { 21, "\r\n\r\nFTP_CONTROL" }, { 23, "\r\n\r\nTELNET" }, { 25, "\r\n\r\nSMTP" }, { 53, "\r\n\r\nDNS" }, { 80, "\r\n\r\nHTTP" }, { 123, "\r\n\r\nNTP" }, { 389, "\r\n\r\nLADP" }, { 443, "\r\n\r\nHTTPS" } } },
            new Computer() { Name = "google - public - dns - a", IPAddress = "8.8.8.8", Services = new Dictionary<int, string>(){ {53, "\r\nDNS" }} },
            new Computer() { Name = "ranken.edu", IPAddress = "47.44.246.80", Services = new Dictionary<int, string>(){ { 25, "\r\n\r\nSMTP" }, { 80, "\r\n\r\nHTTP" }, { 443, "\r\n\r\nHTTPS" } }}
        };
        public frmNetworkScanner()
        {
            InitializeComponent();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string ipAddress = txtIPAddress.Text.Trim();

            Computer foundComputer = ScanIPAddress(ipAddress);
            ShowComputer(foundComputer);
        }

        private Computer ScanIPAddress(string ipAddress)
        {
            foreach (var computer in computers)
            {
                if (computer.IPAddress == ipAddress)
                {
                    return computer;
                }
            }

            return null;
        }

        private void ShowComputer(Computer computer)
        {
            if (computer != null)
            {
                lblComputerName.Text = $"Computer Name: {computer.Name}";
                lblServices.Text = "Services: ";
                foreach (var service in computer.Services) 
                {
                    lblServices.Text += $"{service}, ";
                }
            }
            else
            {
                lblComputerName.Text = "No Computer Found With That IP Address.";
                lblServices.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtIPAddress.Text = "";
            lblComputerName.Text = "";
            lblServices.Text = "";
            txtIPAddress.Focus();
        }
    }
}

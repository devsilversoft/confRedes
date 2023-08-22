using System.Net;
using System.Management;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace confRedes3
{
    public partial class Form1 : Form
    {

        private ManagementObjectCollection _adapterCollection;
        private ManagementObject _selectedAdapter;


        public Form1()
        {
            InitializeComponent();
            LoadNetworkAdapters();
            mostrarInformacoesPc();
        }
        private void LoadNetworkAdapters()
        {
            _adapterCollection = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionStatus = 2").Get();

            connectionListBox.Items.Clear();
            foreach (ManagementObject adapter in _adapterCollection)
            {
                connectionListBox.Items.Add(adapter["NetConnectionID"]);
            }
        }


        private void connectionListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = connectionListBox.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < _adapterCollection.Count)
            {
                _selectedAdapter = GetManagementObjectAtIndex(_adapterCollection, selectedIndex);

                if (_selectedAdapter != null)
                {
                    IPAddressTextBox.Text = "";
                    SubnetMaskTextBox.Text = "";
                    GatewayTextBox.Text = "";
                    DnsTextBox.Text = "";
                    statusRichTextBox.Text = "";

                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (_selectedAdapter != null)
            {

                statusRichTextBox.Text = "Configurando IP Estático, Aguarde...";


                string newIP = IPAddressTextBox.Text;
                string newSubnetMask = SubnetMaskTextBox.Text;
                string newGateway = GatewayTextBox.Text;
                string newDNS = DnsTextBox.Text;

                ConfigureNetwork(_selectedAdapter, newIP, newSubnetMask, newGateway, newDNS);
            }
        }

        private ManagementObject GetManagementObjectAtIndex(ManagementObjectCollection collection, int index)
        {
            int currentIndex = 0;
            foreach (ManagementObject obj in collection)
            {
                if (currentIndex == index)
                {
                    return obj;
                }
                currentIndex++;
            }
            return null;
        }



        private void ConfigureNetwork(ManagementObject adapter, string newIP, string newSubnetMask, string newGateway, string newDNS)
        {
            ManagementObjectCollection configurations = adapter.GetRelated("Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject config in configurations)
            {
                if (Convert.ToBoolean(config["IPEnabled"]))
                {
                    ManagementBaseObject newIPConfig = config.GetMethodParameters("EnableStatic");
                    newIPConfig["IPAddress"] = new string[] { newIP };
                    newIPConfig["SubnetMask"] = new string[] { newSubnetMask };

                    config.InvokeMethod("EnableStatic", newIPConfig, null);

                    ManagementBaseObject newGatewayConfig = config.GetMethodParameters("SetGateways");
                    newGatewayConfig["DefaultIPGateway"] = new string[] { newGateway };
                    newGatewayConfig["GatewayCostMetric"] = new int[] { 1 };

                    config.InvokeMethod("SetGateways", newGatewayConfig, null);

                    ManagementBaseObject newDNSConfig = config.GetMethodParameters("SetDNSServerSearchOrder");
                    newDNSConfig["DNSServerSearchOrder"] = new string[] { newDNS };

                    config.InvokeMethod("SetDNSServerSearchOrder", newDNSConfig, null);

                    statusRichTextBox.Text = "Configuração de IP concluída com sucesso.";
                }
            }
        }



        ///Configurando adaptadores DHCP//

        private void ConfigureDHCP(ManagementObject adapter)
        {

            statusRichTextBox.Text = "Configurando DHCP, Aguarde...";


            ManagementObjectCollection configurations = adapter.GetRelated("Win32_NetworkAdapterConfiguration");

            foreach (ManagementObject config in configurations)
            {
                if (Convert.ToBoolean(config["IPEnabled"]))
                {
                    config.InvokeMethod("EnableDHCP", null);
                    config.InvokeMethod("SetDNSServerSearchOrder", null);

                    statusRichTextBox.Text = "Configuração para DHCP concluída com sucesso.";
                }
            }
        }

        private void DHCPButton_Click(object sender, EventArgs e)
        {
            if (_selectedAdapter != null)
            {
                ConfigureDHCP(_selectedAdapter);
            }
        }

        private void DisableButton_Click(object sender, EventArgs e)
        {
            if (_selectedAdapter != null)
            {
                DisableNetworkAdapter(_selectedAdapter);
            }
        }


        // Desabilitar os adaptadores de rede
        private void DisableNetworkAdapter(ManagementObject adapter)
        {
            adapter.InvokeMethod("Disable", null);
            statusRichTextBox.Text = "Adaptador desativado com sucesso.";
        }

        private void EnableButton_Click(object sender, EventArgs e)
        {
            if (_selectedAdapter != null)
            {
                EnableNetworkAdapter(_selectedAdapter);
            }
        }


        // Ativar os adaptadores de rede
        private void EnableNetworkAdapter(ManagementObject adapter)
        {
            adapter.InvokeMethod("Enable", null);
            statusRichTextBox.Text = "Adaptador ativado com sucesso.";
        }



        // Mostrar os adaptadores desabilitados

        private void LoadDisabledAdapters()
        {
            _adapterCollection = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter WHERE NetConnectionStatus = 0").Get();

            connectionListBox.Items.Clear();
            connectionListBox.Text = "";
            foreach (ManagementObject adapter in _adapterCollection)
            {
                connectionListBox.Items.Add(adapter["NetConnectionID"]);
            }
        }

        private void chbMostrarDesabilitados_CheckedChanged(object sender, EventArgs e)
        {
            if (chbMostrarDesabilitados.Checked)
            {
                connectionListBox.Text = "";
                LoadDisabledAdapters();
            }
            else
            {
                connectionListBox.Text = "";
                LoadNetworkAdapters();
            }
        }



        private void mostrarInformacoesPc()
        {

            ManagementObject computerSystem = new ManagementObject("Win32_ComputerSystem.Name='" + Environment.MachineName + "'");
            computerSystem.Get();

            string computerName = computerSystem["Name"].ToString();
            string userName = Environment.UserName;

            string ipAddress = GetLocalIPAddress();

            string systemInfo = $"\n\nNome do Computador: {computerName}\nNome do Usuário: {userName}\nEndereço IP: {ipAddress}\n";

            richTextBoxInformacoes.Text += systemInfo;

        }

        private string GetLocalIPAddress()
        {
            string hostName = Dns.GetHostName();
            IPAddress[] addresses = Dns.GetHostAddresses(hostName);
            foreach (IPAddress address in addresses)
            {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return address.ToString();
                }
            }
            return "N/A";
        }

    }


}
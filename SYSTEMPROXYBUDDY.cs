using System;
using System.Windows.Forms;

namespace SYSTEMPROXYBUDDY
{
    public partial class SYSTEMPROXYBUDDY : Form
    {
        public SYSTEMPROXYBUDDY()
        {
            InitializeComponent();
            WINSYSTEMPROXY.GetProxyStatus();
            hostTextBox.Text = WINSYSTEMPROXY.currentProxyServerHost;
            portTextBox.Text = WINSYSTEMPROXY.currentProxyServerPort;
            if (WINSYSTEMPROXY.proxyEnabled == true )
            {
                PROXYON.Checked = true;
                PROXYOFF.Checked = false;
            }
            else
            {
                PROXYON.Checked = false;
                PROXYOFF.Checked = true;
            }
        }

        private void hostTextBox_TextChanged(object sender, EventArgs e)
        {
            WINSYSTEMPROXY.currentProxyServerHost = hostTextBox.Text;
        }

        private void portTextBox_TextChanged(object sender, EventArgs e)
        {
            WINSYSTEMPROXY.currentProxyServerPort = portTextBox.Text;
        }

        private void PROXYON_CheckedChanged(object sender, EventArgs e)
        {
            if (PROXYON.Checked)
            {
                WINSYSTEMPROXY.EnableProxy(WINSYSTEMPROXY.currentProxyServerHost, WINSYSTEMPROXY.currentProxyServerPort);
            }
        }

        private void PROXYOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (PROXYOFF.Checked)
            {
                WINSYSTEMPROXY.DisableProxy();
            }
        }
    }
}

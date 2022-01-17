using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DULL
{
    public partial class Form : System.Windows.Forms.Form
    {
        private IPEndPoint endpoint;
        UdpClient client = new UdpClient();
        private bool isListening = false;
        private bool isLogging = false;
        public Form()
        {
            InitializeComponent();
        }

        private void rb_anyip_CheckedChanged(object sender, EventArgs e)
        {
            tb_ipaddress.Enabled = !rb_anyip.Checked;
        }

        private void btn_startstop_Click(object sender, EventArgs e)
        {
            disableControls();   // Disable all inputs
            try
            {
                if (!isListening)   //  If not currently running...
                {
                    buildListener();    //  Builds the UDP-Listener and starts the session
                    btn_startstop.BackColor = Color.Red;
                    btn_startstop.Text = "Stop";
                    isListening = true;
                }
                else   //  If currently running...
                {
                    btn_startstop.BackColor = Color.Green;
                    btn_startstop.Text = "Start";
                    isListening = false;
                }
            }
            catch (Exception ex)
            {
                lbl_debug.Text = ex.Message;
            }
            enableControls();
        }

        private void buildListener()
        {
            client = new UdpClient();
            var port = (int) nud_port.Value;
            IPEndPoint endpoint = (rb_anyip.Checked) ?
                new IPEndPoint(IPAddress.Any, port) :
                new IPEndPoint(IPAddress.Parse(tb_ipaddress.Text), port);  //  Get IP (listen to all IP's or specific)
            client.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            client.Client.Bind(endpoint);
            client.EnableBroadcast = true;
            client.BeginReceive(new AsyncCallback(Listen), null);   // Open UDP session
        }


        private void Listen(IAsyncResult result)
        {
            if (isListening)
            {
                byte[] byteData = client.EndReceive(result, ref endpoint);
                string data = Encoding.UTF8.GetString(byteData);
                this.Invoke(new MethodInvoker(delegate //MUST DO ALL THREADING TASKS WITHIN HERE
                {
                    lbl_debug.Text = data;
                    if (isLogging)
                    {
                        var port = (int)nud_port.Value;
                        File.AppendAllText(port + "_PortData.txt", data + "\n"); //  Write to file
                    }
                }));
                client.BeginReceive(new AsyncCallback(Listen), null);   //  Execute the listener again
            }
        }

        private void disableControls()
        {
            Control[] controls = { btn_startstop, tb_ipaddress, nud_port, rb_anyip, rb_specificip };
            foreach ( Control c in controls) c.Enabled = false;
        }

        private void enableControls()
        {
            Control[] controls = (isListening) ? new Control[]{ btn_startstop } : new Control[] { btn_startstop, tb_ipaddress, nud_port, rb_anyip, rb_specificip };
            foreach (Control c in controls) c.Enabled = true;
            if (rb_anyip.Checked && controls.Length > 1) tb_ipaddress.Enabled = false;
        }

        private void btn_toggleLog_Click(object sender, EventArgs e)
        {
            if (!isLogging)
            {
                btn_toggleLog.BackColor = Color.Red;
                btn_toggleLog.Text = "Stop Log";
            }
            else 
            {
                btn_toggleLog.BackColor = Color.Green;
                btn_toggleLog.Text = "Start Log"; 
            }
            isLogging = !isLogging;
            if (isLogging) lbl_debug.Text = "Logging started.";
            else lbl_debug.Text = "Logging stopped.";

        }
    }
}

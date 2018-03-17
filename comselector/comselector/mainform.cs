using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace comselector {
	public partial class mainform : Form {
		string userappid = "";
		string selectedPort = "";

		public mainform() {
			InitializeComponent();
		}

		private void refreshPorts() {
			comboBoxPorts.Items.Clear();
			string[] apps = LastUserPort.getAllAppids();
			string[] ports = SerialPort.GetPortNames();
			if(ports.Length == 0) {
				MessageBox.Show("No COM-Ports are available on this system!");
				selectPort("COMX");
			}

			UserPortConf previousPort = LastUserPort.getLastPortByUserappID(userappid);
			checkBoxRememberPort.Checked = previousPort.rememberPermanent;

			//set to true if we've found a port that the user has selected before
			bool foundPreviousPort = false;
			foreach (string port in ports) {
				PortInfo portinfo = PortInfo.getPortInfoByPortname(port);

				ComboBoxPortItem item = new ComboBoxPortItem(port, portinfo.beautifulFormatted());
				comboBoxPorts.Items.Add(item);
				if(port == previousPort.portname) {
					comboBoxPorts.SelectedItem = item;
					foundPreviousPort = true;
				}
			}

			if((comboBoxPorts.Items.Count > 0) && !foundPreviousPort) {
				comboBoxPorts.SelectedIndex = 0;
			}

			//user checked to use this port permanently
			if(previousPort.rememberPermanent && foundPreviousPort) {
				selectPort(previousPort.portname);
			}else if(previousPort.rememberPermanent && !foundPreviousPort) {
				checkBoxRememberPort.Checked = false;
				previousPort.rememberPermanent = false;
				LastUserPort.setLastPortByUserappID(userappid, previousPort);
				MessageBox.Show("Previously selected port is not available anymore!");
			}
		}

		private void selectPort(string portname) {
			selectedPort = portname;
			if(portname != "COMX") {
				UserPortConf port;
				port.portname = portname;
				port.rememberPermanent = checkBoxRememberPort.Checked;

				LastUserPort.setLastPortByUserappID(userappid, port);
			}
			Console.WriteLine(portname);
			Application.Exit();
		}

		private void mainform_Load(object sender, EventArgs e) {
			string[] argv = Environment.GetCommandLineArgs();

			if(argv.Length > 1) {
				userappid = argv[1];
			}

			//dynamically set the title and the message if the window, if specified
			if (argv.Length > 2) {
				this.Text = argv[2];
			}
			if(argv.Length > 3) {
				labelUserMsg.Text = argv[3];
			}

			refreshPorts();
		}

		private void mainform_FormClosing(object sender, FormClosingEventArgs e) {
			if (selectedPort == "") {
				MessageBox.Show("Please select a COM-Port!");
				e.Cancel = true;
			}
		}

		private void buttonRefreshPorts_Click(object sender, EventArgs e) {
			refreshPorts();
		}

		private void buttonSelect_Click(object sender, EventArgs e) {
			selectPort(((ComboBoxPortItem)comboBoxPorts.SelectedItem).portname);
		}

		private void buttonInfo_Click(object sender, EventArgs e) {
			aboutform about = new aboutform();
			about.ShowDialog();
		}
	}
	public class ComboBoxPortItem {
		public string portname;
		public string displayname;

		public ComboBoxPortItem(string portname, string displayname) {
			this.portname = portname;
			this.displayname = displayname;
		}
		public override string ToString() {
			return displayname;
		}
	}
}

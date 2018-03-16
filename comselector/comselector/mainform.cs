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
		string instanceid = "";
		string selectedPort = "";

		public mainform() {
			InitializeComponent();
		}

		private void refreshPorts() {
			comboBoxPorts.Items.Clear();

			string[] ports = SerialPort.GetPortNames();
			if(ports.Length == 0) {
				MessageBox.Show("No COM-Ports are available on this system!");
				selectPort("COMX");
			}

			string previousPort = LastUserPort.getLastPortByInstanceID(instanceid);

			ManagementObjectCollection ManObjReturn;
			ManagementObjectSearcher ManObjSearch;
			ManObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort");
			ManObjReturn = ManObjSearch.Get();

			//set to true if we've found a port that the user has selected before
			bool foundPreviousPort = false;

			foreach (ManagementObject ManObj in ManObjReturn) {
				ComboBoxPortItem item = new ComboBoxPortItem(ManObj["DeviceID"].ToString(), ManObj["DeviceID"].ToString() + ": " + ManObj["Caption"].ToString());
				comboBoxPorts.Items.Add(item);
				if(ManObj["DeviceID"].ToString() == previousPort) {
					comboBoxPorts.SelectedItem = item;
					foundPreviousPort = true;
				}
			}

			if((comboBoxPorts.Items.Count > 0) && !foundPreviousPort) {
				comboBoxPorts.SelectedIndex = 0;
			}
		}

		private void selectPort(string port) {
			selectedPort = port;
			if(port != "COMX") {
				LastUserPort.setLastPortByInstanceID(instanceid, port);
			}
			Console.WriteLine(port);
			Application.Exit();
		}

		private void mainform_Load(object sender, EventArgs e) {
			string[] argv = Environment.GetCommandLineArgs();

			if(argv.Length > 1) {
				instanceid = argv[1];
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

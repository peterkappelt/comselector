using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comselector {
	public partial class controlform : Form {
		public controlform() {
			InitializeComponent();
		}

		void refreshProfileList() {
			comboBoxAvailableProfiles.Items.Clear();

			string[] appids = LastUserPort.getAllAppids();
			foreach(string appid in appids) {
				UserPortConf portconf = LastUserPort.getLastPortByUserappID(appid);
				if (portconf.rememberPermanent) {
					comboBoxAvailableProfiles.Items.Add(new ComboBoxAdvancedPortItem(portconf.portname, appid, portconf.portname + " (Application \"" + appid + "\")"));
				}
			}

			if(comboBoxAvailableProfiles.Items.Count == 0) {
				comboBoxAvailableProfiles.Items.Add("No ports are saved permanently!");
				buttonDelProfile.Enabled = false;
			}else {
				buttonDelProfile.Enabled = true;
			}

			comboBoxAvailableProfiles.SelectedIndex = 0;
		}

		private void buttonRefreshProfiles_Click(object sender, EventArgs e) {
			refreshProfileList();
		}

		private void controlform_Load(object sender, EventArgs e) {
			refreshProfileList();
		}

		private void buttonDelProfile_Click(object sender, EventArgs e) {
			ComboBoxAdvancedPortItem item = (ComboBoxAdvancedPortItem)comboBoxAvailableProfiles.SelectedItem;

			UserPortConf newconf;
			newconf.portname = item.portname;
			newconf.rememberPermanent = false;

			LastUserPort.setLastPortByUserappID(item.appid, newconf);

			refreshProfileList();
		}

		private void buttonAbout_Click(object sender, EventArgs e) {
			aboutform about = new aboutform();
			about.ShowDialog();
		}
	}

	public class ComboBoxAdvancedPortItem {
		public string portname;
		public string displayname;
		public string appid;

		public ComboBoxAdvancedPortItem(string portname, string appid, string displayname) {
			this.portname = portname;
			this.displayname = displayname;
			this.appid = appid;
		}
		public override string ToString() {
			return displayname;
		}
	}
}

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
	public partial class aboutform : Form {
		public aboutform() {
			InitializeComponent();
		}

		private void aboutform_Load(object sender, EventArgs e) {
			labelVersion.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
		}

		private void buttonClose_Click(object sender, EventArgs e) {
			this.Close();
		}

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comselector {
	static class Program {
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			string[] args = Environment.GetCommandLineArgs();
			if (args.Length > 1) {
				Application.Run(new mainform());
			}else {
				Application.Run(new controlform());
			}
		}
	}
}

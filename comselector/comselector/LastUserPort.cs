using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comselector {
	static class LastUserPort {
		public static string getLastPortByInstanceID(string instanceid) {
			if(instanceid == "") {
				return "COMX";
			}

			try {
				System.IO.Directory.CreateDirectory(Path.GetTempPath() + "kComselector\\");
				if (File.Exists(Path.GetTempPath() + "kComSelector\\" + instanceid + "_lastport.txt")) {
					return File.ReadAllText(Path.GetTempPath() + "kComSelector\\" + instanceid + "_lastport.txt");
				} else {
					return "COMX";
				}
			}catch(Exception e) {
				return "COMX";
			}
		}

		public static void setLastPortByInstanceID(string instanceid, string port) {
			if (instanceid == "") {
				return;
			}

			try {
				System.IO.Directory.CreateDirectory(Path.GetTempPath() + "kComselector\\");
				File.WriteAllText(Path.GetTempPath() + "kComSelector\\" + instanceid + "_lastport.txt", port);
			}catch {

			}
		}
	}
}

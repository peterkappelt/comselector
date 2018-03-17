using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comselector {
	struct UserPortConf {
		public string portname;
		public bool rememberPermanent;
	}
	static class LastUserPort {
		public static UserPortConf getLastPortByUserappID(string userappid) {
			UserPortConf port;
			port.portname = "COMX";
			port.rememberPermanent = false;

			if(userappid == "") {
				return port;
			}

			try {
				System.IO.Directory.CreateDirectory(Path.GetTempPath() + "kComselector\\");
				if (File.Exists(Path.GetTempPath() + "kComSelector\\" + userappid + "_lastport.txt")) {
					string[] content = File.ReadAllText(Path.GetTempPath() + "kComSelector\\" + userappid + "_lastport.txt").Split('\n');
					if(content.Length > 0) {
						port.portname = content[0];
					}
					if(content.Length > 1) {
						if(content[1] == "rememberport") {
							port.rememberPermanent = true;
						}
					}

					return port;
				} else {
					return port;
				}
			}catch {
				return port;
			}
		}

		public static void setLastPortByUserappID(string userappid, UserPortConf port) {
			if (userappid == "") {
				return;
			}

			try {
				System.IO.Directory.CreateDirectory(Path.GetTempPath() + "kComselector\\");

				string filetext = port.portname;
				if (port.rememberPermanent) {
					filetext += "\nrememberport";
				}

				File.WriteAllText(Path.GetTempPath() + "kComSelector\\" + userappid + "_lastport.txt", filetext);
			}catch {

			}
		}

		public static string[] getAllAppids() {
			try {
				System.IO.Directory.CreateDirectory(Path.GetTempPath() + "kComselector\\");

				string[] files = Directory.GetFiles(Path.GetTempPath() + "kComselector\\", "*.txt");
				List<string> appids = new List<string>();

				foreach(string file in files) {
					MatchCollection matches = Regex.Matches(Path.GetFileName(file), @"(.*)(?:_lastport\.txt)");
					if((matches.Count > 0) && (matches[0].Groups.Count > 1)) {
						appids.Add(matches[0].Groups[1].Value);
					}
				}

				return appids.ToArray();
			} catch {
				string[] ret = { };
				return ret;
			}
 		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace comselector {
	class PortInfo {
		/** Name of the Port, like COM3 */
		public string portname;
		/** true if port was found */
		public bool found;
		/** Description of Port */
		public string description;
		/** Manufacturer of Port/ Converter */
		public string manufacturer;

		public PortInfo(string portname, bool found, string description, string manufacturer) {
			this.portname = portname;
			this.found = found;
			this.description = description;
			this.manufacturer = manufacturer;
		}

		/**
		 * return a well formatted string containing the available information
		 */
		public string beautifulFormatted() {
			//beautiful formatting for user depending on available information
			string displaytext = portname;
			if (description != "" || manufacturer != "") {
				displaytext += " (";
			}
			if (description != "") {
				displaytext += description;
			}
			if (description != "" && manufacturer != "") {
				displaytext += "; ";
			}
			if (manufacturer != "") {
				displaytext += manufacturer;
			}
			if (description != "" || manufacturer != "") {
				displaytext += ")";
			}

			return displaytext;
		}

		public static PortInfo getPortInfoByPortname(string portname) {
			ManagementObjectSearcher ManObjSearch;
			ManObjSearch = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_PnPEntity WHERE Name LIKE '%(COM[0-9]%'");

			foreach (ManagementObject ManObj in ManObjSearch.Get()) {
				MatchCollection matches = Regex.Matches(ManObj["Name"].ToString(), @"(COM[0-9]+)");
				if((matches.Count > 0) && (matches[0].Value == portname)) {
					string manufacturer = "";
					string description = "";
					description = ManObj["Description"].ToString();
					manufacturer = ManObj["Manufacturer"].ToString();

					return new PortInfo(portname, true, description, manufacturer);
				}
			}

			return new PortInfo(portname, false, "", "");
		}
	}
}

namespace comselector {
	partial class mainform {
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
			this.labelUserMsg = new System.Windows.Forms.Label();
			this.comboBoxPorts = new System.Windows.Forms.ComboBox();
			this.buttonRefreshPorts = new System.Windows.Forms.Button();
			this.buttonSelect = new System.Windows.Forms.Button();
			this.buttonInfo = new System.Windows.Forms.Button();
			this.checkBoxRememberPort = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// labelUserMsg
			// 
			this.labelUserMsg.AutoSize = true;
			this.labelUserMsg.Location = new System.Drawing.Point(12, 9);
			this.labelUserMsg.Name = "labelUserMsg";
			this.labelUserMsg.Size = new System.Drawing.Size(131, 13);
			this.labelUserMsg.TabIndex = 0;
			this.labelUserMsg.Text = "Please select a COM-Port:";
			// 
			// comboBoxPorts
			// 
			this.comboBoxPorts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPorts.FormattingEnabled = true;
			this.comboBoxPorts.Location = new System.Drawing.Point(12, 25);
			this.comboBoxPorts.Name = "comboBoxPorts";
			this.comboBoxPorts.Size = new System.Drawing.Size(386, 21);
			this.comboBoxPorts.TabIndex = 1;
			// 
			// buttonRefreshPorts
			// 
			this.buttonRefreshPorts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRefreshPorts.Location = new System.Drawing.Point(404, 23);
			this.buttonRefreshPorts.Name = "buttonRefreshPorts";
			this.buttonRefreshPorts.Size = new System.Drawing.Size(23, 23);
			this.buttonRefreshPorts.TabIndex = 2;
			this.buttonRefreshPorts.Text = "↻";
			this.buttonRefreshPorts.UseVisualStyleBackColor = true;
			this.buttonRefreshPorts.Click += new System.EventHandler(this.buttonRefreshPorts_Click);
			// 
			// buttonSelect
			// 
			this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSelect.Location = new System.Drawing.Point(352, 52);
			this.buttonSelect.Name = "buttonSelect";
			this.buttonSelect.Size = new System.Drawing.Size(75, 23);
			this.buttonSelect.TabIndex = 3;
			this.buttonSelect.Text = "Select Port";
			this.buttonSelect.UseVisualStyleBackColor = true;
			this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
			// 
			// buttonInfo
			// 
			this.buttonInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonInfo.Location = new System.Drawing.Point(12, 52);
			this.buttonInfo.Name = "buttonInfo";
			this.buttonInfo.Size = new System.Drawing.Size(44, 23);
			this.buttonInfo.TabIndex = 4;
			this.buttonInfo.Text = "About";
			this.buttonInfo.UseVisualStyleBackColor = true;
			this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
			// 
			// checkBoxRememberPort
			// 
			this.checkBoxRememberPort.AutoSize = true;
			this.checkBoxRememberPort.Location = new System.Drawing.Point(62, 56);
			this.checkBoxRememberPort.Name = "checkBoxRememberPort";
			this.checkBoxRememberPort.Size = new System.Drawing.Size(124, 17);
			this.checkBoxRememberPort.TabIndex = 5;
			this.checkBoxRememberPort.Text = "Remember Selection";
			this.checkBoxRememberPort.UseVisualStyleBackColor = true;
			// 
			// mainform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 87);
			this.ControlBox = false;
			this.Controls.Add(this.checkBoxRememberPort);
			this.Controls.Add(this.buttonInfo);
			this.Controls.Add(this.buttonSelect);
			this.Controls.Add(this.buttonRefreshPorts);
			this.Controls.Add(this.comboBoxPorts);
			this.Controls.Add(this.labelUserMsg);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "mainform";
			this.Text = "kComselector";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
			this.Load += new System.EventHandler(this.mainform_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelUserMsg;
		private System.Windows.Forms.ComboBox comboBoxPorts;
		private System.Windows.Forms.Button buttonRefreshPorts;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.Button buttonInfo;
		private System.Windows.Forms.CheckBox checkBoxRememberPort;
	}
}


namespace comselector {
	partial class controlform {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlform));
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxAvailableProfiles = new System.Windows.Forms.ComboBox();
			this.buttonRefreshProfiles = new System.Windows.Forms.Button();
			this.buttonDelProfile = new System.Windows.Forms.Button();
			this.buttonAbout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Saved previous Selections:";
			// 
			// comboBoxAvailableProfiles
			// 
			this.comboBoxAvailableProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxAvailableProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAvailableProfiles.FormattingEnabled = true;
			this.comboBoxAvailableProfiles.Location = new System.Drawing.Point(12, 25);
			this.comboBoxAvailableProfiles.Name = "comboBoxAvailableProfiles";
			this.comboBoxAvailableProfiles.Size = new System.Drawing.Size(470, 21);
			this.comboBoxAvailableProfiles.TabIndex = 1;
			// 
			// buttonRefreshProfiles
			// 
			this.buttonRefreshProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonRefreshProfiles.Location = new System.Drawing.Point(517, 23);
			this.buttonRefreshProfiles.Name = "buttonRefreshProfiles";
			this.buttonRefreshProfiles.Size = new System.Drawing.Size(23, 23);
			this.buttonRefreshProfiles.TabIndex = 2;
			this.buttonRefreshProfiles.Text = "↻";
			this.buttonRefreshProfiles.UseVisualStyleBackColor = true;
			this.buttonRefreshProfiles.Click += new System.EventHandler(this.buttonRefreshProfiles_Click);
			// 
			// buttonDelProfile
			// 
			this.buttonDelProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDelProfile.Location = new System.Drawing.Point(488, 23);
			this.buttonDelProfile.Name = "buttonDelProfile";
			this.buttonDelProfile.Size = new System.Drawing.Size(23, 23);
			this.buttonDelProfile.TabIndex = 3;
			this.buttonDelProfile.Text = "X";
			this.buttonDelProfile.UseVisualStyleBackColor = true;
			this.buttonDelProfile.Click += new System.EventHandler(this.buttonDelProfile_Click);
			// 
			// buttonAbout
			// 
			this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonAbout.Location = new System.Drawing.Point(12, 52);
			this.buttonAbout.Name = "buttonAbout";
			this.buttonAbout.Size = new System.Drawing.Size(75, 23);
			this.buttonAbout.TabIndex = 4;
			this.buttonAbout.Text = "About";
			this.buttonAbout.UseVisualStyleBackColor = true;
			this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
			// 
			// controlform
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(552, 87);
			this.Controls.Add(this.buttonAbout);
			this.Controls.Add(this.buttonDelProfile);
			this.Controls.Add(this.buttonRefreshProfiles);
			this.Controls.Add(this.comboBoxAvailableProfiles);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "controlform";
			this.Text = "kComselector";
			this.Load += new System.EventHandler(this.controlform_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBoxAvailableProfiles;
		private System.Windows.Forms.Button buttonRefreshProfiles;
		private System.Windows.Forms.Button buttonDelProfile;
		private System.Windows.Forms.Button buttonAbout;
	}
}
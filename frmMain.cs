using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm {
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}

		#region Main
		private void frmMain_Load(object sender, EventArgs e) {
			// Disable stop buttons
			Stop();

			// Show/hide tray icon
			CheckWindowState();

			// Time/date options
			HourFormat();
			UpdateTimeStatus();
			UpdateDateStatus();

			// Statusbar options
			HideDate();
			HideTime();

			cmbHour.SelectedIndex = 0;
			cmbMinute.SelectedIndex = 0;
			cmbSecond.SelectedIndex = 0;
		}

		private void frmMain_Resize(object sender, EventArgs e) {
			CheckWindowState();
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.Default.Save();
		}
		#endregion

		#region Main Window
		private void btnStart_Click(object sender, EventArgs e) {
			Start();
		}

		private void btnStop_Click(object sender, EventArgs e) {
			Stop();
		}

		private void chkContinuous_CheckedChanged(object sender, EventArgs e) {
			Properties.Settings.Default.contAlarm = chkContinuous.Checked;
		}
		#endregion

		#region Comboboxes
		private void cmbHour_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateAlarmStatus();
		}

		private void cmbMinute_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateAlarmStatus();
		}

		private void cmbSecond_SelectedIndexChanged(object sender, EventArgs e) {
			UpdateAlarmStatus();
		}
		#endregion

		#region File Menu
		private void fileStart_Click(object sender, EventArgs e) {
			Start();
		}

		private void fileStop_Click(object sender, EventArgs e) {
			Stop();
		}

		private void fileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		#endregion

		#region Options Menu
		private void optionsTrayIcon_Click(object sender, EventArgs e) {
			Properties.Settings.Default.trayIcon = optionsTrayIcon.Checked;

			if(Properties.Settings.Default.trayIcon == true) {
				trayIcon.Visible = true;
			}
			else {
				trayIcon.Visible = false;
			}
		}

		private void optionsAlert_Click(object sender, EventArgs e) {
			Properties.Settings.Default.alertPopup = optionsAlert.Checked;
		}

		private void optionsSoundAlert_Click(object sender, EventArgs e) {
			Properties.Settings.Default.soundAlert = optionsSoundAlert.Checked;
		}

		private void options24Hour_Click(object sender, EventArgs e) {
			Properties.Settings.Default.hour24Format = options24Hour.Checked;

			HourFormat();
			UpdateTimeStatus();
		}

		private void optionsDayMonthYear_Click(object sender, EventArgs e) {
			Properties.Settings.Default.dmyFormat = optionsDayMonthYear.Checked;

			UpdateDateStatus();
		}

		private void optionsHideDate_Click(object sender, EventArgs e) {
			Properties.Settings.Default.hideDate = optionsHideDate.Checked;

			HideDate();
		}

		private void optionsHideTime_Click(object sender, EventArgs e) {
			Properties.Settings.Default.hideTime = optionsHideTime.Checked;

			HideTime();
		}
		#endregion

		#region Help Menu
		private void helpAbluescarab_Click(object sender, EventArgs e) {
			Process.Start("http://www.abluescarab.us");
		}

		private void helpGithub_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/abluescarab/alarm/releases");
		}

		private void helpChangelog_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "/Resources/changelog.txt");
		}

		private void helpHelp_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "/Resources/Simple Alarm Help.html");
		}

		private void helpAbout_Click(object sender, EventArgs e) {
			frmAbout frmAbout = new frmAbout();
			frmAbout.ShowDialog();
		}
		#endregion

		#region Timers
		private void tmrAlarm_Tick(object sender, EventArgs e) {
			DateTime alarmTime = Convert.ToDateTime(statusAlarm.Text);

			if(alarmTime.Hour == DateTime.Now.Hour && alarmTime.Minute == DateTime.Now.Minute && alarmTime.Second == DateTime.Now.Second) {
				// Bring window to foreground
				if(this.WindowState == FormWindowState.Minimized) {
					this.WindowState = FormWindowState.Normal;
				}
				else {
					this.TopMost = true;
					this.Focus();
					this.BringToFront();
				}

				CheckWindowState();

				// Play sound if enabled
				if(Properties.Settings.Default.soundAlert == false) {
					System.Media.SystemSounds.Asterisk.Play();
				}
				
				// Display message if enabled
				if(Properties.Settings.Default.alertPopup == false) {
					if(txtMessage.Text != "") {
						MessageBox.Show(txtMessage.Text, "Alarm");
					}
					else {
						MessageBox.Show("It's time!", "Alarm");
					}
				}

				this.TopMost = false;

				if(Properties.Settings.Default.contAlarm == false) {
					Stop();
				}
				else {
					alarmTime = alarmTime.AddDays(1);
				}
			}
		}

		private void tmrStatusTime_Tick(object sender, EventArgs e) {
			UpdateTimeStatus();
		}

		private void tmrStatusDate_Tick(object sender, EventArgs e) {
			UpdateDateStatus();
		}
		#endregion

		#region Tray Menu
		private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e) {
			this.WindowState = FormWindowState.Normal;
			CheckWindowState();
		}
		
		private void trayShow_Click(object sender, EventArgs e) {
			this.WindowState = FormWindowState.Normal;
			CheckWindowState();
		}

		private void trayStart_Click(object sender, EventArgs e) {
			Start();
		}

		private void trayStop_Click(object sender, EventArgs e) {
			Stop();
		}

		private void trayExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}
		#endregion

		#region Functions
		private void Start() {
			btnStart.Enabled = false;
			btnStop.Enabled = true;

			fileStart.Enabled = false;
			fileStop.Enabled = true;

			trayStart.Enabled = false;
			trayStop.Enabled = true;

			txtMessage.Enabled = false;

			tmrAlarm.Enabled = true;
		}

		private void Stop() {
			btnStart.Enabled = true;
			btnStop.Enabled = false;

			fileStart.Enabled = true;
			fileStop.Enabled = false;

			trayStart.Enabled = true;
			trayStop.Enabled = false;

			if(Properties.Settings.Default.alertPopup == false) {
				txtMessage.Enabled = true;
			}
			
			tmrAlarm.Enabled = false;
		}

		private void HourFormat() {
			int currentIndex = cmbHour.SelectedIndex;

			if(Properties.Settings.Default.hour24Format == true) {
				cmbHour.Items.Clear();

				for(int i = 0; i < 24; i++) {
					if(i < 10) {
						cmbHour.Items.Add("0" + i);
					}
					else {
						cmbHour.Items.Add(i);
					}
				}
			}
			else {
				cmbHour.Items.Clear();

				cmbHour.Items.AddRange(new string[] { "12AM", "1AM", "2AM", "3AM", "4AM", "5AM", "6AM", "7AM", "8AM", "9AM", "10AM", "11AM",
					"12PM", "1PM", "2PM", "3PM", "4PM", "5PM", "6PM", "7PM", "8PM", "9PM", "10PM", "11PM" });
			}

			cmbHour.SelectedIndex = currentIndex;
		}

		private void HideDate() {
			if(Properties.Settings.Default.hideDate == true) {
				statusDate.Visible = false;
				statusSep1.Visible = false;
			}
			else {
				statusDate.Visible = true;
				statusSep1.Visible = true;
			}
		}

		private void HideTime() {
			if(Properties.Settings.Default.hideTime == true) {
				statusTime.Visible = false;
				statusSep2.Visible = false;
			}
			else {
				statusTime.Visible = true;
				statusSep2.Visible = true;
			}
		}

		private void UpdateAlarmStatus() {
			string stringH = cmbHour.GetItemText(cmbHour.SelectedItem);
			string stringM = cmbHour.GetItemText(cmbMinute.SelectedItem);
			string stringS = cmbHour.GetItemText(cmbSecond.SelectedItem);
			string ampm;

			if(Properties.Settings.Default.hour24Format == false) {
				// Removes AM/PM from end of string
				if(stringH.Length == 4) {
					if(stringH.Substring(2) == "AM") {
						ampm = "AM";
					}
					else {
						ampm = "PM";
					}

					stringH = stringH.Replace(stringH.Substring(2), "");
				}
				else {
					if(stringH.Substring(1) == "AM") {
						ampm = "AM";
					}
					else {
						ampm = "PM";
					}

					stringH = stringH.Replace(stringH.Substring(1), "");
				}

				statusAlarm.Text = stringH + ":" + stringM + ":" + stringS + " " + ampm;
			}
			else {
				statusAlarm.Text = stringH + ":" + stringM + ":" + stringS;
			}
		}

		private void UpdateTimeStatus() {
			if(Properties.Settings.Default.hour24Format == true) {
				statusTime.Text = DateTime.Now.ToString("HH:mm:ss");
			}
			else {
				statusTime.Text = DateTime.Now.ToString("h:mm:ss tt");
			}
		}

		private void UpdateDateStatus() {
			if(Properties.Settings.Default.dmyFormat == true) {
				statusDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
			}
			else {
				statusDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
			}
		}

		private void CheckWindowState() {
			if(this.WindowState == FormWindowState.Minimized) {
				trayIcon.Visible = true;
				this.ShowInTaskbar = false;
			}
			else if(this.WindowState == FormWindowState.Normal) {
				if(Properties.Settings.Default.trayIcon == false) {
					trayIcon.Visible = false;
				}

				this.ShowInTaskbar = true;
			}
		}

		#endregion
	}
}

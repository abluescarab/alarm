namespace Alarm {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.lblHour = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.statusDate = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusSep1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusSep2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAlarmText = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusAlarm = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.fileStart = new System.Windows.Forms.ToolStripMenuItem();
			this.fileStop = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbluescarab = new System.Windows.Forms.ToolStripMenuItem();
			this.helpGithub = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpChangelog = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.helpHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.lblMinute = new System.Windows.Forms.Label();
			this.lblSecond = new System.Windows.Forms.Label();
			this.cmbSecond = new System.Windows.Forms.ComboBox();
			this.cmbMinute = new System.Windows.Forms.ComboBox();
			this.cmbHour = new System.Windows.Forms.ComboBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.lblMessage = new System.Windows.Forms.Label();
			this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.trayIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.trayShow = new System.Windows.Forms.ToolStripMenuItem();
			this.traySep1 = new System.Windows.Forms.ToolStripSeparator();
			this.trayStart = new System.Windows.Forms.ToolStripMenuItem();
			this.trayStop = new System.Windows.Forms.ToolStripMenuItem();
			this.traySep2 = new System.Windows.Forms.ToolStripSeparator();
			this.trayExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tmrStatusTime = new System.Windows.Forms.Timer(this.components);
			this.tmrStatusDate = new System.Windows.Forms.Timer(this.components);
			this.tmrAlarm = new System.Windows.Forms.Timer(this.components);
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.chkContinuous = new System.Windows.Forms.CheckBox();
			this.optionsTrayIcon = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsAlert = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsSoundAlert = new System.Windows.Forms.ToolStripMenuItem();
			this.options24Hour = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsDayMonthYear = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsHideDate = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsHideTime = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.trayIconMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblHour
			// 
			this.lblHour.AutoSize = true;
			this.lblHour.Location = new System.Drawing.Point(12, 31);
			this.lblHour.Name = "lblHour";
			this.lblHour.Size = new System.Drawing.Size(33, 13);
			this.lblHour.TabIndex = 0;
			this.lblHour.Text = "Hour:";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusDate,
            this.statusSep1,
            this.statusTime,
            this.statusSep2,
            this.statusAlarmText,
            this.statusAlarm});
			this.statusStrip1.Location = new System.Drawing.Point(0, 144);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(319, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// statusDate
			// 
			this.statusDate.Name = "statusDate";
			this.statusDate.Size = new System.Drawing.Size(31, 17);
			this.statusDate.Text = "Date";
			// 
			// statusSep1
			// 
			this.statusSep1.Name = "statusSep1";
			this.statusSep1.Size = new System.Drawing.Size(10, 17);
			this.statusSep1.Text = "|";
			// 
			// statusTime
			// 
			this.statusTime.Name = "statusTime";
			this.statusTime.Size = new System.Drawing.Size(34, 17);
			this.statusTime.Text = "Time";
			// 
			// statusSep2
			// 
			this.statusSep2.Name = "statusSep2";
			this.statusSep2.Size = new System.Drawing.Size(10, 17);
			this.statusSep2.Text = "|";
			// 
			// statusAlarmText
			// 
			this.statusAlarmText.Name = "statusAlarmText";
			this.statusAlarmText.Size = new System.Drawing.Size(42, 17);
			this.statusAlarmText.Text = "Alarm:";
			// 
			// statusAlarm
			// 
			this.statusAlarm.Name = "statusAlarm";
			this.statusAlarm.Size = new System.Drawing.Size(71, 17);
			this.statusAlarm.Text = "12:00:00 AM";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(319, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileStart,
            this.fileStop,
            this.fileSep1,
            this.fileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// fileStart
			// 
			this.fileStart.Image = global::Alarm.Properties.Resources.control_play_blue;
			this.fileStart.Name = "fileStart";
			this.fileStart.Size = new System.Drawing.Size(98, 22);
			this.fileStart.Text = "Start";
			this.fileStart.Click += new System.EventHandler(this.fileStart_Click);
			// 
			// fileStop
			// 
			this.fileStop.Image = global::Alarm.Properties.Resources.control_stop_blue;
			this.fileStop.Name = "fileStop";
			this.fileStop.Size = new System.Drawing.Size(98, 22);
			this.fileStop.Text = "Stop";
			this.fileStop.Click += new System.EventHandler(this.fileStop_Click);
			// 
			// fileSep1
			// 
			this.fileSep1.Name = "fileSep1";
			this.fileSep1.Size = new System.Drawing.Size(95, 6);
			// 
			// fileExit
			// 
			this.fileExit.Image = global::Alarm.Properties.Resources.cross;
			this.fileExit.Name = "fileExit";
			this.fileExit.Size = new System.Drawing.Size(98, 22);
			this.fileExit.Text = "Exit";
			this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
			// 
			// menuOptions
			// 
			this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsTrayIcon,
            this.optionsAlert,
            this.optionsSoundAlert,
            this.optionsSep1,
            this.options24Hour,
            this.optionsDayMonthYear,
            this.optionsSep2,
            this.optionsHideDate,
            this.optionsHideTime});
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new System.Drawing.Size(61, 20);
			this.menuOptions.Text = "Options";
			// 
			// optionsSep1
			// 
			this.optionsSep1.Name = "optionsSep1";
			this.optionsSep1.Size = new System.Drawing.Size(199, 6);
			// 
			// optionsSep2
			// 
			this.optionsSep2.Name = "optionsSep2";
			this.optionsSep2.Size = new System.Drawing.Size(199, 6);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbluescarab,
            this.helpGithub,
            this.helpSep1,
            this.helpChangelog,
            this.helpSep2,
            this.helpHelp,
            this.helpAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 20);
			this.menuHelp.Text = "Help";
			// 
			// helpAbluescarab
			// 
			this.helpAbluescarab.Image = global::Alarm.Properties.Resources.scarab;
			this.helpAbluescarab.Name = "helpAbluescarab";
			this.helpAbluescarab.Size = new System.Drawing.Size(208, 22);
			this.helpAbluescarab.Text = "Visit Abluescarab Designs";
			this.helpAbluescarab.Click += new System.EventHandler(this.helpAbluescarab_Click);
			// 
			// helpGithub
			// 
			this.helpGithub.Image = global::Alarm.Properties.Resources.github;
			this.helpGithub.Name = "helpGithub";
			this.helpGithub.Size = new System.Drawing.Size(208, 22);
			this.helpGithub.Text = "Visit the GitHub project";
			this.helpGithub.Click += new System.EventHandler(this.helpGithub_Click);
			// 
			// helpSep1
			// 
			this.helpSep1.Name = "helpSep1";
			this.helpSep1.Size = new System.Drawing.Size(205, 6);
			// 
			// helpChangelog
			// 
			this.helpChangelog.Image = global::Alarm.Properties.Resources.page_white_text;
			this.helpChangelog.Name = "helpChangelog";
			this.helpChangelog.Size = new System.Drawing.Size(208, 22);
			this.helpChangelog.Text = "Changelog...";
			this.helpChangelog.Click += new System.EventHandler(this.helpChangelog_Click);
			// 
			// helpSep2
			// 
			this.helpSep2.Name = "helpSep2";
			this.helpSep2.Size = new System.Drawing.Size(205, 6);
			// 
			// helpHelp
			// 
			this.helpHelp.Image = global::Alarm.Properties.Resources.help;
			this.helpHelp.Name = "helpHelp";
			this.helpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpHelp.Size = new System.Drawing.Size(208, 22);
			this.helpHelp.Text = "Help Topics";
			this.helpHelp.Click += new System.EventHandler(this.helpHelp_Click);
			// 
			// helpAbout
			// 
			this.helpAbout.Image = global::Alarm.Properties.Resources.information;
			this.helpAbout.Name = "helpAbout";
			this.helpAbout.Size = new System.Drawing.Size(208, 22);
			this.helpAbout.Text = "About";
			this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
			// 
			// lblMinute
			// 
			this.lblMinute.AutoSize = true;
			this.lblMinute.Location = new System.Drawing.Point(12, 58);
			this.lblMinute.Name = "lblMinute";
			this.lblMinute.Size = new System.Drawing.Size(42, 13);
			this.lblMinute.TabIndex = 3;
			this.lblMinute.Text = "Minute:";
			// 
			// lblSecond
			// 
			this.lblSecond.AutoSize = true;
			this.lblSecond.Location = new System.Drawing.Point(12, 85);
			this.lblSecond.Name = "lblSecond";
			this.lblSecond.Size = new System.Drawing.Size(47, 13);
			this.lblSecond.TabIndex = 4;
			this.lblSecond.Text = "Second:";
			// 
			// cmbSecond
			// 
			this.cmbSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSecond.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSecond.FormattingEnabled = true;
			this.cmbSecond.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.cmbSecond.Location = new System.Drawing.Point(71, 81);
			this.cmbSecond.Name = "cmbSecond";
			this.cmbSecond.Size = new System.Drawing.Size(65, 21);
			this.cmbSecond.TabIndex = 5;
			this.cmbSecond.SelectedIndexChanged += new System.EventHandler(this.cmbSecond_SelectedIndexChanged);
			// 
			// cmbMinute
			// 
			this.cmbMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMinute.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMinute.FormattingEnabled = true;
			this.cmbMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.cmbMinute.Location = new System.Drawing.Point(71, 54);
			this.cmbMinute.Name = "cmbMinute";
			this.cmbMinute.Size = new System.Drawing.Size(65, 21);
			this.cmbMinute.TabIndex = 6;
			this.cmbMinute.SelectedIndexChanged += new System.EventHandler(this.cmbMinute_SelectedIndexChanged);
			// 
			// cmbHour
			// 
			this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbHour.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbHour.FormattingEnabled = true;
			this.cmbHour.Location = new System.Drawing.Point(71, 27);
			this.cmbHour.Name = "cmbHour";
			this.cmbHour.Size = new System.Drawing.Size(65, 21);
			this.cmbHour.TabIndex = 7;
			this.cmbHour.SelectedIndexChanged += new System.EventHandler(this.cmbHour_SelectedIndexChanged);
			// 
			// txtMessage
			// 
			this.txtMessage.Location = new System.Drawing.Point(71, 108);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(236, 33);
			this.txtMessage.TabIndex = 8;
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Location = new System.Drawing.Point(12, 112);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(53, 13);
			this.lblMessage.TabIndex = 9;
			this.lblMessage.Text = "Message:";
			// 
			// trayIcon
			// 
			this.trayIcon.ContextMenuStrip = this.trayIconMenu;
			this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
			this.trayIcon.Text = "Abluescarab Designs Alarm";
			this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
			// 
			// trayIconMenu
			// 
			this.trayIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trayShow,
            this.traySep1,
            this.trayStart,
            this.trayStop,
            this.traySep2,
            this.trayExit});
			this.trayIconMenu.Name = "trayIconMenu";
			this.trayIconMenu.Size = new System.Drawing.Size(151, 104);
			// 
			// trayShow
			// 
			this.trayShow.Image = global::Alarm.Properties.Resources.application_get;
			this.trayShow.Name = "trayShow";
			this.trayShow.Size = new System.Drawing.Size(150, 22);
			this.trayShow.Text = "Show Window";
			this.trayShow.Click += new System.EventHandler(this.trayShow_Click);
			// 
			// traySep1
			// 
			this.traySep1.Name = "traySep1";
			this.traySep1.Size = new System.Drawing.Size(147, 6);
			// 
			// trayStart
			// 
			this.trayStart.Image = global::Alarm.Properties.Resources.control_play_blue;
			this.trayStart.Name = "trayStart";
			this.trayStart.Size = new System.Drawing.Size(150, 22);
			this.trayStart.Text = "Start";
			this.trayStart.Click += new System.EventHandler(this.trayStart_Click);
			// 
			// trayStop
			// 
			this.trayStop.Image = global::Alarm.Properties.Resources.control_stop_blue;
			this.trayStop.Name = "trayStop";
			this.trayStop.Size = new System.Drawing.Size(150, 22);
			this.trayStop.Text = "Stop";
			this.trayStop.Click += new System.EventHandler(this.trayStop_Click);
			// 
			// traySep2
			// 
			this.traySep2.Name = "traySep2";
			this.traySep2.Size = new System.Drawing.Size(147, 6);
			// 
			// trayExit
			// 
			this.trayExit.Image = global::Alarm.Properties.Resources.cross;
			this.trayExit.Name = "trayExit";
			this.trayExit.Size = new System.Drawing.Size(150, 22);
			this.trayExit.Text = "Exit";
			this.trayExit.Click += new System.EventHandler(this.trayExit_Click);
			// 
			// tmrStatusTime
			// 
			this.tmrStatusTime.Enabled = true;
			this.tmrStatusTime.Interval = 1000;
			this.tmrStatusTime.Tick += new System.EventHandler(this.tmrStatusTime_Tick);
			// 
			// tmrStatusDate
			// 
			this.tmrStatusDate.Enabled = true;
			this.tmrStatusDate.Interval = 86400000;
			this.tmrStatusDate.Tick += new System.EventHandler(this.tmrStatusDate_Tick);
			// 
			// tmrAlarm
			// 
			this.tmrAlarm.Interval = 1000;
			this.tmrAlarm.Tick += new System.EventHandler(this.tmrAlarm_Tick);
			// 
			// btnStop
			// 
			this.btnStop.Image = global::Alarm.Properties.Resources.control_stop_blue;
			this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStop.Location = new System.Drawing.Point(224, 56);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(83, 23);
			this.btnStop.TabIndex = 11;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Image = global::Alarm.Properties.Resources.control_play_blue;
			this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnStart.Location = new System.Drawing.Point(224, 27);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(83, 23);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// chkContinuous
			// 
			this.chkContinuous.AutoSize = true;
			this.chkContinuous.Checked = global::Alarm.Properties.Settings.Default.contAlarm;
			this.chkContinuous.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Alarm.Properties.Settings.Default, "contAlarm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.chkContinuous.Location = new System.Drawing.Point(197, 85);
			this.chkContinuous.Name = "chkContinuous";
			this.chkContinuous.Size = new System.Drawing.Size(110, 17);
			this.chkContinuous.TabIndex = 12;
			this.chkContinuous.Text = "Repeat every day";
			this.chkContinuous.UseVisualStyleBackColor = true;
			this.chkContinuous.CheckedChanged += new System.EventHandler(this.chkContinuous_CheckedChanged);
			// 
			// optionsTrayIcon
			// 
			this.optionsTrayIcon.Checked = global::Alarm.Properties.Settings.Default.trayIcon;
			this.optionsTrayIcon.CheckOnClick = true;
			this.optionsTrayIcon.Name = "optionsTrayIcon";
			this.optionsTrayIcon.Size = new System.Drawing.Size(202, 22);
			this.optionsTrayIcon.Text = "Always show tray icon";
			this.optionsTrayIcon.Click += new System.EventHandler(this.optionsTrayIcon_Click);
			// 
			// optionsAlert
			// 
			this.optionsAlert.Checked = global::Alarm.Properties.Settings.Default.alertPopup;
			this.optionsAlert.CheckOnClick = true;
			this.optionsAlert.Name = "optionsAlert";
			this.optionsAlert.Size = new System.Drawing.Size(202, 22);
			this.optionsAlert.Text = "Disable alert popup";
			this.optionsAlert.Click += new System.EventHandler(this.optionsAlert_Click);
			// 
			// optionsSoundAlert
			// 
			this.optionsSoundAlert.Checked = global::Alarm.Properties.Settings.Default.soundAlert;
			this.optionsSoundAlert.CheckOnClick = true;
			this.optionsSoundAlert.Name = "optionsSoundAlert";
			this.optionsSoundAlert.Size = new System.Drawing.Size(202, 22);
			this.optionsSoundAlert.Text = "Disable sound alert";
			// 
			// options24Hour
			// 
			this.options24Hour.Checked = global::Alarm.Properties.Settings.Default.hour24Format;
			this.options24Hour.CheckOnClick = true;
			this.options24Hour.Name = "options24Hour";
			this.options24Hour.Size = new System.Drawing.Size(202, 22);
			this.options24Hour.Text = "24-hour clock";
			this.options24Hour.Click += new System.EventHandler(this.options24Hour_Click);
			// 
			// optionsDayMonthYear
			// 
			this.optionsDayMonthYear.Checked = global::Alarm.Properties.Settings.Default.dmyFormat;
			this.optionsDayMonthYear.CheckOnClick = true;
			this.optionsDayMonthYear.Name = "optionsDayMonthYear";
			this.optionsDayMonthYear.Size = new System.Drawing.Size(202, 22);
			this.optionsDayMonthYear.Text = "Day/Month/Year format";
			this.optionsDayMonthYear.Click += new System.EventHandler(this.optionsDayMonthYear_Click);
			// 
			// optionsHideDate
			// 
			this.optionsHideDate.Checked = global::Alarm.Properties.Settings.Default.hideDate;
			this.optionsHideDate.CheckOnClick = true;
			this.optionsHideDate.Name = "optionsHideDate";
			this.optionsHideDate.Size = new System.Drawing.Size(202, 22);
			this.optionsHideDate.Text = "Hide date in statusbar";
			this.optionsHideDate.Click += new System.EventHandler(this.optionsHideDate_Click);
			// 
			// optionsHideTime
			// 
			this.optionsHideTime.Checked = global::Alarm.Properties.Settings.Default.hideTime;
			this.optionsHideTime.CheckOnClick = true;
			this.optionsHideTime.Name = "optionsHideTime";
			this.optionsHideTime.Size = new System.Drawing.Size(202, 22);
			this.optionsHideTime.Text = "Hide time in statusbar";
			this.optionsHideTime.Click += new System.EventHandler(this.optionsHideTime_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 166);
			this.Controls.Add(this.chkContinuous);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.txtMessage);
			this.Controls.Add(this.cmbHour);
			this.Controls.Add(this.cmbMinute);
			this.Controls.Add(this.cmbSecond);
			this.Controls.Add(this.lblSecond);
			this.Controls.Add(this.lblMinute);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.lblHour);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simple Alarm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.trayIconMenu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblHour;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuOptions;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.Label lblMinute;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.ComboBox cmbSecond;
		private System.Windows.Forms.ComboBox cmbMinute;
		private System.Windows.Forms.ComboBox cmbHour;
		private System.Windows.Forms.ToolStripMenuItem fileStart;
		private System.Windows.Forms.ToolStripMenuItem fileStop;
		private System.Windows.Forms.ToolStripSeparator fileSep1;
		private System.Windows.Forms.ToolStripMenuItem fileExit;
		private System.Windows.Forms.ToolStripMenuItem optionsTrayIcon;
		private System.Windows.Forms.ToolStripMenuItem optionsAlert;
		private System.Windows.Forms.ToolStripSeparator optionsSep1;
		private System.Windows.Forms.ToolStripMenuItem options24Hour;
		private System.Windows.Forms.ToolStripMenuItem optionsDayMonthYear;
		private System.Windows.Forms.ToolStripSeparator optionsSep2;
		private System.Windows.Forms.ToolStripMenuItem optionsHideDate;
		private System.Windows.Forms.ToolStripMenuItem optionsHideTime;
		private System.Windows.Forms.ToolStripMenuItem helpAbluescarab;
		private System.Windows.Forms.ToolStripMenuItem helpGithub;
		private System.Windows.Forms.ToolStripSeparator helpSep1;
		private System.Windows.Forms.ToolStripMenuItem helpChangelog;
		private System.Windows.Forms.ToolStripSeparator helpSep2;
		private System.Windows.Forms.ToolStripMenuItem helpHelp;
		private System.Windows.Forms.ToolStripMenuItem helpAbout;
		private System.Windows.Forms.ToolStripStatusLabel statusDate;
		private System.Windows.Forms.ToolStripStatusLabel statusTime;
		private System.Windows.Forms.ToolStripStatusLabel statusAlarmText;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.NotifyIcon trayIcon;
		private System.Windows.Forms.Timer tmrStatusTime;
		private System.Windows.Forms.Timer tmrStatusDate;
		private System.Windows.Forms.Timer tmrAlarm;
		private System.Windows.Forms.ToolStripStatusLabel statusSep1;
		private System.Windows.Forms.ToolStripStatusLabel statusSep2;
		private System.Windows.Forms.ContextMenuStrip trayIconMenu;
		private System.Windows.Forms.ToolStripMenuItem trayShow;
		private System.Windows.Forms.ToolStripSeparator traySep1;
		private System.Windows.Forms.ToolStripMenuItem trayStart;
		private System.Windows.Forms.ToolStripMenuItem trayStop;
		private System.Windows.Forms.ToolStripSeparator traySep2;
		private System.Windows.Forms.ToolStripMenuItem trayExit;
		private System.Windows.Forms.ToolStripStatusLabel statusAlarm;
		private System.Windows.Forms.ToolStripMenuItem optionsSoundAlert;
		private System.Windows.Forms.CheckBox chkContinuous;
	}
}


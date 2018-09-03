namespace sys1_processes_winforms
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.procCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.threadsCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.updatePerControl = new System.Windows.Forms.ToolStripDropDownButton();
			this.sToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dateTimePickerExit = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
			this.textBoxParams = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonSelectFile = new System.Windows.Forms.Button();
			this.textBoxFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStripForList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.completionByTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.contextMenuStripForList.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1067, 554);
			this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.statusStrip1);
			this.tabPage1.Controls.Add(this.listView1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new System.Drawing.Size(1059, 525);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Process List";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.procCountLabel,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.threadsCountLabel,
            this.toolStripStatusLabel4,
            this.updatePerControl});
			this.statusStrip1.Location = new System.Drawing.Point(4, 495);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1051, 26);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 21);
			this.toolStripStatusLabel1.Text = "Processes: ";
			// 
			// procCountLabel
			// 
			this.procCountLabel.Name = "procCountLabel";
			this.procCountLabel.Size = new System.Drawing.Size(17, 21);
			this.procCountLabel.Text = "0";
			// 
			// toolStripStatusLabel2
			// 
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new System.Drawing.Size(25, 21);
			this.toolStripStatusLabel2.Text = "    ";
			// 
			// toolStripStatusLabel3
			// 
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 21);
			this.toolStripStatusLabel3.Text = "Threads: ";
			// 
			// threadsCountLabel
			// 
			this.threadsCountLabel.Name = "threadsCountLabel";
			this.threadsCountLabel.Size = new System.Drawing.Size(17, 21);
			this.threadsCountLabel.Text = "1";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(25, 21);
			this.toolStripStatusLabel4.Text = "    ";
			// 
			// updatePerControl
			// 
			this.updatePerControl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.updatePerControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem4,
            this.sToolStripMenuItem3,
            this.sToolStripMenuItem1,
            this.sToolStripMenuItem,
            this.sToolStripMenuItem2,
            this.offToolStripMenuItem});
			this.updatePerControl.Image = ((System.Drawing.Image)(resources.GetObject("updatePerControl.Image")));
			this.updatePerControl.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.updatePerControl.Name = "updatePerControl";
			this.updatePerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.updatePerControl.Size = new System.Drawing.Size(93, 24);
			this.updatePerControl.Text = "Update: 2s";
			// 
			// sToolStripMenuItem4
			// 
			this.sToolStripMenuItem4.Name = "sToolStripMenuItem4";
			this.sToolStripMenuItem4.Size = new System.Drawing.Size(106, 26);
			this.sToolStripMenuItem4.Text = "30s";
			this.sToolStripMenuItem4.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// sToolStripMenuItem3
			// 
			this.sToolStripMenuItem3.Name = "sToolStripMenuItem3";
			this.sToolStripMenuItem3.Size = new System.Drawing.Size(106, 26);
			this.sToolStripMenuItem3.Text = "10s";
			this.sToolStripMenuItem3.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// sToolStripMenuItem1
			// 
			this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
			this.sToolStripMenuItem1.Size = new System.Drawing.Size(106, 26);
			this.sToolStripMenuItem1.Text = "5s";
			this.sToolStripMenuItem1.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// sToolStripMenuItem
			// 
			this.sToolStripMenuItem.Name = "sToolStripMenuItem";
			this.sToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
			this.sToolStripMenuItem.Text = "2s";
			this.sToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// sToolStripMenuItem2
			// 
			this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
			this.sToolStripMenuItem2.Size = new System.Drawing.Size(106, 26);
			this.sToolStripMenuItem2.Text = "1s";
			this.sToolStripMenuItem2.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// offToolStripMenuItem
			// 
			this.offToolStripMenuItem.Name = "offToolStripMenuItem";
			this.offToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
			this.offToolStripMenuItem.Text = "Off";
			this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
			// 
			// listView1
			// 
			this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listView1.Location = new System.Drawing.Point(4, 4);
			this.listView1.Margin = new System.Windows.Forms.Padding(4);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1051, 496);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.dateTimePickerExit);
			this.tabPage2.Controls.Add(this.dataGridView1);
			this.tabPage2.Controls.Add(this.dateTimePickerStart);
			this.tabPage2.Controls.Add(this.textBoxParams);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.buttonStart);
			this.tabPage2.Controls.Add(this.buttonSelectFile);
			this.tabPage2.Controls.Add(this.textBoxFilePath);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new System.Drawing.Size(1059, 525);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Scheduled Run";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(372, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Completeion time:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Launch time:";
			// 
			// dateTimePickerExit
			// 
			this.dateTimePickerExit.Checked = false;
			this.dateTimePickerExit.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerExit.Location = new System.Drawing.Point(498, 104);
			this.dateTimePickerExit.Name = "dateTimePickerExit";
			this.dateTimePickerExit.ShowCheckBox = true;
			this.dateTimePickerExit.ShowUpDown = true;
			this.dateTimePickerExit.Size = new System.Drawing.Size(200, 22);
			this.dateTimePickerExit.TabIndex = 9;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 301);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1053, 221);
			this.dataGridView1.TabIndex = 8;
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Checked = false;
			this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dateTimePickerStart.Location = new System.Drawing.Point(111, 104);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.ShowCheckBox = true;
			this.dateTimePickerStart.ShowUpDown = true;
			this.dateTimePickerStart.Size = new System.Drawing.Size(200, 22);
			this.dateTimePickerStart.TabIndex = 6;
			// 
			// textBoxParams
			// 
			this.textBoxParams.Location = new System.Drawing.Point(111, 60);
			this.textBoxParams.Name = "textBoxParams";
			this.textBoxParams.Size = new System.Drawing.Size(587, 22);
			this.textBoxParams.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(20, 63);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Parameters:";
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(111, 186);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(139, 37);
			this.buttonStart.TabIndex = 3;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonSelectFile
			// 
			this.buttonSelectFile.Location = new System.Drawing.Point(704, 21);
			this.buttonSelectFile.Name = "buttonSelectFile";
			this.buttonSelectFile.Size = new System.Drawing.Size(80, 28);
			this.buttonSelectFile.TabIndex = 2;
			this.buttonSelectFile.Text = "Select";
			this.buttonSelectFile.UseVisualStyleBackColor = true;
			this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
			// 
			// textBoxFilePath
			// 
			this.textBoxFilePath.Location = new System.Drawing.Point(111, 24);
			this.textBoxFilePath.Name = "textBoxFilePath";
			this.textBoxFilePath.Size = new System.Drawing.Size(587, 22);
			this.textBoxFilePath.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "File to launch:";
			// 
			// notifyIcon1
			// 
			this.notifyIcon1.BalloonTipText = "Hi";
			this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
			this.notifyIcon1.Text = "Scheduled Run";
			this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
			// 
			// contextMenuStripForList
			// 
			this.contextMenuStripForList.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStripForList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem,
            this.completionByTimeToolStripMenuItem});
			this.contextMenuStripForList.Name = "contextMenuStripForList";
			this.contextMenuStripForList.Size = new System.Drawing.Size(220, 52);
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.refreshToolStripMenuItem.Text = "Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// completionByTimeToolStripMenuItem
			// 
			this.completionByTimeToolStripMenuItem.Name = "completionByTimeToolStripMenuItem";
			this.completionByTimeToolStripMenuItem.Size = new System.Drawing.Size(219, 24);
			this.completionByTimeToolStripMenuItem.Text = "Completion by time...";
			this.completionByTimeToolStripMenuItem.Click += new System.EventHandler(this.completionByTimeToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.Text = "Task Manager";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.contextMenuStripForList.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button buttonSelectFile;
		private System.Windows.Forms.TextBox textBoxFilePath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.TextBox textBoxParams;
		private System.Windows.Forms.NotifyIcon notifyIcon1;
		private System.Windows.Forms.DateTimePicker dateTimePickerStart;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripForList;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem completionByTimeToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel procCountLabel;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
		private System.Windows.Forms.ToolStripStatusLabel threadsCountLabel;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripDropDownButton updatePerControl;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dateTimePickerExit;
	}
}


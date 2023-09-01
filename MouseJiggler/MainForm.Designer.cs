
namespace ArkaneSystems.MouseJiggler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            jiggleTimer = new System.Windows.Forms.Timer(components);
            flpLayout = new System.Windows.Forms.FlowLayoutPanel();
            panelBase = new System.Windows.Forms.Panel();
            cmdAbout = new System.Windows.Forms.Button();
            cmdTrayify = new System.Windows.Forms.Button();
            cbSettings = new System.Windows.Forms.CheckBox();
            cbJiggling = new System.Windows.Forms.CheckBox();
            panelSettings = new System.Windows.Forms.Panel();
            lbPeriod = new System.Windows.Forms.Label();
            tbPeriod = new System.Windows.Forms.TrackBar();
            cbMinimize = new System.Windows.Forms.CheckBox();
            cbZen = new System.Windows.Forms.CheckBox();
            panelWeekday = new System.Windows.Forms.Panel();
            sun = new System.Windows.Forms.CheckBox();
            sat = new System.Windows.Forms.CheckBox();
            fri = new System.Windows.Forms.CheckBox();
            thu = new System.Windows.Forms.CheckBox();
            wed = new System.Windows.Forms.CheckBox();
            tue = new System.Windows.Forms.CheckBox();
            mon = new System.Windows.Forms.CheckBox();
            to = new System.Windows.Forms.NumericUpDown();
            from = new System.Windows.Forms.NumericUpDown();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            niTray = new System.Windows.Forms.NotifyIcon(components);
            flpLayout.SuspendLayout();
            panelBase.SuspendLayout();
            panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).BeginInit();
            panelWeekday.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)to).BeginInit();
            ((System.ComponentModel.ISupportInitialize)from).BeginInit();
            SuspendLayout();
            // 
            // jiggleTimer
            // 
            jiggleTimer.Interval = 1000;
            jiggleTimer.Tick += jiggleTimer_Tick;
            // 
            // flpLayout
            // 
            flpLayout.AutoSize = true;
            flpLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flpLayout.Controls.Add(panelBase);
            flpLayout.Controls.Add(panelSettings);
            flpLayout.Controls.Add(panelWeekday);
            flpLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            flpLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flpLayout.Location = new System.Drawing.Point(0, 0);
            flpLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            flpLayout.Name = "flpLayout";
            flpLayout.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            flpLayout.Size = new System.Drawing.Size(349, 343);
            flpLayout.TabIndex = 2;
            // 
            // panelBase
            // 
            panelBase.Controls.Add(cmdAbout);
            panelBase.Controls.Add(cmdTrayify);
            panelBase.Controls.Add(cbSettings);
            panelBase.Controls.Add(cbJiggling);
            panelBase.Location = new System.Drawing.Point(9, 11);
            panelBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelBase.Name = "panelBase";
            panelBase.Size = new System.Drawing.Size(330, 37);
            panelBase.TabIndex = 3;
            // 
            // cmdAbout
            // 
            cmdAbout.Location = new System.Drawing.Point(226, 3);
            cmdAbout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmdAbout.Name = "cmdAbout";
            cmdAbout.Size = new System.Drawing.Size(46, 31);
            cmdAbout.TabIndex = 2;
            cmdAbout.Text = "?";
            cmdAbout.UseVisualStyleBackColor = true;
            cmdAbout.Click += cmdAbout_Click;
            // 
            // cmdTrayify
            // 
            cmdTrayify.Location = new System.Drawing.Point(279, 3);
            cmdTrayify.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmdTrayify.Name = "cmdTrayify";
            cmdTrayify.Size = new System.Drawing.Size(46, 31);
            cmdTrayify.TabIndex = 3;
            cmdTrayify.Text = "🔽";
            cmdTrayify.UseVisualStyleBackColor = true;
            cmdTrayify.Click += cmdTrayify_Click;
            // 
            // cbSettings
            // 
            cbSettings.Location = new System.Drawing.Point(101, 7);
            cbSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbSettings.Name = "cbSettings";
            cbSettings.Size = new System.Drawing.Size(88, 25);
            cbSettings.TabIndex = 1;
            cbSettings.Text = "Settings...";
            cbSettings.UseVisualStyleBackColor = true;
            cbSettings.CheckedChanged += cbSettings_CheckedChanged;
            // 
            // cbJiggling
            // 
            cbJiggling.AutoSize = true;
            cbJiggling.Location = new System.Drawing.Point(11, 7);
            cbJiggling.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbJiggling.Name = "cbJiggling";
            cbJiggling.Size = new System.Drawing.Size(90, 24);
            cbJiggling.TabIndex = 0;
            cbJiggling.Text = "Jiggling?";
            cbJiggling.UseVisualStyleBackColor = true;
            cbJiggling.CheckedChanged += cbJiggling_CheckedChanged;
            // 
            // panelSettings
            // 
            panelSettings.AutoSize = true;
            panelSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panelSettings.Controls.Add(lbPeriod);
            panelSettings.Controls.Add(tbPeriod);
            panelSettings.Controls.Add(cbMinimize);
            panelSettings.Controls.Add(cbZen);
            panelSettings.Location = new System.Drawing.Point(9, 56);
            panelSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panelSettings.Name = "panelSettings";
            panelSettings.Size = new System.Drawing.Size(330, 143);
            panelSettings.TabIndex = 2;
            panelSettings.Visible = false;
            // 
            // lbPeriod
            // 
            lbPeriod.AutoSize = true;
            lbPeriod.Location = new System.Drawing.Point(279, 55);
            lbPeriod.Name = "lbPeriod";
            lbPeriod.Size = new System.Drawing.Size(27, 20);
            lbPeriod.TabIndex = 3;
            lbPeriod.Text = "1 s";
            // 
            // tbPeriod
            // 
            tbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPeriod.Location = new System.Drawing.Point(5, 83);
            tbPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tbPeriod.Maximum = 60;
            tbPeriod.Minimum = 1;
            tbPeriod.Name = "tbPeriod";
            tbPeriod.Size = new System.Drawing.Size(321, 56);
            tbPeriod.TabIndex = 6;
            tbPeriod.TickFrequency = 2;
            tbPeriod.Value = 1;
            tbPeriod.ValueChanged += tbPeriod_ValueChanged;
            // 
            // cbMinimize
            // 
            cbMinimize.AutoSize = true;
            cbMinimize.Location = new System.Drawing.Point(11, 49);
            cbMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbMinimize.Name = "cbMinimize";
            cbMinimize.Size = new System.Drawing.Size(153, 24);
            cbMinimize.TabIndex = 5;
            cbMinimize.Text = "Minimize on start?";
            cbMinimize.UseVisualStyleBackColor = true;
            cbMinimize.CheckedChanged += cbMinimize_CheckedChanged;
            // 
            // cbZen
            // 
            cbZen.AutoSize = true;
            cbZen.Location = new System.Drawing.Point(11, 15);
            cbZen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cbZen.Name = "cbZen";
            cbZen.Size = new System.Drawing.Size(105, 24);
            cbZen.TabIndex = 4;
            cbZen.Text = "Zen jiggle?";
            cbZen.UseVisualStyleBackColor = true;
            cbZen.CheckedChanged += cbZen_CheckedChanged;
            // 
            // panelWeekday
            // 
            panelWeekday.Controls.Add(sun);
            panelWeekday.Controls.Add(sat);
            panelWeekday.Controls.Add(fri);
            panelWeekday.Controls.Add(thu);
            panelWeekday.Controls.Add(wed);
            panelWeekday.Controls.Add(tue);
            panelWeekday.Controls.Add(mon);
            panelWeekday.Controls.Add(to);
            panelWeekday.Controls.Add(from);
            panelWeekday.Controls.Add(label2);
            panelWeekday.Controls.Add(label1);
            panelWeekday.Location = new System.Drawing.Point(9, 206);
            panelWeekday.Name = "panelWeekday";
            panelWeekday.Size = new System.Drawing.Size(330, 125);
            panelWeekday.TabIndex = 4;
            panelWeekday.Visible = false;
            // 
            // sun
            // 
            sun.AutoSize = true;
            sun.Location = new System.Drawing.Point(145, 86);
            sun.Name = "sun";
            sun.Size = new System.Drawing.Size(55, 24);
            sun.TabIndex = 10;
            sun.Text = "Sun";
            sun.UseVisualStyleBackColor = true;
            // 
            // sat
            // 
            sat.AutoSize = true;
            sat.Location = new System.Drawing.Point(78, 86);
            sat.Name = "sat";
            sat.Size = new System.Drawing.Size(52, 24);
            sat.TabIndex = 9;
            sat.Text = "Sat";
            sat.UseVisualStyleBackColor = true;
            // 
            // fri
            // 
            fri.AutoSize = true;
            fri.Location = new System.Drawing.Point(11, 86);
            fri.Name = "fri";
            fri.Size = new System.Drawing.Size(47, 24);
            fri.TabIndex = 8;
            fri.Text = "Fri";
            fri.UseVisualStyleBackColor = true;
            // 
            // thu
            // 
            thu.AutoSize = true;
            thu.Location = new System.Drawing.Point(212, 56);
            thu.Name = "thu";
            thu.Size = new System.Drawing.Size(55, 24);
            thu.TabIndex = 7;
            thu.Text = "Thu";
            thu.UseVisualStyleBackColor = true;
            // 
            // wed
            // 
            wed.AutoSize = true;
            wed.Location = new System.Drawing.Point(145, 56);
            wed.Name = "wed";
            wed.Size = new System.Drawing.Size(61, 24);
            wed.TabIndex = 6;
            wed.Text = "Wed";
            wed.UseVisualStyleBackColor = true;
            // 
            // tue
            // 
            tue.AutoSize = true;
            tue.Location = new System.Drawing.Point(78, 56);
            tue.Name = "tue";
            tue.Size = new System.Drawing.Size(55, 24);
            tue.TabIndex = 5;
            tue.Text = "Tue";
            tue.UseVisualStyleBackColor = true;
            // 
            // mon
            // 
            mon.AutoSize = true;
            mon.Location = new System.Drawing.Point(11, 56);
            mon.Name = "mon";
            mon.Size = new System.Drawing.Size(61, 24);
            mon.TabIndex = 4;
            mon.Text = "Mon";
            mon.UseVisualStyleBackColor = true;
            // 
            // to
            // 
            to.Location = new System.Drawing.Point(195, 16);
            to.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            to.Name = "to";
            to.Size = new System.Drawing.Size(48, 27);
            to.TabIndex = 3;
            to.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // from
            // 
            from.Location = new System.Drawing.Point(59, 16);
            from.Maximum = new decimal(new int[] { 23, 0, 0, 0 });
            from.Name = "from";
            from.Size = new System.Drawing.Size(46, 27);
            from.TabIndex = 2;
            from.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(164, 18);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 20);
            label2.TabIndex = 1;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(43, 20);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // niTray
            // 
            niTray.Icon = (System.Drawing.Icon)resources.GetObject("niTray.Icon");
            niTray.Text = "Mouse Jiggler";
            niTray.DoubleClick += niTray_DoubleClick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(349, 343);
            Controls.Add(flpLayout);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            Text = "Mouse Jiggler";
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            flpLayout.ResumeLayout(false);
            flpLayout.PerformLayout();
            panelBase.ResumeLayout(false);
            panelBase.PerformLayout();
            panelSettings.ResumeLayout(false);
            panelSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbPeriod).EndInit();
            panelWeekday.ResumeLayout(false);
            panelWeekday.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)to).EndInit();
            ((System.ComponentModel.ISupportInitialize)from).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer jiggleTimer;
        private System.Windows.Forms.FlowLayoutPanel flpLayout;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.TrackBar tbPeriod;
        private System.Windows.Forms.CheckBox cbMinimize;
        private System.Windows.Forms.CheckBox cbZen;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.CheckBox cbSettings;
        private System.Windows.Forms.CheckBox cbJiggling;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Button cmdAbout;
        private System.Windows.Forms.NotifyIcon niTray;
        private System.Windows.Forms.Button cmdTrayify;
        private System.Windows.Forms.Panel panelWeekday;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox sun;
        private System.Windows.Forms.CheckBox sat;
        private System.Windows.Forms.CheckBox fri;
        private System.Windows.Forms.CheckBox thu;
        private System.Windows.Forms.CheckBox wed;
        private System.Windows.Forms.CheckBox tue;
        private System.Windows.Forms.CheckBox mon;
        private System.Windows.Forms.NumericUpDown to;
        private System.Windows.Forms.NumericUpDown from;
    }
}


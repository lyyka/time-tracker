namespace TimeTracker
{
    partial class Main
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
            this.desc_tb = new System.Windows.Forms.TextBox();
            this.toggleTimer_btn = new System.Windows.Forms.Button();
            this.projects_cb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeForm_pb = new System.Windows.Forms.PictureBox();
            this.earnings_pb = new System.Windows.Forms.PictureBox();
            this.charts_pb = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settings_pb = new System.Windows.Forms.PictureBox();
            this.project_pb = new System.Windows.Forms.PictureBox();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.currentTime_lb = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.entryEarnings_lb = new System.Windows.Forms.Label();
            this.entriesWrap_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeForm_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earnings_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.charts_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.panel2.SuspendLayout();
            this.systemTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // desc_tb
            // 
            this.desc_tb.Location = new System.Drawing.Point(6, 28);
            this.desc_tb.MaxLength = 50;
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(343, 20);
            this.desc_tb.TabIndex = 1;
            // 
            // toggleTimer_btn
            // 
            this.toggleTimer_btn.Location = new System.Drawing.Point(6, 54);
            this.toggleTimer_btn.Name = "toggleTimer_btn";
            this.toggleTimer_btn.Size = new System.Drawing.Size(95, 32);
            this.toggleTimer_btn.TabIndex = 2;
            this.toggleTimer_btn.Text = "Start Timer";
            this.toggleTimer_btn.UseVisualStyleBackColor = true;
            this.toggleTimer_btn.Click += new System.EventHandler(this.toggleTimer_btn_Click);
            // 
            // projects_cb
            // 
            this.projects_cb.FormattingEnabled = true;
            this.projects_cb.Location = new System.Drawing.Point(366, 27);
            this.projects_cb.Name = "projects_cb";
            this.projects_cb.Size = new System.Drawing.Size(121, 21);
            this.projects_cb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What are you working on?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.closeForm_pb);
            this.panel1.Controls.Add(this.earnings_pb);
            this.panel1.Controls.Add(this.charts_pb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.settings_pb);
            this.panel1.Controls.Add(this.project_pb);
            this.panel1.Controls.Add(this.logo_pb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 566);
            this.panel1.TabIndex = 6;
            // 
            // closeForm_pb
            // 
            this.closeForm_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeForm_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeForm_pb.Location = new System.Drawing.Point(33, 522);
            this.closeForm_pb.Name = "closeForm_pb";
            this.closeForm_pb.Size = new System.Drawing.Size(32, 32);
            this.closeForm_pb.TabIndex = 6;
            this.closeForm_pb.TabStop = false;
            this.closeForm_pb.Click += new System.EventHandler(this.closeForm_pb_Click);
            // 
            // earnings_pb
            // 
            this.earnings_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.earnings_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.earnings_pb.Location = new System.Drawing.Point(33, 267);
            this.earnings_pb.Name = "earnings_pb";
            this.earnings_pb.Size = new System.Drawing.Size(32, 32);
            this.earnings_pb.TabIndex = 5;
            this.earnings_pb.TabStop = false;
            this.earnings_pb.Click += new System.EventHandler(this.earnings_pb_Click);
            // 
            // charts_pb
            // 
            this.charts_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.charts_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.charts_pb.Location = new System.Drawing.Point(33, 213);
            this.charts_pb.Name = "charts_pb";
            this.charts_pb.Size = new System.Drawing.Size(32, 32);
            this.charts_pb.TabIndex = 4;
            this.charts_pb.TabStop = false;
            this.charts_pb.Click += new System.EventHandler(this.charts_pb_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 2);
            this.label3.TabIndex = 3;
            // 
            // settings_pb
            // 
            this.settings_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settings_pb.Location = new System.Drawing.Point(33, 107);
            this.settings_pb.Name = "settings_pb";
            this.settings_pb.Size = new System.Drawing.Size(32, 32);
            this.settings_pb.TabIndex = 1;
            this.settings_pb.TabStop = false;
            this.settings_pb.Click += new System.EventHandler(this.settings_pb_Click);
            // 
            // project_pb
            // 
            this.project_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.project_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.project_pb.Location = new System.Drawing.Point(33, 160);
            this.project_pb.Name = "project_pb";
            this.project_pb.Size = new System.Drawing.Size(32, 32);
            this.project_pb.TabIndex = 2;
            this.project_pb.TabStop = false;
            this.project_pb.Click += new System.EventHandler(this.project_pb_Click);
            // 
            // logo_pb
            // 
            this.logo_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo_pb.Location = new System.Drawing.Point(16, 14);
            this.logo_pb.Name = "logo_pb";
            this.logo_pb.Size = new System.Drawing.Size(64, 64);
            this.logo_pb.TabIndex = 0;
            this.logo_pb.TabStop = false;
            // 
            // currentTime_lb
            // 
            this.currentTime_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTime_lb.AutoSize = true;
            this.currentTime_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime_lb.Location = new System.Drawing.Point(605, 14);
            this.currentTime_lb.Name = "currentTime_lb";
            this.currentTime_lb.Size = new System.Drawing.Size(149, 39);
            this.currentTime_lb.TabIndex = 8;
            this.currentTime_lb.Text = "00:00:00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // entryEarnings_lb
            // 
            this.entryEarnings_lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.entryEarnings_lb.AutoSize = true;
            this.entryEarnings_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entryEarnings_lb.Location = new System.Drawing.Point(609, 53);
            this.entryEarnings_lb.Name = "entryEarnings_lb";
            this.entryEarnings_lb.Size = new System.Drawing.Size(31, 15);
            this.entryEarnings_lb.TabIndex = 9;
            this.entryEarnings_lb.Text = "0.00";
            // 
            // entriesWrap_panel
            // 
            this.entriesWrap_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entriesWrap_panel.AutoScroll = true;
            this.entriesWrap_panel.BackColor = System.Drawing.Color.White;
            this.entriesWrap_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.entriesWrap_panel.Location = new System.Drawing.Point(99, 91);
            this.entriesWrap_panel.Name = "entriesWrap_panel";
            this.entriesWrap_panel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.entriesWrap_panel.Size = new System.Drawing.Size(774, 475);
            this.entriesWrap_panel.TabIndex = 0;
            this.entriesWrap_panel.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.entryEarnings_lb);
            this.panel2.Controls.Add(this.desc_tb);
            this.panel2.Controls.Add(this.currentTime_lb);
            this.panel2.Controls.Add(this.toggleTimer_btn);
            this.panel2.Controls.Add(this.projects_cb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(99, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 93);
            this.panel2.TabIndex = 0;
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.ContextMenuStrip = this.systemTrayMenu;
            this.systemTrayIcon.Text = "Time Tracker - Tray";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.systemTrayIcon_MouseDoubleClick);
            // 
            // systemTrayMenu
            // 
            this.systemTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.systemTrayMenu.Name = "systemTrayMenu";
            this.systemTrayMenu.Size = new System.Drawing.Size(94, 26);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 566);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entriesWrap_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(846, 566);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeForm_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earnings_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.charts_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.systemTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Button toggleTimer_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox settings_pb;
        private System.Windows.Forms.Label currentTime_lb;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox project_pb;
        private System.Windows.Forms.ComboBox projects_cb;
        private System.Windows.Forms.Label entryEarnings_lb;
        private System.Windows.Forms.FlowLayoutPanel entriesWrap_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox charts_pb;
        private System.Windows.Forms.PictureBox earnings_pb;
        private System.Windows.Forms.PictureBox closeForm_pb;
        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip systemTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
    }
}


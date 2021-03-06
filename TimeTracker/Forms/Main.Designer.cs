﻿namespace TimeTracker
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contacts_pb = new System.Windows.Forms.PictureBox();
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
            this.label7 = new System.Windows.Forms.Label();
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.systemTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFilter_DTP = new System.Windows.Forms.DateTimePicker();
            this.toFilter_DTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.projectFilter_cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.filter_btn = new System.Windows.Forms.Button();
            this.resetFilter_btn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.playPause_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contacts_pb)).BeginInit();
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
            this.projects_cb.Size = new System.Drawing.Size(200, 21);
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
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.contacts_pb);
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
            this.panel1.Size = new System.Drawing.Size(99, 665);
            this.panel1.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 404);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 18);
            this.label13.TabIndex = 12;
            this.label13.Text = "Contacts";
            this.label13.Click += new System.EventHandler(this.contacts_pb_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 341);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 18);
            this.label12.TabIndex = 11;
            this.label12.Text = "Earnings";
            this.label12.Click += new System.EventHandler(this.earnings_pb_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hours";
            this.label11.Click += new System.EventHandler(this.charts_pb_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 9;
            this.label10.Text = "Projects";
            this.label10.Click += new System.EventHandler(this.project_pb_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Settings";
            this.label9.Click += new System.EventHandler(this.settings_pb_Click);
            // 
            // contacts_pb
            // 
            this.contacts_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.contacts_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contacts_pb.Location = new System.Drawing.Point(33, 369);
            this.contacts_pb.Name = "contacts_pb";
            this.contacts_pb.Size = new System.Drawing.Size(32, 32);
            this.contacts_pb.TabIndex = 7;
            this.contacts_pb.TabStop = false;
            this.contacts_pb.Click += new System.EventHandler(this.contacts_pb_Click);
            // 
            // closeForm_pb
            // 
            this.closeForm_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeForm_pb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeForm_pb.Location = new System.Drawing.Point(33, 602);
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
            this.earnings_pb.Location = new System.Drawing.Point(33, 306);
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
            this.charts_pb.Location = new System.Drawing.Point(33, 243);
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
            this.project_pb.Location = new System.Drawing.Point(33, 180);
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
            this.currentTime_lb.Location = new System.Drawing.Point(655, 14);
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
            this.entryEarnings_lb.Location = new System.Drawing.Point(659, 53);
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
            this.entriesWrap_panel.Location = new System.Drawing.Point(99, 152);
            this.entriesWrap_panel.Name = "entriesWrap_panel";
            this.entriesWrap_panel.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.entriesWrap_panel.Size = new System.Drawing.Size(824, 513);
            this.entriesWrap_panel.TabIndex = 0;
            this.entriesWrap_panel.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.playPause_btn);
            this.panel2.Controls.Add(this.label7);
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
            this.panel2.Size = new System.Drawing.Size(824, 93);
            this.panel2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(0, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(900, 2);
            this.label7.TabIndex = 7;
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
            // fromFilter_DTP
            // 
            this.fromFilter_DTP.Location = new System.Drawing.Point(105, 119);
            this.fromFilter_DTP.Name = "fromFilter_DTP";
            this.fromFilter_DTP.Size = new System.Drawing.Size(200, 20);
            this.fromFilter_DTP.TabIndex = 7;
            // 
            // toFilter_DTP
            // 
            this.toFilter_DTP.Location = new System.Drawing.Point(323, 119);
            this.toFilter_DTP.Name = "toFilter_DTP";
            this.toFilter_DTP.Size = new System.Drawing.Size(200, 20);
            this.toFilter_DTP.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "To:";
            // 
            // projectFilter_cb
            // 
            this.projectFilter_cb.FormattingEnabled = true;
            this.projectFilter_cb.Location = new System.Drawing.Point(541, 118);
            this.projectFilter_cb.Name = "projectFilter_cb";
            this.projectFilter_cb.Size = new System.Drawing.Size(150, 21);
            this.projectFilter_cb.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(538, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Narrow to project:";
            // 
            // filter_btn
            // 
            this.filter_btn.Location = new System.Drawing.Point(730, 116);
            this.filter_btn.Name = "filter_btn";
            this.filter_btn.Size = new System.Drawing.Size(75, 23);
            this.filter_btn.TabIndex = 12;
            this.filter_btn.Text = "Filter";
            this.filter_btn.UseVisualStyleBackColor = true;
            this.filter_btn.Click += new System.EventHandler(this.filter_btn_Click);
            // 
            // resetFilter_btn
            // 
            this.resetFilter_btn.Location = new System.Drawing.Point(828, 116);
            this.resetFilter_btn.Name = "resetFilter_btn";
            this.resetFilter_btn.Size = new System.Drawing.Size(75, 23);
            this.resetFilter_btn.TabIndex = 13;
            this.resetFilter_btn.Text = "Reset";
            this.resetFilter_btn.UseVisualStyleBackColor = true;
            this.resetFilter_btn.Click += new System.EventHandler(this.resetFilter_btn_Click);
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(99, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(824, 2);
            this.label8.TabIndex = 10;
            // 
            // playPause_btn
            // 
            this.playPause_btn.Enabled = false;
            this.playPause_btn.Location = new System.Drawing.Point(120, 54);
            this.playPause_btn.Name = "playPause_btn";
            this.playPause_btn.Size = new System.Drawing.Size(95, 32);
            this.playPause_btn.TabIndex = 10;
            this.playPause_btn.Text = "PAUSE";
            this.playPause_btn.UseVisualStyleBackColor = true;
            this.playPause_btn.Click += new System.EventHandler(this.playPause_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(923, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.resetFilter_btn);
            this.Controls.Add(this.filter_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.projectFilter_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toFilter_DTP);
            this.Controls.Add(this.fromFilter_DTP);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.entriesWrap_panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(846, 566);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contacts_pb)).EndInit();
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
            this.PerformLayout();

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
        private System.Windows.Forms.DateTimePicker fromFilter_DTP;
        private System.Windows.Forms.DateTimePicker toFilter_DTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox projectFilter_cb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button filter_btn;
        private System.Windows.Forms.Button resetFilter_btn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox contacts_pb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button playPause_btn;
    }
}


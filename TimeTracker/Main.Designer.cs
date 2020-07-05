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
            this.settings_pb = new System.Windows.Forms.PictureBox();
            this.logo_pb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.currentTime_lb = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // desc_tb
            // 
            this.desc_tb.Location = new System.Drawing.Point(113, 28);
            this.desc_tb.Name = "desc_tb";
            this.desc_tb.Size = new System.Drawing.Size(343, 20);
            this.desc_tb.TabIndex = 1;
            // 
            // toggleTimer_btn
            // 
            this.toggleTimer_btn.Location = new System.Drawing.Point(113, 54);
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
            this.projects_cb.Location = new System.Drawing.Point(473, 27);
            this.projects_cb.Name = "projects_cb";
            this.projects_cb.Size = new System.Drawing.Size(121, 21);
            this.projects_cb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "What are you working on?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.settings_pb);
            this.panel1.Controls.Add(this.logo_pb);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(99, 530);
            this.panel1.TabIndex = 6;
            // 
            // settings_pb
            // 
            this.settings_pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings_pb.Location = new System.Drawing.Point(31, 106);
            this.settings_pb.Name = "settings_pb";
            this.settings_pb.Size = new System.Drawing.Size(32, 32);
            this.settings_pb.TabIndex = 1;
            this.settings_pb.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(95, 104);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 424);
            this.panel2.TabIndex = 7;
            // 
            // currentTime_lb
            // 
            this.currentTime_lb.AutoSize = true;
            this.currentTime_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTime_lb.Location = new System.Drawing.Point(639, 27);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.currentTime_lb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.projects_cb);
            this.Controls.Add(this.toggleTimer_btn);
            this.Controls.Add(this.desc_tb);
            this.Name = "Main";
            this.Text = "Time Tracker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.settings_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo_pb;
        private System.Windows.Forms.TextBox desc_tb;
        private System.Windows.Forms.Button toggleTimer_btn;
        private System.Windows.Forms.ComboBox projects_cb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox settings_pb;
        private System.Windows.Forms.Label currentTime_lb;
        private System.Windows.Forms.Timer timer;
    }
}


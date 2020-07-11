namespace TimeTracker
{
    partial class ProjectsManagement
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
            this.projects_listbox = new System.Windows.Forms.ListBox();
            this.addProject_btn = new System.Windows.Forms.Button();
            this.displayProject_panel = new System.Windows.Forms.Panel();
            this.displayCurrency_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.displayHourlyRate_nud = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.displayDeleteProject_btn = new System.Windows.Forms.Button();
            this.displayUpdateProject_btn = new System.Windows.Forms.Button();
            this.displayCreatedAt_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayProjectName_tb = new System.Windows.Forms.TextBox();
            this.newProjectName_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayProject_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayHourlyRate_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // projects_listbox
            // 
            this.projects_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projects_listbox.FormattingEnabled = true;
            this.projects_listbox.Location = new System.Drawing.Point(12, 51);
            this.projects_listbox.Name = "projects_listbox";
            this.projects_listbox.Size = new System.Drawing.Size(309, 264);
            this.projects_listbox.TabIndex = 0;
            this.projects_listbox.SelectedIndexChanged += new System.EventHandler(this.projects_listbox_SelectedIndexChanged);
            // 
            // addProject_btn
            // 
            this.addProject_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addProject_btn.Location = new System.Drawing.Point(196, 23);
            this.addProject_btn.Name = "addProject_btn";
            this.addProject_btn.Size = new System.Drawing.Size(125, 23);
            this.addProject_btn.TabIndex = 1;
            this.addProject_btn.Text = "Add New Project";
            this.addProject_btn.UseVisualStyleBackColor = true;
            this.addProject_btn.Click += new System.EventHandler(this.addProject_btn_Click);
            // 
            // displayProject_panel
            // 
            this.displayProject_panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.displayProject_panel.Controls.Add(this.displayCurrency_tb);
            this.displayProject_panel.Controls.Add(this.label5);
            this.displayProject_panel.Controls.Add(this.displayHourlyRate_nud);
            this.displayProject_panel.Controls.Add(this.label4);
            this.displayProject_panel.Controls.Add(this.displayDeleteProject_btn);
            this.displayProject_panel.Controls.Add(this.displayUpdateProject_btn);
            this.displayProject_panel.Controls.Add(this.displayCreatedAt_lb);
            this.displayProject_panel.Controls.Add(this.label3);
            this.displayProject_panel.Controls.Add(this.label2);
            this.displayProject_panel.Controls.Add(this.displayProjectName_tb);
            this.displayProject_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.displayProject_panel.Location = new System.Drawing.Point(334, 0);
            this.displayProject_panel.Name = "displayProject_panel";
            this.displayProject_panel.Size = new System.Drawing.Size(294, 330);
            this.displayProject_panel.TabIndex = 2;
            // 
            // displayCurrency_tb
            // 
            this.displayCurrency_tb.Location = new System.Drawing.Point(163, 89);
            this.displayCurrency_tb.MaxLength = 50;
            this.displayCurrency_tb.Name = "displayCurrency_tb";
            this.displayCurrency_tb.Size = new System.Drawing.Size(115, 20);
            this.displayCurrency_tb.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Specific currency";
            // 
            // displayHourlyRate_nud
            // 
            this.displayHourlyRate_nud.Location = new System.Drawing.Point(17, 89);
            this.displayHourlyRate_nud.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.displayHourlyRate_nud.Name = "displayHourlyRate_nud";
            this.displayHourlyRate_nud.Size = new System.Drawing.Size(120, 20);
            this.displayHourlyRate_nud.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Specific hourly rate";
            // 
            // displayDeleteProject_btn
            // 
            this.displayDeleteProject_btn.Location = new System.Drawing.Point(111, 127);
            this.displayDeleteProject_btn.Name = "displayDeleteProject_btn";
            this.displayDeleteProject_btn.Size = new System.Drawing.Size(75, 22);
            this.displayDeleteProject_btn.TabIndex = 5;
            this.displayDeleteProject_btn.Text = "Delete";
            this.displayDeleteProject_btn.UseVisualStyleBackColor = true;
            this.displayDeleteProject_btn.Click += new System.EventHandler(this.displayDeleteProject_btn_Click);
            // 
            // displayUpdateProject_btn
            // 
            this.displayUpdateProject_btn.Location = new System.Drawing.Point(17, 127);
            this.displayUpdateProject_btn.Name = "displayUpdateProject_btn";
            this.displayUpdateProject_btn.Size = new System.Drawing.Size(75, 22);
            this.displayUpdateProject_btn.TabIndex = 4;
            this.displayUpdateProject_btn.Text = "Update";
            this.displayUpdateProject_btn.UseVisualStyleBackColor = true;
            this.displayUpdateProject_btn.Click += new System.EventHandler(this.displayUpdateProject_btn_Click);
            // 
            // displayCreatedAt_lb
            // 
            this.displayCreatedAt_lb.AutoSize = true;
            this.displayCreatedAt_lb.Location = new System.Drawing.Point(161, 43);
            this.displayCreatedAt_lb.Name = "displayCreatedAt_lb";
            this.displayCreatedAt_lb.Size = new System.Drawing.Size(35, 13);
            this.displayCreatedAt_lb.TabIndex = 3;
            this.displayCreatedAt_lb.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Created at:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project name:";
            // 
            // displayProjectName_tb
            // 
            this.displayProjectName_tb.Location = new System.Drawing.Point(17, 40);
            this.displayProjectName_tb.MaxLength = 50;
            this.displayProjectName_tb.Name = "displayProjectName_tb";
            this.displayProjectName_tb.Size = new System.Drawing.Size(128, 20);
            this.displayProjectName_tb.TabIndex = 0;
            // 
            // newProjectName_tb
            // 
            this.newProjectName_tb.Location = new System.Drawing.Point(12, 25);
            this.newProjectName_tb.MaxLength = 50;
            this.newProjectName_tb.Name = "newProjectName_tb";
            this.newProjectName_tb.Size = new System.Drawing.Size(178, 20);
            this.newProjectName_tb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "New project name:";
            // 
            // ProjectsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProjectName_tb);
            this.Controls.Add(this.displayProject_panel);
            this.Controls.Add(this.addProject_btn);
            this.Controls.Add(this.projects_listbox);
            this.Name = "ProjectsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Projects";
            this.Load += new System.EventHandler(this.ProjectsManagement_Load);
            this.displayProject_panel.ResumeLayout(false);
            this.displayProject_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.displayHourlyRate_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projects_listbox;
        private System.Windows.Forms.Button addProject_btn;
        private System.Windows.Forms.Panel displayProject_panel;
        private System.Windows.Forms.TextBox newProjectName_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label displayCreatedAt_lb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayProjectName_tb;
        private System.Windows.Forms.Button displayDeleteProject_btn;
        private System.Windows.Forms.Button displayUpdateProject_btn;
        private System.Windows.Forms.NumericUpDown displayHourlyRate_nud;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox displayCurrency_tb;
        private System.Windows.Forms.Label label5;
    }
}
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
            this.newProjectName_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // projects_listbox
            // 
            this.projects_listbox.FormattingEnabled = true;
            this.projects_listbox.Location = new System.Drawing.Point(12, 51);
            this.projects_listbox.Name = "projects_listbox";
            this.projects_listbox.Size = new System.Drawing.Size(309, 264);
            this.projects_listbox.TabIndex = 0;
            this.projects_listbox.SelectedIndexChanged += new System.EventHandler(this.projects_listbox_SelectedIndexChanged);
            // 
            // addProject_btn
            // 
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
            this.displayProject_panel.Location = new System.Drawing.Point(347, 23);
            this.displayProject_panel.Name = "displayProject_panel";
            this.displayProject_panel.Size = new System.Drawing.Size(441, 294);
            this.displayProject_panel.TabIndex = 2;
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
            this.ClientSize = new System.Drawing.Size(800, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newProjectName_tb);
            this.Controls.Add(this.displayProject_panel);
            this.Controls.Add(this.addProject_btn);
            this.Controls.Add(this.projects_listbox);
            this.Name = "ProjectsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Projects";
            this.Load += new System.EventHandler(this.ProjectsManagement_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox projects_listbox;
        private System.Windows.Forms.Button addProject_btn;
        private System.Windows.Forms.Panel displayProject_panel;
        private System.Windows.Forms.TextBox newProjectName_tb;
        private System.Windows.Forms.Label label1;
    }
}
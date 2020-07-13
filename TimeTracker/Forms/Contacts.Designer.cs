namespace TimeTracker.Forms
{
    partial class Contacts
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
            this.contacts_lb = new System.Windows.Forms.ListBox();
            this.searchContacts_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newName_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newEmail_tb = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createContact_btn = new System.Windows.Forms.Button();
            this.updateContact_grpbox = new System.Windows.Forms.GroupBox();
            this.deleteContact_btn = new System.Windows.Forms.Button();
            this.updateContact_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateName_tb = new System.Windows.Forms.TextBox();
            this.updateEmail_tb = new System.Windows.Forms.TextBox();
            this.sendReport_panel = new System.Windows.Forms.Panel();
            this.saveReport_btn = new System.Windows.Forms.Button();
            this.projects_cb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendReport_btn = new System.Windows.Forms.Button();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sendReport_label = new System.Windows.Forms.Label();
            this.saveReport_Dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.updateContact_grpbox.SuspendLayout();
            this.sendReport_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contacts_lb
            // 
            this.contacts_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacts_lb.FormattingEnabled = true;
            this.contacts_lb.HorizontalScrollbar = true;
            this.contacts_lb.ItemHeight = 16;
            this.contacts_lb.Location = new System.Drawing.Point(12, 51);
            this.contacts_lb.Name = "contacts_lb";
            this.contacts_lb.Size = new System.Drawing.Size(264, 420);
            this.contacts_lb.Sorted = true;
            this.contacts_lb.TabIndex = 0;
            this.contacts_lb.SelectedIndexChanged += new System.EventHandler(this.contacts_lb_SelectedIndexChanged);
            // 
            // searchContacts_tb
            // 
            this.searchContacts_tb.Location = new System.Drawing.Point(12, 25);
            this.searchContacts_tb.Name = "searchContacts_tb";
            this.searchContacts_tb.Size = new System.Drawing.Size(264, 20);
            this.searchContacts_tb.TabIndex = 1;
            this.searchContacts_tb.TextChanged += new System.EventHandler(this.searchContacts_tb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search contacts:";
            // 
            // newName_tb
            // 
            this.newName_tb.Location = new System.Drawing.Point(21, 44);
            this.newName_tb.Name = "newName_tb";
            this.newName_tb.Size = new System.Drawing.Size(160, 20);
            this.newName_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Full name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email:";
            // 
            // newEmail_tb
            // 
            this.newEmail_tb.Location = new System.Drawing.Point(21, 92);
            this.newEmail_tb.Name = "newEmail_tb";
            this.newEmail_tb.Size = new System.Drawing.Size(160, 20);
            this.newEmail_tb.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createContact_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.newName_tb);
            this.groupBox1.Controls.Add(this.newEmail_tb);
            this.groupBox1.Location = new System.Drawing.Point(294, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 156);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add new contact";
            // 
            // createContact_btn
            // 
            this.createContact_btn.Location = new System.Drawing.Point(21, 123);
            this.createContact_btn.Name = "createContact_btn";
            this.createContact_btn.Size = new System.Drawing.Size(75, 23);
            this.createContact_btn.TabIndex = 7;
            this.createContact_btn.Text = "Create";
            this.createContact_btn.UseVisualStyleBackColor = true;
            this.createContact_btn.Click += new System.EventHandler(this.createContact_btn_Click);
            // 
            // updateContact_grpbox
            // 
            this.updateContact_grpbox.Controls.Add(this.deleteContact_btn);
            this.updateContact_grpbox.Controls.Add(this.updateContact_btn);
            this.updateContact_grpbox.Controls.Add(this.label4);
            this.updateContact_grpbox.Controls.Add(this.label5);
            this.updateContact_grpbox.Controls.Add(this.updateName_tb);
            this.updateContact_grpbox.Controls.Add(this.updateEmail_tb);
            this.updateContact_grpbox.Location = new System.Drawing.Point(294, 233);
            this.updateContact_grpbox.Name = "updateContact_grpbox";
            this.updateContact_grpbox.Size = new System.Drawing.Size(211, 156);
            this.updateContact_grpbox.TabIndex = 8;
            this.updateContact_grpbox.TabStop = false;
            this.updateContact_grpbox.Text = "Edit existing";
            // 
            // deleteContact_btn
            // 
            this.deleteContact_btn.Location = new System.Drawing.Point(153, 123);
            this.deleteContact_btn.Name = "deleteContact_btn";
            this.deleteContact_btn.Size = new System.Drawing.Size(52, 23);
            this.deleteContact_btn.TabIndex = 8;
            this.deleteContact_btn.Text = "Delete";
            this.deleteContact_btn.UseVisualStyleBackColor = true;
            this.deleteContact_btn.Click += new System.EventHandler(this.deleteContact_btn_Click);
            // 
            // updateContact_btn
            // 
            this.updateContact_btn.Location = new System.Drawing.Point(21, 123);
            this.updateContact_btn.Name = "updateContact_btn";
            this.updateContact_btn.Size = new System.Drawing.Size(75, 23);
            this.updateContact_btn.TabIndex = 7;
            this.updateContact_btn.Text = "Update";
            this.updateContact_btn.UseVisualStyleBackColor = true;
            this.updateContact_btn.Click += new System.EventHandler(this.updateContact_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Full name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Email:";
            // 
            // updateName_tb
            // 
            this.updateName_tb.Location = new System.Drawing.Point(21, 44);
            this.updateName_tb.Name = "updateName_tb";
            this.updateName_tb.Size = new System.Drawing.Size(160, 20);
            this.updateName_tb.TabIndex = 3;
            // 
            // updateEmail_tb
            // 
            this.updateEmail_tb.Location = new System.Drawing.Point(21, 92);
            this.updateEmail_tb.Name = "updateEmail_tb";
            this.updateEmail_tb.Size = new System.Drawing.Size(160, 20);
            this.updateEmail_tb.TabIndex = 5;
            // 
            // sendReport_panel
            // 
            this.sendReport_panel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sendReport_panel.Controls.Add(this.saveReport_btn);
            this.sendReport_panel.Controls.Add(this.projects_cb);
            this.sendReport_panel.Controls.Add(this.label8);
            this.sendReport_panel.Controls.Add(this.sendReport_btn);
            this.sendReport_panel.Controls.Add(this.to_DTP);
            this.sendReport_panel.Controls.Add(this.label7);
            this.sendReport_panel.Controls.Add(this.from_DTP);
            this.sendReport_panel.Controls.Add(this.label6);
            this.sendReport_panel.Controls.Add(this.sendReport_label);
            this.sendReport_panel.Location = new System.Drawing.Point(523, -4);
            this.sendReport_panel.Name = "sendReport_panel";
            this.sendReport_panel.Size = new System.Drawing.Size(337, 491);
            this.sendReport_panel.TabIndex = 9;
            // 
            // saveReport_btn
            // 
            this.saveReport_btn.Location = new System.Drawing.Point(78, 294);
            this.saveReport_btn.Name = "saveReport_btn";
            this.saveReport_btn.Size = new System.Drawing.Size(200, 23);
            this.saveReport_btn.TabIndex = 17;
            this.saveReport_btn.Text = "Save the report file";
            this.saveReport_btn.UseVisualStyleBackColor = true;
            this.saveReport_btn.Click += new System.EventHandler(this.saveReport_btn_Click);
            // 
            // projects_cb
            // 
            this.projects_cb.FormattingEnabled = true;
            this.projects_cb.Location = new System.Drawing.Point(78, 235);
            this.projects_cb.Name = "projects_cb";
            this.projects_cb.Size = new System.Drawing.Size(200, 21);
            this.projects_cb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Project:";
            // 
            // sendReport_btn
            // 
            this.sendReport_btn.Location = new System.Drawing.Point(78, 265);
            this.sendReport_btn.Name = "sendReport_btn";
            this.sendReport_btn.Size = new System.Drawing.Size(200, 23);
            this.sendReport_btn.TabIndex = 14;
            this.sendReport_btn.Text = "Send the report";
            this.sendReport_btn.UseVisualStyleBackColor = true;
            this.sendReport_btn.Click += new System.EventHandler(this.sendReport_btn_Click);
            // 
            // to_DTP
            // 
            this.to_DTP.Location = new System.Drawing.Point(78, 187);
            this.to_DTP.Name = "to_DTP";
            this.to_DTP.Size = new System.Drawing.Size(200, 20);
            this.to_DTP.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "To:";
            // 
            // from_DTP
            // 
            this.from_DTP.Location = new System.Drawing.Point(78, 136);
            this.from_DTP.Name = "from_DTP";
            this.from_DTP.Size = new System.Drawing.Size(200, 20);
            this.from_DTP.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "From:";
            // 
            // sendReport_label
            // 
            this.sendReport_label.AutoSize = true;
            this.sendReport_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendReport_label.Location = new System.Drawing.Point(12, 13);
            this.sendReport_label.Name = "sendReport_label";
            this.sendReport_label.Size = new System.Drawing.Size(135, 25);
            this.sendReport_label.TabIndex = 0;
            this.sendReport_label.Text = "Send report to";
            // 
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 484);
            this.Controls.Add(this.sendReport_panel);
            this.Controls.Add(this.updateContact_grpbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchContacts_tb);
            this.Controls.Add(this.contacts_lb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Contacts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacts";
            this.Load += new System.EventHandler(this.Contacts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.updateContact_grpbox.ResumeLayout(false);
            this.updateContact_grpbox.PerformLayout();
            this.sendReport_panel.ResumeLayout(false);
            this.sendReport_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox contacts_lb;
        private System.Windows.Forms.TextBox searchContacts_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newName_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newEmail_tb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createContact_btn;
        private System.Windows.Forms.GroupBox updateContact_grpbox;
        private System.Windows.Forms.Button updateContact_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateName_tb;
        private System.Windows.Forms.TextBox updateEmail_tb;
        private System.Windows.Forms.Button deleteContact_btn;
        private System.Windows.Forms.Panel sendReport_panel;
        private System.Windows.Forms.Label sendReport_label;
        private System.Windows.Forms.Button sendReport_btn;
        private System.Windows.Forms.DateTimePicker to_DTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker from_DTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox projects_cb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button saveReport_btn;
        private System.Windows.Forms.FolderBrowserDialog saveReport_Dialog;
    }
}
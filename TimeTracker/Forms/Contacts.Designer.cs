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
            this.updateContact_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.updateName_tb = new System.Windows.Forms.TextBox();
            this.updateEmail_tb = new System.Windows.Forms.TextBox();
            this.deleteContact_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.updateContact_grpbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // contacts_lb
            // 
            this.contacts_lb.FormattingEnabled = true;
            this.contacts_lb.Location = new System.Drawing.Point(12, 51);
            this.contacts_lb.Name = "contacts_lb";
            this.contacts_lb.Size = new System.Drawing.Size(264, 420);
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
            // Contacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(859, 484);
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
    }
}
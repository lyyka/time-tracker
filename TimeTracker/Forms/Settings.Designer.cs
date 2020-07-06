namespace TimeTracker
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.hourly_rate = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.TextBox();
            this.updateSettings_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hourly_rate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hourly Rate:";
            // 
            // hourly_rate
            // 
            this.hourly_rate.Location = new System.Drawing.Point(16, 32);
            this.hourly_rate.Name = "hourly_rate";
            this.hourly_rate.Size = new System.Drawing.Size(93, 20);
            this.hourly_rate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Currency:";
            // 
            // currency
            // 
            this.currency.Location = new System.Drawing.Point(132, 32);
            this.currency.MaxLength = 50;
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(100, 20);
            this.currency.TabIndex = 4;
            // 
            // updateSettings_btn
            // 
            this.updateSettings_btn.Location = new System.Drawing.Point(-1, 417);
            this.updateSettings_btn.Name = "updateSettings_btn";
            this.updateSettings_btn.Size = new System.Drawing.Size(379, 34);
            this.updateSettings_btn.TabIndex = 5;
            this.updateSettings_btn.Text = "Update Settings";
            this.updateSettings_btn.UseVisualStyleBackColor = true;
            this.updateSettings_btn.Click += new System.EventHandler(this.updateSettings_btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.updateSettings_btn);
            this.Controls.Add(this.currency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hourly_rate);
            this.Controls.Add(this.label1);
            this.Name = "Settings";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 34);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hourly_rate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hourly_rate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currency;
        private System.Windows.Forms.Button updateSettings_btn;
    }
}
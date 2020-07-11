namespace TimeTracker.Forms
{
    partial class Earnings
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.project_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyFilters_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.today_lb = new System.Windows.Forms.ListBox();
            this.pastSevenDays_lb = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pastThrityDays_lb = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pastSixMonths_lb = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.thisYear_lb = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.allTime_lb = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pastYear_lb = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(12, 51);
            this.chartControl.Name = "chartControl";
            this.chartControl.Size = new System.Drawing.Size(787, 455);
            this.chartControl.TabIndex = 0;
            this.chartControl.Text = "Earnings Chart";
            // 
            // from_DTP
            // 
            this.from_DTP.Location = new System.Drawing.Point(15, 25);
            this.from_DTP.Name = "from_DTP";
            this.from_DTP.Size = new System.Drawing.Size(200, 20);
            this.from_DTP.TabIndex = 1;
            // 
            // to_DTP
            // 
            this.to_DTP.Location = new System.Drawing.Point(244, 25);
            this.to_DTP.Name = "to_DTP";
            this.to_DTP.Size = new System.Drawing.Size(200, 20);
            this.to_DTP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To:";
            // 
            // project_cb
            // 
            this.project_cb.FormattingEnabled = true;
            this.project_cb.Location = new System.Drawing.Point(477, 24);
            this.project_cb.Name = "project_cb";
            this.project_cb.Size = new System.Drawing.Size(121, 21);
            this.project_cb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(474, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Narrow to project:";
            // 
            // applyFilters_btn
            // 
            this.applyFilters_btn.Location = new System.Drawing.Point(628, 22);
            this.applyFilters_btn.Name = "applyFilters_btn";
            this.applyFilters_btn.Size = new System.Drawing.Size(143, 23);
            this.applyFilters_btn.TabIndex = 7;
            this.applyFilters_btn.Text = "Apply filters";
            this.applyFilters_btn.UseVisualStyleBackColor = true;
            this.applyFilters_btn.Click += new System.EventHandler(this.applyFilters_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(805, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Today:";
            // 
            // today_lb
            // 
            this.today_lb.FormattingEnabled = true;
            this.today_lb.Location = new System.Drawing.Point(808, 108);
            this.today_lb.Name = "today_lb";
            this.today_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.today_lb.Size = new System.Drawing.Size(97, 95);
            this.today_lb.Sorted = true;
            this.today_lb.TabIndex = 9;
            // 
            // pastSevenDays_lb
            // 
            this.pastSevenDays_lb.FormattingEnabled = true;
            this.pastSevenDays_lb.Location = new System.Drawing.Point(914, 108);
            this.pastSevenDays_lb.Name = "pastSevenDays_lb";
            this.pastSevenDays_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.pastSevenDays_lb.Size = new System.Drawing.Size(97, 95);
            this.pastSevenDays_lb.Sorted = true;
            this.pastSevenDays_lb.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Past 7 days:";
            // 
            // pastThrityDays_lb
            // 
            this.pastThrityDays_lb.FormattingEnabled = true;
            this.pastThrityDays_lb.Location = new System.Drawing.Point(1020, 108);
            this.pastThrityDays_lb.Name = "pastThrityDays_lb";
            this.pastThrityDays_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.pastThrityDays_lb.Size = new System.Drawing.Size(97, 95);
            this.pastThrityDays_lb.Sorted = true;
            this.pastThrityDays_lb.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1017, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Past 30 days:";
            // 
            // pastSixMonths_lb
            // 
            this.pastSixMonths_lb.FormattingEnabled = true;
            this.pastSixMonths_lb.Location = new System.Drawing.Point(808, 232);
            this.pastSixMonths_lb.Name = "pastSixMonths_lb";
            this.pastSixMonths_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.pastSixMonths_lb.Size = new System.Drawing.Size(97, 95);
            this.pastSixMonths_lb.Sorted = true;
            this.pastSixMonths_lb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(805, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Past 6 months:";
            // 
            // thisYear_lb
            // 
            this.thisYear_lb.FormattingEnabled = true;
            this.thisYear_lb.Location = new System.Drawing.Point(1020, 232);
            this.thisYear_lb.Name = "thisYear_lb";
            this.thisYear_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.thisYear_lb.Size = new System.Drawing.Size(97, 95);
            this.thisYear_lb.Sorted = true;
            this.thisYear_lb.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1017, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "This year:";
            // 
            // allTime_lb
            // 
            this.allTime_lb.FormattingEnabled = true;
            this.allTime_lb.Location = new System.Drawing.Point(914, 356);
            this.allTime_lb.Name = "allTime_lb";
            this.allTime_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.allTime_lb.Size = new System.Drawing.Size(97, 95);
            this.allTime_lb.Sorted = true;
            this.allTime_lb.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(911, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "All time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(805, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quick preview";
            // 
            // pastYear_lb
            // 
            this.pastYear_lb.FormattingEnabled = true;
            this.pastYear_lb.Location = new System.Drawing.Point(914, 232);
            this.pastYear_lb.Name = "pastYear_lb";
            this.pastYear_lb.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.pastYear_lb.Size = new System.Drawing.Size(97, 95);
            this.pastYear_lb.Sorted = true;
            this.pastYear_lb.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(911, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Past year:";
            // 
            // Earnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1141, 518);
            this.Controls.Add(this.pastYear_lb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.allTime_lb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.thisYear_lb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pastSixMonths_lb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pastThrityDays_lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pastSevenDays_lb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.today_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.applyFilters_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.project_cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.to_DTP);
            this.Controls.Add(this.from_DTP);
            this.Controls.Add(this.chartControl);
            this.Name = "Earnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Earnings";
            this.Load += new System.EventHandler(this.Earnings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.DateTimePicker from_DTP;
        private System.Windows.Forms.DateTimePicker to_DTP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox project_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyFilters_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox today_lb;
        private System.Windows.Forms.ListBox pastSevenDays_lb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox pastThrityDays_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox pastSixMonths_lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox thisYear_lb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox allTime_lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox pastYear_lb;
        private System.Windows.Forms.Label label11;
    }
}
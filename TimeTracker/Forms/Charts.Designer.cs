﻿namespace TimeTracker.Forms
{
    partial class Charts
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.project_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyFilters_btn = new System.Windows.Forms.Button();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.avgHours_lb = new System.Windows.Forms.Label();
            this.minHours_lb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxHours_lb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From:";
            // 
            // from_DTP
            // 
            this.from_DTP.Location = new System.Drawing.Point(15, 25);
            this.from_DTP.Name = "from_DTP";
            this.from_DTP.Size = new System.Drawing.Size(200, 20);
            this.from_DTP.TabIndex = 2;
            // 
            // to_DTP
            // 
            this.to_DTP.Location = new System.Drawing.Point(238, 25);
            this.to_DTP.Name = "to_DTP";
            this.to_DTP.Size = new System.Drawing.Size(200, 20);
            this.to_DTP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To:";
            // 
            // project_cb
            // 
            this.project_cb.FormattingEnabled = true;
            this.project_cb.Location = new System.Drawing.Point(461, 25);
            this.project_cb.Name = "project_cb";
            this.project_cb.Size = new System.Drawing.Size(142, 21);
            this.project_cb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(458, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Narrow to project:";
            // 
            // applyFilters_btn
            // 
            this.applyFilters_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyFilters_btn.Location = new System.Drawing.Point(624, 23);
            this.applyFilters_btn.Name = "applyFilters_btn";
            this.applyFilters_btn.Size = new System.Drawing.Size(94, 23);
            this.applyFilters_btn.TabIndex = 7;
            this.applyFilters_btn.Text = "Apply Filters";
            this.applyFilters_btn.UseVisualStyleBackColor = true;
            this.applyFilters_btn.Click += new System.EventHandler(this.applyFilters_btn_Click);
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea";
            this.chartControl.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            legend2.Title = "Legend";
            this.chartControl.Legends.Add(legend2);
            this.chartControl.Location = new System.Drawing.Point(0, 51);
            this.chartControl.Name = "chartControl";
            series2.ChartArea = "ChartArea";
            series2.Legend = "Legend1";
            series2.Name = "Hours/day";
            this.chartControl.Series.Add(series2);
            this.chartControl.Size = new System.Drawing.Size(879, 496);
            this.chartControl.TabIndex = 8;
            this.chartControl.Text = "Chart";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(885, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "On average:";
            // 
            // avgHours_lb
            // 
            this.avgHours_lb.AutoSize = true;
            this.avgHours_lb.Location = new System.Drawing.Point(885, 88);
            this.avgHours_lb.Name = "avgHours_lb";
            this.avgHours_lb.Size = new System.Drawing.Size(35, 13);
            this.avgHours_lb.TabIndex = 10;
            this.avgHours_lb.Text = "label5";
            // 
            // minHours_lb
            // 
            this.minHours_lb.AutoSize = true;
            this.minHours_lb.Location = new System.Drawing.Point(885, 125);
            this.minHours_lb.Name = "minHours_lb";
            this.minHours_lb.Size = new System.Drawing.Size(35, 13);
            this.minHours_lb.TabIndex = 12;
            this.minHours_lb.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(885, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Minimum:";
            // 
            // maxHours_lb
            // 
            this.maxHours_lb.AutoSize = true;
            this.maxHours_lb.Location = new System.Drawing.Point(885, 162);
            this.maxHours_lb.Name = "maxHours_lb";
            this.maxHours_lb.Size = new System.Drawing.Size(35, 13);
            this.maxHours_lb.TabIndex = 14;
            this.maxHours_lb.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(885, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Maximum:";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(982, 547);
            this.Controls.Add(this.maxHours_lb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.minHours_lb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.avgHours_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.applyFilters_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.project_cb);
            this.Controls.Add(this.to_DTP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.from_DTP);
            this.Controls.Add(this.label1);
            this.Name = "Charts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time chart";
            this.Load += new System.EventHandler(this.Charts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker from_DTP;
        private System.Windows.Forms.DateTimePicker to_DTP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox project_cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button applyFilters_btn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartControl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label avgHours_lb;
        private System.Windows.Forms.Label minHours_lb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label maxHours_lb;
        private System.Windows.Forms.Label label9;
    }
}
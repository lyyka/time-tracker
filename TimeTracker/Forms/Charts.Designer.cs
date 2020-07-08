namespace TimeTracker.Forms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.from_DTP = new System.Windows.Forms.DateTimePicker();
            this.to_DTP = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.project_cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.applyFilters_btn = new System.Windows.Forms.Button();
            this.chartControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.project_cb.Location = new System.Drawing.Point(461, 24);
            this.project_cb.Name = "project_cb";
            this.project_cb.Size = new System.Drawing.Size(121, 21);
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
            this.applyFilters_btn.Location = new System.Drawing.Point(809, 22);
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
            chartArea1.Name = "ChartArea";
            this.chartControl.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Legend";
            this.chartControl.Legends.Add(legend1);
            this.chartControl.Location = new System.Drawing.Point(0, 51);
            this.chartControl.Name = "chartControl";
            series1.ChartArea = "ChartArea";
            series1.Legend = "Legend1";
            series1.Name = "Hours/day";
            this.chartControl.Series.Add(series1);
            this.chartControl.Size = new System.Drawing.Size(915, 496);
            this.chartControl.TabIndex = 8;
            this.chartControl.Text = "Chart";
            // 
            // Charts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(915, 547);
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
    }
}
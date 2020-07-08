using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Classes;
using TimeTracker.Controllers;

namespace TimeTracker.Forms
{
    public partial class Charts : Form
    {
        List<Entry> entries; // Entries that will be shown in chart_pb
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            to_DTP.Format = from_DTP.Format = DateTimePickerFormat.Custom;
            to_DTP.CustomFormat = from_DTP.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";

            // By default it should load ALL entries (not narrowed to any project) for last 7 days span
            to_DTP.Value = DateTime.Now;
            from_DTP.Value = DateTime.Now.AddDays(-7);

            // Load projects into dropdown on top of form
            LoadProjects((new ProjectsController()).GetAllProjects());
            
            // Set the size to be min size
            this.MinimumSize = this.Size;

            // Set up chart
            chartControl.Titles.Add("Tracked time in hours per day");
            chartControl.ChartAreas["ChartArea"].AxisX.Title = "Date";
            chartControl.ChartAreas["ChartArea"].AxisY.Title = "Hours";

            SetUpChart();
        }

        // Load projects into combobox
        public void LoadProjects(List<Project> projects)
        {
            project_cb.Items.Clear();
            project_cb.Items.Add("");
            for (int i = 0; i < projects.Count; i++)
            {
                project_cb.Items.Add(projects[i].project_name);
            }
        }

        // Apply filters to the chart
        private void applyFilters_btn_Click(object sender, EventArgs e)
        {
            if(to_DTP.Value.Subtract(from_DTP.Value).TotalDays > 30)
            {
                MessageBox.Show("You can't draw a chart for over 30 days. Please use interval that is less then or equal to 30 days.");
            }
            else
            {
                SetUpChart();
            }
        }

        // Sets the chart up and filters data
        private void SetUpChart()
        {
            // Set up the filter
            EntriesFilter filter = new EntriesFilter(from_DTP.Value, to_DTP.Value);
            if (project_cb.SelectedItem != null)
            {
                string project_name = project_cb.SelectedItem.ToString();
                Project project = (new Controllers.ProjectsController()).FindProjectByName(project_name);
                if (project != null)
                {
                    filter.project_id = project.id;
                }
            }

            // Remove Points from before
            chartControl.Series["Hours/day"].Points.Clear();

            // Get entries from db based on filter
            // This list is being sorted in procedure by start_time ascending
            entries = (new Controllers.EntriesController()).FilterEntriesForChart(filter);

            if(entries.Count > 0)
            {
                // Get List of chart points for entries list
                List<ChartPoint> chartPoints = new List<ChartPoint>();

                // Current chart point that will accumulate data for specific day
                ChartPoint current_point = new ChartPoint();
                for (int i = 0; i < entries.Count; i++)
                {
                    // If point is not set already
                    if (i == 0)
                    {
                        // We store the whole DateTime object, but will use it to get the day only
                        current_point.date = entries[i].start_time;
                    }
                    // If point is set, but the day has changed
                    else if (entries[i].start_time.DayOfYear != current_point.date.DayOfYear)
                    {
                        chartPoints.Add(current_point);
                        chartControl.Series["Hours/day"].Points.AddXY(current_point.date.ToShortDateString(), current_point.total_hours);
                        current_point.date = entries[i].start_time;
                    }

                    // Add hours and earnings to point

                    // -- Convert to non-nullable DateTime object
                    current_point.total_hours += ((DateTime)entries[i].end_time).Subtract(entries[i].start_time).TotalHours;

                    if (entries[i].hourly_rate > 0)
                    {
                        // If we already have the currency in dictionary, just increment it
                        if (current_point.total_earnings.ContainsKey(entries[i].currency))
                        {
                            current_point.total_earnings[entries[i].currency] += entries[i].CalculateEarnings();
                        }
                        // If we don't have this currency, initialize it
                        else
                        {
                            current_point.total_earnings.Add(entries[i].currency, entries[i].CalculateEarnings());

                        }
                    }
                }
                chartPoints.Add(current_point);
                chartControl.Series["Hours/day"].Points.AddXY(current_point.date.ToShortDateString(), current_point.total_hours);
            }
            else
            {
                MessageBox.Show("No entries found for specified filters.");
            }
        }
    }
}

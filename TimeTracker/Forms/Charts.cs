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
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            // Icon
            this.Icon = Properties.Resources.stopwatch_icon;

            to_DTP.Format = from_DTP.Format = DateTimePickerFormat.Custom;
            to_DTP.CustomFormat = from_DTP.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";

            // By default it should load ALL entries (not narrowed to any project) for last 7 days span
            to_DTP.Value = DateTime.Now;
            from_DTP.Value = DateTime.Now.AddDays(-7);

            // Load projects into dropdown on top of form
            Helper.LoadProjects((new ProjectsController()).GetAllProjects(), project_cb);
            
            // Set the size to be min size
            this.MinimumSize = this.Size;

            // Set up chart
            chartControl.Titles.Add("Tracked time in hours per day");
            chartControl.ChartAreas["ChartArea"].AxisX.Title = "Date";
            chartControl.ChartAreas["ChartArea"].AxisY.Title = "Hours";

            SetUpChart();
        }


        // Apply filters to the chart
        private void applyFilters_btn_Click(object sender, EventArgs e)
        {
            if(to_DTP.Value.Subtract(from_DTP.Value).TotalDays > 180)
            {
                MessageBox.Show("You can't draw a chart for over 180 days. Please use interval that is less then or equal to 180 days.");
            }
            else
            {
                SetUpChart();
            }
        }

        /// <summary>
        /// Filters entries and displays them in the chart control
        /// </summary>
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
            List<Entry> entries = (new Controllers.EntriesController()).FilterEntriesForChart(filter);

            int no_of_points = 0;
            double maxHours = 0, minHours = double.MaxValue, sumHours = 0;

            if(entries.Count > 0)
            {
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
                        AddPointToChart(current_point, ref no_of_points, ref sumHours, ref maxHours, ref minHours);

                        current_point.total_hours = 0;
                        current_point.date = entries[i].start_time;
                    }

                    // Add hours and earnings to point

                    // -- Convert to non-nullable DateTime object
                    current_point.total_hours += ((DateTime)entries[i].end_time).Subtract(entries[i].start_time).TotalHours;
                }
                AddPointToChart(current_point, ref no_of_points, ref sumHours, ref maxHours, ref minHours);

                if(no_of_points > 0)
                {
                    avgHours_lb.Text = Math.Round(sumHours / no_of_points, 2).ToString() + "h/day";
                    minHours_lb.Text = Math.Round(minHours, 2).ToString() + "h/day";
                    maxHours_lb.Text = Math.Round(maxHours, 2).ToString() + "h/day";
                }
            }
            else
            {
                MessageBox.Show("No entries found for specified filters.");
            }
        }

        private void AddPointToChart(ChartPoint point, ref int no_of_points, ref double sumHours, ref double maxHours, ref double minHours)
        {
            chartControl.Series["Hours/day"].Points.AddXY(point.date.ToShortDateString(), point.total_hours);

            // Calcs again
            no_of_points++;
            sumHours += point.total_hours;
            if (point.total_hours > maxHours)
            {
                maxHours = point.total_hours;
            }
            else if (point.total_hours < minHours)
            {
                minHours = point.total_hours;
            }
        }
    }
}

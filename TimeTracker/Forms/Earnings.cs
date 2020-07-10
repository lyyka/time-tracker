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
    public partial class Earnings : Form
    {
        public Earnings()
        {
            InitializeComponent();
        }

        private void Earnings_Load(object sender, EventArgs e)
        {
            // Icon
            this.Icon = Properties.Resources.stopwatch_icon;

            // Set up form
            this.MinimumSize = this.Size;

            // By default it should load ALL entries (not narrowed to any project) for last 7 days span
            to_DTP.Value = DateTime.Now;
            from_DTP.Value = DateTime.Now.AddDays(-7);

            // Init chart
            // Chart will show amount earned by day, for each currency on that day
            chartControl.Titles.Add("Daily day and currency");
            chartControl.ChartAreas["ChartArea"].AxisX.Title = "Day/Currency";
            chartControl.ChartAreas["ChartArea"].AxisY.Title = "Amount billed";

            // Load projects into dropdown on top of form
            Helper.LoadProjects((new ProjectsController()).GetAllProjects(), project_cb);

            GenerateQuickPreview();
            SetUpChart();
        }

        // Button to apply filters
        private void applyFilters_btn_Click(object sender, EventArgs e)
        {
            if (to_DTP.Value.Subtract(from_DTP.Value).TotalDays > 180)
            {
                MessageBox.Show("You can't draw a chart for over 180 days. Please use interval that is less then or equal to 180 days.");
            }
            else
            {
                SetUpChart();
            }
        }

        /// <summary>
        /// Used to populate quick preview listboxes
        /// </summary>
        private void GenerateQuickPreview()
        {
            DateTime to = DateTime.Now;
            DateTime from;
            List<Entry> entries;
            EntriesController eController = new EntriesController();
            EntriesFilter filter = new EntriesFilter(DateTime.Now, to); // using DateTime.Now just to initialize

            // Today, past 7, past 30
            int[] decrease = { 0, -7, -30 };
            ListBox[] lbs = { today_lb, pastSevenDays_lb, pastThrityDays_lb };
            for(int i = 0; i < decrease.Length; i++)
            {
                from = to.AddDays(decrease[i]).AddHours(to.Hour * -1).AddMinutes(to.Minute * -1).AddSeconds(to.Second * -1);
                filter.from_date = from;
                entries = eController.FilterEntriesForChart(filter);
                PopulateListBox(entries, lbs[i]);
            }

            // Past 6 months
            from = to.AddMonths(-6).AddHours(to.Hour * -1).AddMinutes(to.Minute * -1).AddSeconds(to.Second * -1);
            filter.from_date = from;
            entries = eController.FilterEntriesForChart(filter);
            PopulateListBox(entries, pastSixMonths_lb);

            // Past year
            from = to.AddYears(-1).AddHours(to.Hour * -1).AddMinutes(to.Minute * -1).AddSeconds(to.Second * -1);
            filter.from_date = from;
            entries = eController.FilterEntriesForChart(filter);
            PopulateListBox(entries, pastYear_lb);

            // This year
            from = to.AddMonths((to.Month - 1) * -1).AddDays((to.Day - 1) *-1).AddHours(to.Hour * -1).AddMinutes(to.Minute * -1).AddSeconds(to.Second * -1);
            filter.from_date = from;
            entries = eController.FilterEntriesForChart(filter);
            PopulateListBox(entries, thisYear_lb);

            // All time
            entries = eController.GetAllEntries();
            PopulateListBox(entries, allTime_lb);
        }

        /// <summary>
        /// Populates listbox for quick preview.
        /// </summary>
        /// <param name="entries">List of entries</param>
        /// <param name="lb">ListBox control to populate</param>
        private void PopulateListBox(List<Entry> entries, ListBox lb)
        {
            ChartPoint current_point = new ChartPoint();
            foreach (Entry entry in entries)
            {
                if (entry.hourly_rate > 0)
                {
                    // If we already have the currency in dictionary, just increment it
                    if (current_point.total_earnings.ContainsKey(entry.currency))
                    {
                        current_point.total_earnings[entry.currency] += entry.CalculateEarnings();
                    }
                    // If we don't have this currency, initialize it
                    else
                    {
                        current_point.total_earnings.Add(entry.currency, entry.CalculateEarnings());

                    }
                }
            }

            foreach (KeyValuePair<string, double> earnings in current_point.total_earnings)
            {
                lb.Items.Add(earnings.Value + earnings.Key);
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

            // Remove Points from before for all currencies (series)
            for(int i = 0; i < chartControl.Series.Count; i++)
            {
                chartControl.Series[i].Points.Clear();
            }

            // Get entries from db based on filter
            // This list is being sorted in procedure by start_time ascending
            List<Entry> entries = (new EntriesController()).FilterEntriesForChart(filter);

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
                        AddPoint(current_point);

                        current_point.date = entries[i].start_time;
                        current_point.total_earnings.Clear();
                    }

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
                AddPoint(current_point);
            }
        }

        /// <summary>
        /// Adds chart point to chart. Loops through all currencies in that chart point, and adds each one of them separately.
        /// </summary>
        /// <param name="point">ChartPoint object to be added to chart</param>
        private void AddPoint(ChartPoint point)
        {
            // Reads from dictionary in ChartPoint object
            foreach(KeyValuePair<string, double> earnings in point.total_earnings)
            {
                AddToSeries(earnings.Key, point);
            }
        }

        /// <summary>
        /// Adds chart point value (date, earnings) to specified series (Currency) in chart.
        /// </summary>
        /// <param name="series">Name of series(currency) where to add earnings to.</param>
        /// <param name="point">ChartPoint object from where to read date and earnings</param>
        private void AddToSeries(string series, ChartPoint point)
        {
            if (chartControl.Series.IsUniqueName(series))
            {
                chartControl.Series.Add(series);
            }

            chartControl.Series[series].Points.AddXY(point.date.ToShortDateString(), point.total_earnings[series]);
        }
    }
}

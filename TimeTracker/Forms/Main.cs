using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Controllers;
using TimeTracker.Classes;
using TimeTracker.Forms;

namespace TimeTracker
{
    public partial class Main : Form
    {
        DateTime minDateTime = DateTime.Now;
        bool timer_on = false;
        Entry current_entry = null;
        //DateTime start_time;
        //string description;
        int seconds = 0, minutes = 0, hours = 0;

        public Main()
        {
            InitializeComponent();
        }

        // On form load
        private void Main_Load(object sender, EventArgs e)
        {
            // Set min size of form
            this.MinimumSize = this.Size;

            // Icon
            this.Icon = Properties.Resources.stopwatch_icon;

            // System tray
            systemTrayIcon.Icon = Properties.Resources.stopwatch_icon;
            systemTrayMenu.Items["exitMenuItem"].Click += new EventHandler(delegate (Object o, EventArgs a) {
                Application.Exit();
            });
            systemTrayIcon.BalloonTipClosed += (s, a) => {
                NotifyIcon icon = (NotifyIcon)s;
                icon.Visible = false;
                icon.Dispose();
            };

            // Filter DateTimePicker formats
            toFilter_DTP.Format = fromFilter_DTP.Format = DateTimePickerFormat.Custom;
            toFilter_DTP.CustomFormat = fromFilter_DTP.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";

            // Set menu images
            logo_pb.BackgroundImage = Properties.Resources.stopwatch;
            settings_pb.BackgroundImage = Properties.Resources.settings;
            project_pb.BackgroundImage = Properties.Resources.project;
            charts_pb.BackgroundImage = Properties.Resources.chart;
            earnings_pb.BackgroundImage = Properties.Resources.finance;
            closeForm_pb.BackgroundImage = Properties.Resources.close;
            contacts_pb.BackgroundImage = Properties.Resources.contacts;

            // Load projects into dropdown on top of form
            List<Project> all_projects = (new ProjectsController()).GetAllProjects();
            Helper.LoadProjects(all_projects, projects_cb);
            Helper.LoadProjects(all_projects, projectFilter_cb);

            // Load entries
            entriesWrap_panel.AutoScroll = false;
            entriesWrap_panel.HorizontalScroll.Enabled = false;
            entriesWrap_panel.AutoScroll = true;
            List<Entry> entries = (new EntriesController()).GetAllEntries(new Sort("id", "asc")); // Get ascending order, because we are adding to FLP one on top of another, so we actually need reversed order from db

            if (entries.Count > 0)
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    if (entries[i].start_time < minDateTime)
                    {
                        minDateTime = entries[i].start_time;
                    }
                }
            }

            SetUpDateTimePickers();

            PopulateEntries(entries);
        }

        // Sets up from and to datetimepickers based on min datetime
        private void SetUpDateTimePickers()
        {
            toFilter_DTP.MinDate = minDateTime.AddSeconds(1);
            toFilter_DTP.MaxDate = DateTime.Now.AddDays(1);

            fromFilter_DTP.MinDate = minDateTime;
            fromFilter_DTP.Value = minDateTime;
            fromFilter_DTP.MaxDate = DateTime.Now;
        }

        // Is called from Projects Management to update projects combobox
        public void LoadProjects(List<Project> projects)
        {
            Helper.LoadProjects(projects, projects_cb);
        }

        /// <summary>
        /// Populates panel on Main form with entries and data.
        /// </summary>
        /// <param name="entries">List of entries to be put into panel</param>
        private void PopulateEntries(List<Entry> entries)
        {
            // Disable UI while loading
            filter_btn.Enabled = false;
            resetFilter_btn.Enabled = false;
            toggleTimer_btn.Enabled = false;
            entriesWrap_panel.Hide();

            // entriesWrap_panel is a main wrap (flow layout panel)
            entriesWrap_panel.Controls.Clear();
            if(entries.Count > 0)
            {
                for (int i = 0; i < entries.Count; i++)
                {
                    AddEntry(entries[i]);
                }
            }

            // Re-enable the UI
            filter_btn.Enabled = true;
            resetFilter_btn.Enabled = true;
            toggleTimer_btn.Enabled = true;
            entriesWrap_panel.Show();
        }

        /// <summary>
        /// Calculates the position of element under any label
        /// </summary>
        /// <param name="lb">Label beneath which the element will be placed</param>
        /// <returns>Point object with x and y coordinates</returns>
        private Point CalculateUnderLabelPos(Label lb)
        {
            return new Point(lb.Location.X, lb.Location.Y + lb.Height);
        }

        /// <summary>
        /// Adds one entry to FlowLayoutPanel.
        /// </summary>
        /// <param name="entry">Entry to be added</param>
        private void AddEntry(Entry entry)
        {
            // Make card to hold the entry
            Panel card = new Panel();
            card.Location = new Point(entriesWrap_panel.Padding.Left, card.Location.Y);
            card.Size = new Size(entriesWrap_panel.Width - 24, 130);
            card.Padding = new Padding(10);
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Margin = new Padding(3, 5, 3, 5);
            card.BackColor = Color.WhiteSmoke;

            // Start time
            Label lb1 = new Label();
            lb1.Text = "Start time: ";
            lb1.Location = new Point(card.Padding.Left, card.Padding.Top);
            card.Controls.Add(lb1);

            DateTimePicker start_time = new DateTimePicker();
            start_time.Value = entry.start_time;
            start_time.Location = CalculateUnderLabelPos(lb1);
            start_time.Format = DateTimePickerFormat.Custom;
            start_time.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";
            card.Controls.Add(start_time);

            // End time
            Label lb2 = new Label();
            lb2.Text = "End time: ";
            lb2.Location = new Point(start_time.Location.X + start_time.Width + 15, lb1.Location.Y);
            card.Controls.Add(lb2);

            DateTimePicker end_time = new DateTimePicker();
            end_time.Value = (DateTime)entry.end_time;
            end_time.Location = CalculateUnderLabelPos(lb2);
            end_time.Format = DateTimePickerFormat.Custom;
            end_time.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";
            card.Controls.Add(end_time);

            // Duration in hours
            Label lb3 = new Label();
            lb3.Text = "Duration in hours:";
            lb3.Location = new Point(end_time.Location.X + end_time.Width + 15, lb2.Location.Y);
            card.Controls.Add(lb3);

            Label duration_lb = new Label();
            duration_lb.AutoSize = true;
            duration_lb.Text = Math.Round(((DateTime)entry.end_time).Subtract(entry.start_time).TotalHours, 2).ToString("F2");
            duration_lb.Location = CalculateUnderLabelPos(lb3);
            card.Controls.Add(duration_lb);

            // Description
            Label lb4 = new Label();
            lb4.Text = "Description:";
            lb4.Location = new Point(lb3.Location.X + lb3.Width + 15, lb3.Location.Y);
            card.Controls.Add(lb4);

            TextBox descUpdate_tb = new TextBox();
            descUpdate_tb.MaxLength = 50;
            descUpdate_tb.Width = 170;
            if (entry.description.Trim() != "")
            {
                descUpdate_tb.Text = entry.description;
            }
            descUpdate_tb.Location = CalculateUnderLabelPos(lb4);
            card.Controls.Add(descUpdate_tb);

            // Project combobox / hourly rate / currency info (below start time datetimepicker control)
            // -- Current entry project
            Project entryProject = entry.Project();

            // -- Project update combobox
            Label pucb_lb = new Label();
            pucb_lb.Text = "Project:";
            pucb_lb.Location = new Point(start_time.Location.X, start_time.Location.Y + start_time.Height + 15);
            card.Controls.Add(pucb_lb);

            ComboBox projectUpdate_cb = new ComboBox();
            projectUpdate_cb.Width = 200;
            List<Project> all_projects = (new ProjectsController()).GetAllProjects();
            projectUpdate_cb.Items.Add("");
            for(int i = 0; i < all_projects.Count; i++)
            {
                projectUpdate_cb.Items.Add(all_projects[i].project_name);
                if(entryProject != null && all_projects[i].project_name == entryProject.project_name)
                {
                    projectUpdate_cb.SelectedIndex = i + 1;
                }

            }
            projectUpdate_cb.Location = CalculateUnderLabelPos(pucb_lb);
            card.Controls.Add(projectUpdate_cb);

            // -- Hourly rate numeric up and down
            Label hru_lb = new Label();
            hru_lb.Text = "Hourly rate:";
            hru_lb.Location = new Point(projectUpdate_cb.Location.X + projectUpdate_cb.Width + 15, pucb_lb.Location.Y);
            card.Controls.Add(hru_lb);

            NumericUpDown hourlyRateUpdate_nud = new NumericUpDown();
            hourlyRateUpdate_nud.Maximum = 100000;
            hourlyRateUpdate_nud.Location = CalculateUnderLabelPos(hru_lb);
            hourlyRateUpdate_nud.Value = entry.hourly_rate;
            card.Controls.Add(hourlyRateUpdate_nud);

            // -- Currency textbox
            Label curr_lb = new Label();
            curr_lb.Text = "Currency:";
            curr_lb.Location = new Point(hourlyRateUpdate_nud.Location.X + hourlyRateUpdate_nud.Width + 15, hru_lb.Location.Y);
            card.Controls.Add(curr_lb);

            TextBox currencyUpdate_tb = new TextBox();
            if(entry.currency != null)
            {
                currencyUpdate_tb.Text = entry.currency;
            }
            currencyUpdate_tb.Location = CalculateUnderLabelPos(curr_lb);
            card.Controls.Add(currencyUpdate_tb);

            // -- Earnings
            Label elb = new Label();
            elb.Location = new Point(currencyUpdate_tb.Location.X + currencyUpdate_tb.Width + 15, curr_lb.Location.Y);
            elb.Text = "Earnings:";
            card.Controls.Add(elb);

            Label earnings_lb = new Label();
            earnings_lb.Location = CalculateUnderLabelPos(elb);
            if(entry.hourly_rate > 0)
            {
                earnings_lb.Text = entry.CalculateEarnings().ToString() + entry.currency;
            }
            else
            {
                earnings_lb.Text = "No hourly rate set";
            }
            card.Controls.Add(earnings_lb);

            // Delete entry button
            Button deleteEntry_btn = new Button();
            deleteEntry_btn.Text = "Delete";
            deleteEntry_btn.Location = new Point(card.Width - deleteEntry_btn.Width - 15, projectUpdate_cb.Location.Y);
            deleteEntry_btn.Click += new EventHandler(delegate (Object o, EventArgs a)
            {
                DialogResult diag = MessageBox.Show("This will delete the selected entry.", "Are you sure?", MessageBoxButtons.YesNo);
                if(diag == DialogResult.Yes)
                {
                    card.Dispose();
                    entry.Delete();
                }
            });
            card.Controls.Add(deleteEntry_btn);

            // Update entry button
            Button updateEntry_btn = new Button();
            updateEntry_btn.Text = "Update";
            updateEntry_btn.Location = new Point(deleteEntry_btn.Location.X - updateEntry_btn.Width - 10, deleteEntry_btn.Location.Y);
            updateEntry_btn.Click += new EventHandler(delegate (Object o, EventArgs a)
            {
                // Update entry object
                bool originalRateRemoved = false;
                entry.start_time = start_time.Value;
                entry.end_time = end_time.Value;
                entry.description = Helper.TrimToLen(descUpdate_tb.Text, 50);
                int hr_rate = Convert.ToInt32(hourlyRateUpdate_nud.Value);
                if (hr_rate > 0 && currencyUpdate_tb.Text.Trim() != "")
                {
                    entry.hourly_rate = hr_rate;
                    entry.currency = Helper.TrimToLen(currencyUpdate_tb.Text, 50);
                }
                else if(hr_rate == 0)
                {
                    entry.hourly_rate = hr_rate;
                    entry.currency = null;
                    originalRateRemoved = true;
                }
                else if(hr_rate > 0 && currencyUpdate_tb.Text.Trim() == "")
                {
                    MessageBox.Show("Please select currency too");
                }

                // Find project by name
                bool projectRateApplied = false;
                string project_name = projectUpdate_cb.SelectedItem != null && projectUpdate_cb.SelectedItem.ToString().Trim() != "" ? projectUpdate_cb.SelectedItem.ToString() : "";
                Project found = (new ProjectsController()).FindProjectByName(project_name);
                if(found != null)
                {
                    if((entry.project_id > 0 && entry.project_id != found.id) || entry.project_id == 0)
                    {
                        // Apply new project to entry
                        entry.project_id = found.id;

                        // Apply projects' hourly rate and currency to entry if user agrees
                        DialogResult dg = MessageBox.Show("Do you want to apply project's hourly rate and currency to this entry?", "Confirm", MessageBoxButtons.YesNo);
                        if (dg == DialogResult.Yes)
                        {
                            if (found.hourly_rate > 0)
                            {
                                projectRateApplied = true;
                                entry.hourly_rate = found.hourly_rate;
                                if (found.currency != null && found.currency != "")
                                {
                                    entry.currency = Helper.TrimToLen(found.currency, 50);
                                }
                                else
                                {
                                    entry.currency = (new SettingsController()).GetSetting("currency").value;
                                }
                            }
                        }
                    }
                }
                else
                {
                    entry.project_id = 0;
                }

                // If rate is removed from entry
                if (!projectRateApplied && originalRateRemoved)
                {
                    DialogResult dg = MessageBox.Show("This entry will be left without an horly rate and currency, so it will not be charged. Do you want to apply hourly rate/currency from global settings?", "Warning", MessageBoxButtons.YesNo);
                    if(dg == DialogResult.Yes)
                    {
                        SettingsController settings = new SettingsController();
                        entry.hourly_rate = Convert.ToInt32(settings.GetSetting("hourly_rate").value);
                        entry.currency = settings.GetSetting("currency").value;
                    }
                }

                // Update entry
                entry.Save();

                // Update UI back
                hourlyRateUpdate_nud.Value = entry.hourly_rate;
                currencyUpdate_tb.Text = entry.currency != null ? entry.currency : "";
                if(entry.hourly_rate > 0)
                {
                    earnings_lb.Text = entry.CalculateEarnings().ToString() + entry.currency;
                }
                else
                {
                    earnings_lb.Text = "No hourly rate set";
                }

                duration_lb.Text = Math.Round(((DateTime)entry.end_time).Subtract(entry.start_time).TotalHours, 2).ToString("F2");

                // Notify user about the update
                MessageBox.Show("Entry updated");
            });
            card.Controls.Add(updateEntry_btn);

            // Add card to flowlayourpanel
            entriesWrap_panel.Controls.Add(card);
            entriesWrap_panel.Controls.SetChildIndex(card, 0); // Add new card to top
        }

        // Open settings form
        private void settings_pb_Click(object sender, EventArgs e)
        {
            (new Settings()).Show();
        }

        // Open projects management form
        private void project_pb_Click(object sender, EventArgs e)
        {
            (new ProjectsManagement(this)).Show();
        }

        // Open charts form
        private void charts_pb_Click(object sender, EventArgs e)
        {
            (new Charts()).Show();
        }

        // Open earnings form
        private void earnings_pb_Click(object sender, EventArgs e)
        {
            (new Earnings()).Show();
        }

        // Close form
        private void closeForm_pb_Click(object sender, EventArgs e)
        {
            int minimize = Convert.ToInt32((new SettingsController()).GetSetting("minimize_to_tray").value);
            if(minimize == 0)
            {
                Application.Exit();
            }
            else
            {
                Hide();
            }
        }

        // Open up the app
        private void systemTrayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        // Filter entries that are displayed
        private void filter_btn_Click(object sender, EventArgs e)
        {
            // Set up the filter
            EntriesFilter filter = Helper.GenerateFilter(fromFilter_DTP, toFilter_DTP, projectFilter_cb);

            List<Entry> entries = (new EntriesController()).FilterEntriesMain(filter);

            PopulateEntries(entries);
        }

        // Reset filters
        private void resetFilter_btn_Click(object sender, EventArgs e)
        {
            SetUpDateTimePickers();

            List<Entry> entries = (new EntriesController()).GetAllEntries(new Sort("id", "asc"));

            PopulateEntries(entries);
        }

        // Open contacts
        private void contacts_pb_Click(object sender, EventArgs e)
        {
            (new Contacts()).Show();
        }

        // Start/Stop timer
        private void toggleTimer_btn_Click(object sender, EventArgs e)
        {
            if (!timer_on)
            {
                // Get project name from dropdown
                string project_name = projects_cb.SelectedItem != null && projects_cb.SelectedItem.ToString().Trim() != "" ? projects_cb.SelectedItem.ToString() : "";

                current_entry = new Entry();

                // Find project by name
                Project found = (new ProjectsController()).FindProjectByName(project_name);

                // If project exists, set project id
                if (found != null)
                {
                    current_entry.project_id = found.id;
                    if(found.hourly_rate > 0)
                    {
                        current_entry.hourly_rate = found.hourly_rate;
                        if(found.currency != null && found.currency.Trim() != "")
                        {
                            current_entry.currency = found.currency;
                        }
                        else
                        {
                            current_entry.currency = (new SettingsController()).GetSetting("currency").value;
                        }
                    }
                    else
                    {
                        current_entry.hourly_rate = Convert.ToInt32((new SettingsController()).GetSetting("hourly_rate").value);
                        current_entry.currency = (new SettingsController()).GetSetting("currency").value;
                    }
                }
                else
                {
                    int global_hourly_rate = Convert.ToInt32((new SettingsController()).GetSetting("hourly_rate").value);
                    if(global_hourly_rate > 0)
                    {
                        current_entry.hourly_rate = global_hourly_rate;
                        current_entry.currency = (new SettingsController()).GetSetting("currency").value;
                    }
                }
                current_entry.description = Helper.TrimToLen(desc_tb.Text, 50);
                current_entry.start_time = DateTime.Now;
                current_entry.end_time = null;

                toggleTimer_btn.Text = "Stop Timer";
                desc_tb.Text = "";
                projects_cb.Enabled = false;
                desc_tb.Enabled = false;

                timer.Start();
            }
            else
            {
                projects_cb.Enabled = true;
                desc_tb.Enabled = true;

                toggleTimer_btn.Text = "Start Timer";
                timer.Stop();

                // Attach end time to current entry
                current_entry.end_time = DateTime.Now;

                // Save the entry
                current_entry.Save();

                // Populate
                AddEntry(current_entry);

                // Reset variables
                current_entry = null;
                seconds = hours = minutes = 0;
                currentTime_lb.Text = "00:00:00";
                entryEarnings_lb.Text = "0.00";
            }
            timer_on = !timer_on;
        }

        // Timer tick
        private void timer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 60)
            {
                minutes++;
                if(minutes == 60)
                {
                    minutes = 0;
                    hours++;
                }
                seconds = 0;
            }

            currentTime_lb.Text = (hours < 10 ? "0" : "") + hours + ":" + (minutes < 10 ? "0" : "") + minutes + ":" + (seconds < 10 ? "0" : "") + seconds;
            if(current_entry.hourly_rate > 0)
            {
                entryEarnings_lb.Text = Convert.ToString(current_entry.CalculateEarnings()) + current_entry.currency;
            }
            else
            {
                entryEarnings_lb.Text = "No hourly rate set";
            }
        }
    }
}

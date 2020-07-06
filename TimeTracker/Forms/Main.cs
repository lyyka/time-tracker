﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Controllers;

namespace TimeTracker
{
    public partial class Main : Form
    {

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
            // Set stopwatch image properties
            logo_pb.Size = new Size(64,64);
            logo_pb.BackgroundImage = Properties.Resources.stopwatch;
            logo_pb.BackgroundImageLayout = ImageLayout.Stretch;

            // Set settings image properties
            settings_pb.Size = new Size(32, 32);
            settings_pb.BackgroundImage = Properties.Resources.settings;
            settings_pb.BackgroundImageLayout = ImageLayout.Stretch;
            settings_pb.Cursor = Cursors.Hand;

            // Set project image properties
            project_pb.Size = new Size(32, 32);
            project_pb.BackgroundImage = Properties.Resources.project;
            project_pb.BackgroundImageLayout = ImageLayout.Stretch;
            project_pb.Cursor = Cursors.Hand;

            // Load projects into dropdown on top of form
            LoadProjects((new ProjectsController()).GetAllProjects());

            // Load entries
            List<Entry> entries = (new EntriesController()).GetAllEntries();
            for(int i = 0; i < entries.Count; i++)
            {
                Project pr = entries[i].Project();
            }
        }

        // Loads projects into a dropdown on top of form. Can be called from ProjectsManagement after new project is created.
        public void LoadProjects(List<Project> projects)
        {
            projects_cb.Items.Clear();
            for (int i = 0; i < projects.Count; i++)
            {
                projects_cb.Items.Add(projects[i].project_name);
            }
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

        // Start/Stop timer
        private void toggleTimer_btn_Click(object sender, EventArgs e)
        {
            if (!timer_on)
            {
                // Get project name from dropdown
                string project_name = projects_cb.SelectedItem != null ? projects_cb.SelectedItem.ToString() : "";

                // Disable dropdown
                

                current_entry = new Entry();

                // Find project by name
                Project found = (new ProjectsController()).FindProjectByName(project_name);

                // If project exists, set project id
                if (found != null)
                {
                    current_entry.project_id = found.id;
                    current_entry.hourly_rate = found.hourly_rate > 0 ? found.hourly_rate : Convert.ToInt32((new SettingsController()).GetSetting("hourly_rate").value);
                    current_entry.currency = found.currency;
                }
                else
                {
                    current_entry.hourly_rate = Convert.ToInt32((new SettingsController()).GetSetting("hourly_rate").value);
                    current_entry.currency = (new SettingsController()).GetSetting("currency").value;
                }
                current_entry.description = Helper.TrimToLen(desc_tb.Text, 50);
                current_entry.start_time = DateTime.Now;

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
            entryEarnings_lb.Text = Convert.ToString(current_entry.CalculateEarnings()) + current_entry.currency;
        }
    }
}

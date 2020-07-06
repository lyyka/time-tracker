using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Main : Form
    {

        bool timer_on = false;
        DateTime start_time;
        string description;
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

            // Load Database functions
            Database db = new Database();

            // Load projects into dropdown
            List<Project> projects = db.GetAllProjects();
            for(int i = 0; i < projects.Count; i++)
            {
                projects_cb.Items.Add(projects[i].project_name);
            }

            // Load entries
            List<Entry> entries = db.GetAllEntries();
            for(int i = 0; i < entries.Count; i++)
            {
                Project pr = entries[i].Project();
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
            (new ProjectsManagement()).Show();
        }

        // Start/Stop timer
        private void toggleTimer_btn_Click(object sender, EventArgs e)
        {
            if (!timer_on)
            {
                timer.Start();
                if(desc_tb.Text.Length > 50)
                {
                    description = desc_tb.Text.Substring(0, 50);
                }
                else
                {
                    description = desc_tb.Text;
                }
                desc_tb.Text = "";
                start_time = DateTime.Now;
            }
            else
            {
                timer.Stop();

                // Add new entry in database

                // Get project name from dropdown
                string project_name = projects_cb.SelectedItem != null ? projects_cb.SelectedItem.ToString() : "";

                Database db = new Database();

                // Create new entry without project_id
                Entry new_entry = new Entry
                {
                    start_time = start_time,
                    end_time = DateTime.Now,
                    description = description,
                };

                // Find project by name
                Project found = db.FindProjectByName(project_name);
                
                // If project exists, set project id
                if(found != null)
                {
                    new_entry.project_id = found.id;
                }

                // Save the entry
                new_entry.Save();

                // Reset variables
                description = "";
                seconds = hours = minutes = 0;
                currentTime_lb.Text = "00:00:00";
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
        }
    }
}

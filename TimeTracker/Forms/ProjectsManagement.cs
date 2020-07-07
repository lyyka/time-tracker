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

namespace TimeTracker
{
    public partial class ProjectsManagement : Form
    {
        Main parent;
        Project selected_project;
        public ProjectsManagement(Main parent)
        {
            // We save the form so we can updated projects dropdown each time new project is added
            this.parent = parent;
            InitializeComponent();
        }

        // On Form load
        private void ProjectsManagement_Load(object sender, EventArgs e)
        {
            UpdateBindings();
        }

        // Updates ListBox with all projects from db (useful after onLoad/insert/update)
        private List<Project> UpdateBindings()
        {
            ProjectsController db = new ProjectsController();
            List<Project> projects = db.GetAllProjects();
            // Load all projects in a list box
            projects_listbox.DataSource = projects;
            projects_listbox.DisplayMember = "project_name";

            return projects;
        }

        // Add project to database
        private void addProject_btn_Click(object sender, EventArgs e)
        {
            if(newProjectName_tb.Text.Trim().Length > 0)
            {
                Project new_project = new Project();
                new_project.project_name = Helper.TrimToLen(newProjectName_tb.Text, 50);
                newProjectName_tb.Text = "";
                new_project.Save();
                List<Project> projects = UpdateBindings();
                if(parent != null)
                {
                    parent.LoadProjects(projects);
                }
            }
        }

        // When someone chooses some project from the list
        private void projects_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Project project = (Project)projects_listbox.SelectedItem;
            if (project != null)
            {
                displayProject_panel.Show();
                selected_project = project;

                // Populate form fields
                displayProjectName_tb.Text = project.project_name;
                displayHourlyRate_nud.Value = project.hourly_rate;
                displayCurrency_tb.Text = project.currency != null ? project.currency : "";
                displayCreatedAt_lb.Text = project.created_at.ToString();
            }
            else
            {
                displayProject_panel.Hide();
            }
        }

        // Update displayed project
        private void displayUpdateProject_btn_Click(object sender, EventArgs e)
        {
            if(selected_project != null && displayProjectName_tb.Text.Trim().Length > 0)
            {
                selected_project.project_name = Helper.TrimToLen(displayProjectName_tb.Text, 50);
                selected_project.hourly_rate = Convert.ToInt32(displayHourlyRate_nud.Value);
                selected_project.currency = Helper.TrimToLen(displayCurrency_tb.Text, 50);
                selected_project.Save();
                List<Project> projects = UpdateBindings();
                if (parent != null)
                {
                    parent.LoadProjects(projects);
                }
            }
        }

        // Delete displayed project
        private void displayDeleteProject_btn_Click(object sender, EventArgs e)
        {
            DialogResult dgh = MessageBox.Show("All entries tied to this project will be permanently deleted", "Are you sure?", MessageBoxButtons.YesNo);
            if(selected_project != null && dgh == DialogResult.Yes)
            {
                selected_project.Delete();
                selected_project = null;

                displayProjectName_tb.Text = "";
                displayCreatedAt_lb.Text = "";
                displayProject_panel.Hide();
                List<Project> projects = UpdateBindings();
                if(parent != null)
                {
                    parent.LoadProjects(projects);
                }
            }
        }
    }
}

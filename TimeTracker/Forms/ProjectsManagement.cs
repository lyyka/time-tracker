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
    public partial class ProjectsManagement : Form
    {
        public ProjectsManagement()
        {
            InitializeComponent();
        }

        // On Form load
        private void ProjectsManagement_Load(object sender, EventArgs e)
        {
            UpdateBindings();
        }

        // Updates ListBox with all projects from db (useful after onLoad/insert/update)
        private void UpdateBindings()
        {
            Database db = new Database();
            // Load all projects in a list box
            projects_listbox.DataSource = db.GetAllProjects();
            projects_listbox.DisplayMember = "project_name";
        }

        // Add project to database
        private void addProject_btn_Click(object sender, EventArgs e)
        {
            if(newProjectName_tb.Text.Trim().Length > 0)
            {
                Database db = new Database();
                Project new_project = new Project();
                if (newProjectName_tb.Text.Length > 50)
                {
                    new_project.project_name = newProjectName_tb.Text.Substring(0, 50);
                }
                else
                {
                    new_project.project_name = newProjectName_tb.Text;
                }
                newProjectName_tb.Text = "";
                new_project.Save();
                UpdateBindings();
            }
        }

        // When someone chooses some project from the list
        private void projects_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string project_name = projects_listbox.SelectedItem.ToString();
        }
    }
}

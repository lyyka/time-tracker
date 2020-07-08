using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker;
using TimeTracker.Controllers;

namespace EntriesGenerator
{
    // Class used to generate random data to seed the database so app can be tested properly
    public class Generator
    {
        /// <summary>
        /// Generates n entries.
        /// </summary>
        /// <parameter name = "n">Number of entries to generate</parameter>
        public List<Entry> GenerateEntries(int n)
        {
            Random ran = new Random();
            List<Entry> entries = new List<Entry>();
            List<Project> db_projects = (new ProjectsController()).GetAllProjects();
            List<Entry> db_entries = (new EntriesController()).GetAllEntries();

            for(int i = 0; i < n; i++)
            {
                Entry entry = new Entry();

                // Generate start time
                int no_of_days = ran.Next(0, 31);
                entry.start_time = DateTime.Now.AddDays(-no_of_days);

                // Generate end time
                int random_hours = ran.Next(1, 8);
                int random_minutes = ran.Next(0, 45);
                entry.end_time = entry.start_time.AddHours(random_hours).AddMinutes(random_minutes);

                // Generate description
                entry.description = "Genrated Entry #" + (db_entries.Count + i + 1);

                // Attach to random project
                int should_attach = ran.Next(0, 2);
                if(should_attach == 1)
                {
                    Project ranProject = db_projects[ran.Next(0, db_projects.Count)];
                    entry.project_id = ranProject.id;
                    if(ranProject.hourly_rate > 0)
                    {
                        entry.hourly_rate = ranProject.hourly_rate;
                        entry.currency = ranProject.currency;
                    }
                    else
                    {
                        SettingsController settingsControler = new SettingsController();
                        entry.hourly_rate = Convert.ToInt32(settingsControler.GetSetting("hourly_rate").value);
                        entry.currency = settingsControler.GetSetting("currency").value;
                    }
                }
                else
                {
                    SettingsController settingsControler = new SettingsController();
                    entry.hourly_rate = Convert.ToInt32(settingsControler.GetSetting("hourly_rate").value);
                    entry.currency = settingsControler.GetSetting("currency").value;
                }

                entry.Save();
            }

            return entries;
        }

        public List<Project> GenerateProjects(int n)
        {
            Random ran = new Random();
            List<Project> projects = new List<Project>();
            List<Project> db_projects = (new ProjectsController()).GetAllProjects();
            string[] currencies = { "RSD", "EUR", "USD" };

            for (int i = 0; i < n; i++)
            {
                Project project = new Project();
                project.project_name = "Generated Project #" + (db_projects.Count + i + 1);

                int has_its_own_rate = ran.Next(0, 2);
                if(has_its_own_rate == 1)
                {
                    project.hourly_rate = ran.Next(10, 40);
                    project.currency = currencies[ran.Next(0, currencies.Length)];
                }

                project.Save();
            }

            return projects;
        }
    }
}

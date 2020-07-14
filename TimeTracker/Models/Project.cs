using System;
using System.Collections.Generic;

using TimeTracker.Controllers;
using TimeTracker.Models;

namespace TimeTracker
{
    // DB Model of Project
    public class Project
    {
        public int id { get; set; }
        public string project_name { get; set; }
        public int hourly_rate { get; set; }
        public string currency { get; set; }
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets all time entries tied to the project.
        /// </summary>
        /// <returns></returns>
        public List<Entry> Entries()
        {
            return (new EntriesController()).FindProjectEntries(this.id);
        }

        /// <summary>
        /// Saves project in database. If project already exists, it will get updated.
        /// </summary>
        public void Save()
        {
            if(id > 0)
            {
                (new ProjectsController()).UpdateProject(this);
            }
            else
            {
                (new ProjectsController()).AddProject(this);
            }
        }

        /// <summary>
        /// If project exists in the database, it gets deleted.
        /// </summary>
        public void Delete()
        {
            if(id > 0)
            {
                (new ProjectsController()).DeleteProject(this);
            }
        }
    }
}

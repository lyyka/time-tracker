using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Controllers;

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

        public List<Entry> Entries()
        {
            return (new EntriesController()).FindProjectEntries(this.id);
        }

        // Saves model to db if it is not saved already
        // If it is already in db, updates it with models current info
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

        public void Delete()
        {
            if(id > 0)
            {
                (new ProjectsController()).DeleteProject(this);
            }
        }
    }
}

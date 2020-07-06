using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Controllers;

namespace TimeTracker
{
    public class Entry
    {
        public int id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string description { get; set; }
        public int project_id { get; set; }

        public Project Project()
        {
            if(this.project_id != 0)
            {
                return (new ProjectsController()).FindProject(this.project_id);
            }
            else
            {
                return null;
            }
        }

        public void Save()
        {
            (new EntriesController()).AddEntry(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    class Project
    {
        public int id { get; set; }
        public string project_name { get; set; }

        public List<Entry> Entries()
        {
            return (new Database()).FindProjectEntries(this.id);
        }

        public void Save()
        {
            (new Database()).AddProject(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
    public class EntriesFilter
    {
        public DateTime from_date { get; set; }
        public DateTime to_date { get; set; }
        public int project_id { get; set; }

        public EntriesFilter(DateTime from_date, DateTime to_date, int project_id = 0)
        {
            this.from_date = from_date;
            this.to_date = to_date;
            if(project_id > 0)
            {
                this.project_id = project_id;
            }
        }
    }
}

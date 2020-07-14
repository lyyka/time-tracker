using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Controllers;

namespace TimeTracker.Models
{
    // DB Model of entry
    public class Entry
    {
        public int id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime? end_time { get; set; }
        public string description { get; set; }
        public int project_id { get; set; }

        // We are saving hourly rate/currency of project/global to each entry, in case it changes at some point
        public int hourly_rate { get; set; }
        public string currency { get; set; }

        // Additional properties for the report
        public string earnings_text {
            get
            {
                if(hourly_rate > 0)
                {
                    return CalculateEarnings().ToString() + currency;
                }
                else
                {
                    return "Not charged";
                }
            }
        }
        public double hours_tracked {
            get
            {
                return ((DateTime)end_time).Subtract(start_time).TotalHours;
            }
        }

        /// <summary>
        /// Get the project this entry refers to. If no such project exists, it returns null.
        /// </summary>
        /// <returns></returns>
        public Project Project()
        {
            if(this.project_id > 0)
            {
                return (new ProjectsController()).FindProject(this.project_id);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Saves entry in database. If entry already exists, it will get updated.
        /// </summary>
        public void Save()
        {
            if(this.id > 0)
            {
                (new EntriesController()).UpdateEntry(this);
            }
            else
            {
                (new EntriesController()).AddEntry(this);
            }
        }

        /// <summary>
        /// If project exists in the database, it gets deleted.
        /// </summary>
        public void Delete()
        {
            if (id > 0)
            {
                (new EntriesController()).DeleteEntry(this);
            }
        }

        /// <summary>
        /// Calculates earnings for this entry based on time span and hourly rate.
        /// </summary>
        /// <returns></returns>
        public double CalculateEarnings()
        {
            DateTime moment = DateTime.Now;
            if (end_time != null)
            {
                moment = (DateTime)this.end_time; // Convert back to non-nullable
            }
            TimeSpan span = moment.Subtract(this.start_time);
            return Math.Round(span.TotalHours * this.hourly_rate, 2);
        }
    }
}

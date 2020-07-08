using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    // DB Model of Setting row
    public class Setting
    {
        /// <summary>
        /// Setting id from database.
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Setting name from database.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Setting value from database.
        /// </summary>
        public string value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
    public class Sort
    {
        public string sort_column { get; set; }
        public string sort_order { get; set; }
     
        public Sort(string sort_column, string sort_order)
        {
            this.sort_column = sort_column;
            this.sort_order = sort_order;
        }
    }
}

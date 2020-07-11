using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Classes;
using TimeTracker.Models;

namespace TimeTracker.Classes
{
    public class Report
    {
        Contact receiver { get; set; }
        string message { get; set; }
        List<Entry> entries { get; set; }

        public Report(Contact receiver, List<Entry> entries)
        {
            this.receiver = receiver;
            this.entries = entries;
        }

        public bool Send()
        {
            if(receiver != null && entries.Count > 0)
            {
                // TODO: Generate an Excel file with the report

                // TODO: Send an email with message and excel file as an attachment
                
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

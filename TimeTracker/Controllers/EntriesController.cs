using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Controllers
{
    public class EntriesController
    {
        string db_name = "time_tracker";

        // -- Add new time entry
        public void AddEntry(Entry new_entry)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if (new_entry.project_id > 0)
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description, @project_id", new_entry);
                }
                else
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description", new_entry);
                }
            };

        }

        // -- Get all entries
        public List<Entry> GetAllEntries()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Entry>("dbo.Entry_GetAll").ToList();
            };
        }

        // -- Get all entries for specific project by id
        public List<Entry> FindProjectEntries(int project_id)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Entry>("dbo.Project_GetAllEntries @project_id", new { project_id = project_id }).ToList();
            };
        }
    }
}

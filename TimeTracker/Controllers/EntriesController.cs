using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimeTracker.Classes;

namespace TimeTracker.Controllers
{
    public class EntriesController : Controller
    {
        // -- Add new time entry
        public void AddEntry(Entry new_entry)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if (new_entry.project_id > 0)
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description, @hourly_rate, @currency, @project_id", new_entry);
                }
                else
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description, @hourly_rate, @currency", new_entry);
                }
            };

        }

        // -- Delete entry
        public void DeleteEntry(Entry entry)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Entry_Delete @id", entry);
            }
        }

        // -- Update entry
        public void UpdateEntry(Entry entry)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if(entry.project_id > 0)
                {
                    conn.Execute("dbo.Entry_Update @start_time, @end_time, @description, @hourly_rate, @currency, @project_id", entry);
                }
                else
                {
                    conn.Execute("dbo.Entry_Update @start_time, @end_time, @description, @hourly_rate, @currency", entry);
                }
            };
        }

        // -- Get all entries
        public List<Entry> GetAllEntries(Sort sort = null)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if(sort == null)
                {
                    return conn.Query<Entry>("dbo.Entry_GetAll").ToList();
                }
                else
                {
                    return conn.Query<Entry>("dbo.Entry_GetAll @sort_column, @sort_order", sort).ToList();
                }
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

        // -- Filter entries for chart
        // -- -- Returns entries in a time span, sorted by start_time
        public List<Entry> FilterEntriesForChart(EntriesFilter filter)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if(filter.project_id > 0)
                {
                    return conn.Query<Entry>("dbo.Entry_Filter @from_date, @to_date, @project_id", filter).ToList();
                }
                else
                {
                    return conn.Query<Entry>("dbo.Entry_Filter @from_date, @to_date", filter).ToList();
                }
            }
        }
    }
}

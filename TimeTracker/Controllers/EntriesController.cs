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
        /// <summary>
        /// Inserts specified entry in database.
        /// </summary>
        /// <param name="new_entry">Entry object to be saved</param>
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

        /// <summary>
        /// Deletes specified entry.
        /// </summary>
        /// <param name="entry">Entry object to be deleted</param>
        public void DeleteEntry(Entry entry)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Entry_Delete @id", entry);
            }
        }

        /// <summary>
        /// Updates specified entry.
        /// </summary>
        /// <param name="entry">Entry object to be updated</param>
        public void UpdateEntry(Entry entry)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                if(entry.project_id > 0)
                {
                    conn.Execute("dbo.Entry_Update @id, @start_time, @end_time, @description, @hourly_rate, @currency, @project_id", entry);
                }
                else
                {
                    conn.Execute("dbo.Entry_Update @id, @start_time, @end_time, @description, @hourly_rate, @currency", entry);
                }
            };
        }

        /// <summary>
        /// Gets all entries from database.
        /// </summary>
        /// <param name="sort">Optional parameter. Sort object to be applied to SQL query.</param>
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

        /// <summary>
        /// Gets all entries for specified project.
        /// </summary>
        /// <param name="project_id">ID of the project to get entries for</param>
        /// <returns></returns>
        public List<Entry> FindProjectEntries(int project_id)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Entry>("dbo.Project_GetAllEntries @project_id", new { project_id = project_id }).ToList();
            };
        }

        // -- Filter entries for chart
        // -- -- Returns entries in a time span, sorted by start_time
        /// <summary>
        /// Filters entries by date and project. Returns list sorted by start_time.
        /// </summary>
        /// <param name="filter">Filter object to be applied to query</param>
        /// <returns></returns>
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

        /// <summary>
        /// Will filter entries on Main.cs and automatically sort them by id-asc, as in Main.cs entries are added in reverse order then they are in list.
        /// </summary>
        /// <param name="filter">Filter object to be applied to query</param>
        /// <returns></returns>
        public List<Entry> FilterEntriesMain(EntriesFilter filter)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                string query = "dbo.Entry_FilterMain ";
                if(filter.from_date != DateTime.MinValue)
                {
                    query += "@from_date, ";
                }
                if(filter.to_date != DateTime.MinValue)
                {
                    query += "@to_date, ";
                }
                if(filter.project_id > 0)
                {
                    query += "@project_id, ";
                }
                query = query.Substring(0, query.Length - 2);
                return conn.Query<Entry>(query, filter).ToList();
            }
        }

        /// <summary>
        /// Filters entries for report to send to contact. Sorted by start_time - desc.
        /// </summary>
        /// <param name="filter">Filter object to be applied to query</param>
        /// <returns></returns>
        public List<Entry> GetForReport(EntriesFilter filter)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                string query = "dbo.Entry_GetForReport @from_date, @to_date";
                if (filter.project_id > 0)
                {
                    query += ", @project_id";
                }
                return conn.Query<Entry>(query, filter).ToList();
            }
        }
    }
}

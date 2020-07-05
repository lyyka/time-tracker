using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    class Database
    {
        public Database()
        {

        }

        // Projects

        public List<Project> GetAllProjects()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
               return conn.Query<Project>("select * from projects").ToList();
            };
        }

        public Project FindProject(int id)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
                List<Project> found = conn.Query<Project>("select * from projects where id = @id", new { id = id }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }

        public Project FindProjectByName(string project_name)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
                List<Project> found = conn.Query<Project>("select * from projects where project_name = @project_name", new { project_name = project_name }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }

        // Entries

        public void AddEntry(DateTime start_time, DateTime end_time, string description, string project_name)
        {
            Project found = FindProjectByName(project_name);
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
                conn.Query("insert into entries (start_time, end_time, description, project_id) values (@start_time, @end_time, @description, @project_id)", new { start_time = start_time, end_time = end_time, description = description, project_id = found == null ? (int?)null : found.id });
            };
            
        }

        public List<Entry> GetAllEntries()
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
                return conn.Query<Entry>("select * from entries").ToList();
            };
        }

        public List<Entry> FindProjectEntries(int project_id)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString("time_tracker")))
            {
                return conn.Query<Entry>("select * from entries where project_id = @project_id", new { project_id = project_id }).ToList();
            };
        }
    }
}

using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker
{
    class Database
    {

        string db_name = "time_tracker";

        public Database()
        {

        }

        // PROJECTS

        // -- Get all projects from db
        public List<Project> GetAllProjects()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
               return conn.Query<Project>("dbo.Project_GetAll").ToList();
            };
        }

        // -- Find project by id
        public Project FindProject(int id)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                List<Project> found = conn.Query<Project>("dbo.Project_GetByID @id", new { id = id }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }

        // -- Find project by it's name
        public Project FindProjectByName(string project_name)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                List<Project> found = conn.Query<Project>("dbo.Project_GetByName @project_name", new { project_name = project_name }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }

        // ENTRIES

        // -- Add new time entry
        public void AddEntry(DateTime start_time, DateTime end_time, string description, string project_name)
        {
            Project found = FindProjectByName(project_name);
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                object parameters = new { 
                    start_time = start_time, 
                    end_time = end_time, 
                    description = description, 
                };

                if(found != null)
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description, @project_id", new
                    {
                        start_time = start_time,
                        end_time = end_time,
                        description = description,
                        project_id = found.id
                    });
                }
                else
                {
                    conn.Execute("dbo.Entry_Insert @start_time, @end_time, @description", new
                    {
                        start_time = start_time,
                        end_time = end_time,
                        description = description,
                    });
                }

            };
            
        }

        // -- Get all entries
        public List<Entry> GetAllEntries()
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
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

        // SETTINGS

        // -- Get all settings
        public List<Setting> GetAllSettings()
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Setting>("dbo.Settings_GetAll").ToList();
            };
        }

        // -- Updates all settings
        public void UpdateAllSettings(List<Setting> settings)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Settings_UpdateAll @id, @name, @value", settings);
            };
        }
    }
}

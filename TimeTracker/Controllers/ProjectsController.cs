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
    public class ProjectsController : Controller
    {
        /// <summary>
        /// Inserts specified project in database.
        /// </summary>
        /// <param name="project">Project object to be saved</param>
        public void AddProject(Project project)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Insert @project_name, @hourly_rate, @currency", project);
            };
        }

        /// <summary>
        /// Updates specified project in database.
        /// </summary>
        /// <param name="project">Project object to be updated</param>
        public void UpdateProject(Project project)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Update @id, @project_name, @hourly_rate, @currency", project);
            };
        }

        /// <summary>
        /// Deletes specified project in database.
        /// </summary>
        /// <param name="project">Project object to be deleted</param>
        public void DeleteProject(Project project)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Delete @id", project);
            };
        }

        /// <summary>
        /// Gets all projects from database.
        /// </summary>
        /// <returns>List of projects</returns>
        public List<Project> GetAllProjects()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Project>("dbo.Project_GetAll").ToList();
            };
        }

        /// <summary>
        /// Finds project by it's ID.
        /// </summary>
        /// <param name="id">ID of the project to find in database</param>
        /// <returns>Project object if it exists, otherwise null</returns>
        public Project FindProject(int id)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                List<Project> found = conn.Query<Project>("dbo.Project_GetByID @id", new { id = id }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }

        /// <summary>
        /// Finds project by it's name.
        /// </summary>
        /// <param name="project_name">Name of the project to look up in database</param>
        /// <returns>Project object if it exists, otherwise null</returns>
        public Project FindProjectByName(string project_name)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                List<Project> found = conn.Query<Project>("dbo.Project_GetByName @project_name", new { project_name = project_name }).ToList();
                return found.Count == 0 ? null : found[0];
            };
        }
    }
}

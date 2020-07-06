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
        //string db_name = "time_tracker";

        // -- Create new project
        public void AddProject(Project project)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Insert @project_name", project);
            };
        }

        // -- Upadte a project
        public void UpdateProject(Project project)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Update @id, @project_name, @hourly_rate, @currency", project);
            };
        }

        // -- Delte a project
        public void DeleteProject(Project project)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Project_Delete @id", project);
            };
        }

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
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
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
    }
}

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
    public class SettingsController : Controller
    {
        /// <summary>
        /// Returns all settings in database.
        /// </summary>
        /// <returns></returns>
        public List<Setting> GetAllSettings()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Setting>("dbo.Settings_GetAll").ToList();
            };
        }

        /// <summary>
        /// Returns setting by it's name
        /// </summary>
        /// <param name="name">Name of setting to be found</param>
        /// <returns>Settings object</returns>
        public Setting GetSetting(string name)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Setting>("dbo.Settings_GetByName @name", new { name = name }).ToList()[0];
            };
        }

        /// <summary>
        /// Updates all settings in database
        /// </summary>
        /// <param name="settings">List of settings to be updated in database</param>
        public void UpdateAllSettings(List<Setting> settings)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Settings_UpdateAll @id, @name, @value", settings);
            };
        }
    }
}

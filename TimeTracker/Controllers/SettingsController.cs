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
        // -- Get all settings
        public List<Setting> GetAllSettings()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Setting>("dbo.Settings_GetAll").ToList();
            };
        }

        // -- Get specific setting
        public Setting GetSetting(string name)
        {
            using(IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Setting>("dbo.Settings_GetByName @name", new { name = name }).ToList()[0];
            };
        }

        // -- Updates all settings
        public void UpdateAllSettings(List<Setting> settings)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Settings_UpdateAll @id, @name, @value", settings);
            };
        }
    }
}

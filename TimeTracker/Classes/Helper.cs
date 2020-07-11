using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TimeTracker
{
    public static class Helper
    {
        /// <summary>
        /// Gets the connection string for database.
        /// </summary>
        /// <param name="name">Name of the string/database.</param>
        /// <returns>Connection string</returns>
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        /// <summary>
        /// Trims string to specified length.
        /// </summary>
        /// <param name="s">String to be trimmed down</param>
        /// <param name="len">Length of the new string</param>
        /// <returns>Returns string if it's length is less then specified. Otherwise returns first len chars of the string.</returns>
        public static string TrimToLen(string s, int len)
        {
            if (s.Trim().Length > len)
            {
                return s.Trim().Substring(0, len);
            }
            else
            {
                return s.Trim();
            }
        }

        /// <summary>
        /// Validates an email address string
        /// </summary>
        /// <param name="e">Email address string to validate</param>
        /// <returns></returns>
        public static bool EmailValid(string e)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(e);
                return addr.Address == e;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Loads projects list in combobox in form.
        /// </summary>
        /// <param name="projects">List of projects to be loaded</param>
        /// <param name="cb">ComboBox control object where to load projects</param>
        public static void LoadProjects(List<Project> projects, ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("");
            for (int i = 0; i < projects.Count; i++)
            {
                cb.Items.Add(projects[i].project_name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TimeTracker
{
    public static class Helper
    {
        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

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
    }
}

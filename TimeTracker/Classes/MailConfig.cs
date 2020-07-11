using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace TimeTracker.Classes
{
    // Used to load up mail configuration from App.config
    public class MailConfig
    {
        public string server { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string port { get; set; }
        public string fromMail { get; set; }

        public MailConfig()
        {
            this.server = ConfigurationManager.AppSettings["MAIL_SERVER"];
            this.username = ConfigurationManager.AppSettings["MAIL_USERNAME"];
            this.password = ConfigurationManager.AppSettings["MAIL_PASSWORD"];
            this.port = ConfigurationManager.AppSettings["MAIL_PORT"];
            this.fromMail = ConfigurationManager.AppSettings["MAIL_FROM"];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Controllers;

namespace TimeTracker.Models
{
    public class Contact
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public DateTime created_at { get; set; }

        /// <summary>
        /// Returns the display string for ListBox
        /// </summary>
        /// <returns></returns>
        public string DisplayString
        {
            get
            {
                return $"{name} ({email})";
            }
        }

        /// <summary>
        /// Saves contact in database. If contact already exists, it will get updated.
        /// </summary>
        public void Save()
        {
            if (id > 0)
            {
                (new ContactsController()).UpdateContact(this);
            }
            else
            {
                (new ContactsController()).AddContact(this);
            }
        }

        /// <summary>
        /// If project exists in the database, it gets deleted.
        /// </summary>
        public void Delete()
        {
            if (id > 0)
            {
                (new ContactsController()).DeleteContact(this);
            }
        }
    }
}

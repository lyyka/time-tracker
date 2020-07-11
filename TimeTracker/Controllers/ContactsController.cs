using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

using TimeTracker.Models;

namespace TimeTracker.Controllers
{
    public class ContactsController : Controller
    {
        /// <summary>
        /// Inserts specified contact in database.
        /// </summary>
        /// <param name="Contact">Contact object to be saved</param>
        public void AddContact(Contact contact)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Contact_Insert @name, @email", contact);
            };
        }

        /// <summary>
        /// Updates specified contact in database.
        /// </summary>
        /// <param name="contact">Contact object to be updated</param>
        public void UpdateContact(Contact contact)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Contact_Update @id, @name, @email", contact);
            };
        }

        /// <summary>
        /// Deletes specified contact in database.
        /// </summary>
        /// <param name="contact">COntact object to be deleted</param>
        public void DeleteContact(Contact contact)
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                conn.Execute("dbo.Contact_Delete @id", contact);
            };
        }

        /// <summary>
        /// Gets all contacts from database.
        /// </summary>
        /// <returns>List of contacts</returns>
        public List<Contact> GetAllContacts()
        {
            using (IDbConnection conn = new SqlConnection(Helper.ConnectionString(db_name)))
            {
                return conn.Query<Contact>("dbo.Contact_GetAll").ToList();
            };
        }
    }
}

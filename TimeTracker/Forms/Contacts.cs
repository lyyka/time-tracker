using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TimeTracker.Models;
using TimeTracker.Controllers;
using TimeTracker.Classes;

namespace TimeTracker.Forms
{
    public partial class Contacts : Form
    {
        List<Contact> contacts;
        Contact selected_contact;

        public Contacts()
        {
            InitializeComponent();
        }

        // On form load
        private void Contacts_Load(object sender, EventArgs e)
        {
            // Form setup
            this.MinimumSize = this.Size;
            this.Icon = Properties.Resources.stopwatch_icon;

            // Datetime picker formats
            to_DTP.Format = from_DTP.Format = DateTimePickerFormat.Custom;
            to_DTP.CustomFormat = from_DTP.CustomFormat = "hh:mm:ss, dd/MMM/yyyy";

            // Load projects
            List<Project> projects = (new ProjectsController()).GetAllProjects();
            Helper.LoadProjects(projects, projects_cb);

            // Load contacts
            contacts = new List<Contact>();
            UpdateBindings();
        }

        // Load contactsd in lb
        private void UpdateBindings()
        {
            contacts = (new ContactsController()).GetAllContacts();
            if(contacts.Count > 0)
            {
                contacts_lb.DataSource = contacts;
                contacts_lb.DisplayMember = "DisplayString";
            }
        }

        private void searchContacts_tb_TextChanged(object sender, EventArgs e)
        {
            string q = searchContacts_tb.Text.Trim();
            if (q.Length > 0)
            {
                List<Contact> res = new List<Contact>();
                foreach(Contact con in contacts)
                {
                    if(con.name.IndexOf(q) >= 0 || con.email.IndexOf(q) >= 0)
                    {
                        res.Add(con);
                    }
                }
                contacts_lb.DataSource = res;
            }
            else
            {
                contacts_lb.DataSource = contacts;
            }
        }

        // Load contact when it's selected in listbox
        private void contacts_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact selected = (Contact)contacts_lb.SelectedItem;
            if(selected != null)
            {
                sendReport_label.Text = $"Send report to {selected.name}";
                sendReport_panel.Show();

                selected_contact = selected;
                updateContact_grpbox.Enabled = true;
                updateName_tb.Text = selected.name;
                updateEmail_tb.Text = selected.email;
            }
            else
            {
                sendReport_panel.Hide();
                updateContact_grpbox.Enabled = false;
            }
        }

        // Update contact
        private void updateContact_btn_Click(object sender, EventArgs e)
        {
            string mail = updateEmail_tb.Text.Trim();
            if (updateName_tb.Text.Trim().Length > 0 && mail.Length > 0)
            {
                if (Helper.EmailValid(mail))
                {
                    selected_contact.name = Helper.TrimToLen(updateName_tb.Text, 100);
                    selected_contact.email = Helper.TrimToLen(updateEmail_tb.Text, 100);
                    selected_contact.Save();
                    MessageBox.Show("Contact updated");

                    UpdateBindings();
                }
                else
                {
                    MessageBox.Show("Email is not properly formatted");
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty");
            }
        }

        private void createContact_btn_Click(object sender, EventArgs e)
        {
            string mail = newEmail_tb.Text.Trim();
            if (newName_tb.Text.Trim().Length > 0 && mail.Length > 0)
            {
                if (Helper.EmailValid(mail))
                {
                    Contact contact = new Contact();
                    contact.name = Helper.TrimToLen(newName_tb.Text, 100);
                    contact.email = Helper.TrimToLen(newEmail_tb.Text, 100);
                    contact.Save();
                    MessageBox.Show("Contact saved");

                    newName_tb.Text = newEmail_tb.Text = "";
                    UpdateBindings();
                }
                else
                {
                    MessageBox.Show("Email is not properly formatted");
                }
            }
            else
            {
                MessageBox.Show("Some fields are empty");
            }
        }

        private void deleteContact_btn_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Are you sure you want to delete this contact?", "Confirm", MessageBoxButtons.YesNo);
            if(dg == DialogResult.Yes)
            {
                selected_contact.Delete();
                updateName_tb.Text = updateEmail_tb.Text = "";
                UpdateBindings();
            }
        }

        // Filter entries and send the report
        private void sendReport_btn_Click(object sender, EventArgs e)
        {
            if(selected_contact != null)
            {
                // Set up the filter
                EntriesFilter filter = Helper.GenerateFilter(from_DTP, to_DTP, projects_cb);
                

                // Get entries from db based on filter
                // This list is being sorted in procedure by start_time ascending
                List<Entry> entries = (new Controllers.EntriesController()).FilterEntriesForChart(filter);

                // Report
                Report rep = new Report(selected_contact, entries);
                bool sent = rep.Send();
                if (sent)
                {
                    MessageBox.Show($"Report is sent successfully to {selected_contact.email}");
                }
                else
                {
                    MessageBox.Show($"Error sending report to {selected_contact.email}");
                }
            }
            else
            {
                MessageBox.Show("Select contact to send to the report first");
            }
        }
    }
}

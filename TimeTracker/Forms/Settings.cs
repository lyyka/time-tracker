using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Controllers;

namespace TimeTracker
{
    public partial class Settings : Form
    {

        List<Setting> settings = new List<Setting>();

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            // Icon
            this.Icon = Properties.Resources.stopwatch_icon;

            // Set up min. size of form
            this.MinimumSize = this.Size;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Load settings
            SettingsController db = new SettingsController();
            settings = db.GetAllSettings();

            // Map settings name from db with textbox name in our form
            // Loop through all results from database, find the textbox with that name and set it's value
            for(int i = 0; i < settings.Count; i++)
            {
                // Numeric values are stored in numeric up and downs
                if(int.TryParse(settings[i].value, out _))
                {
                    NumericUpDown tb = this.Controls.Find(settings[i].name, true).FirstOrDefault() as NumericUpDown;
                    if(tb != null)
                    {
                        tb.Value = Convert.ToInt32(settings[i].value);
                    }
                }
                else
                {
                    // Non-numeric values are stored (strings) are stored in textboxes
                    TextBox tb = this.Controls.Find(settings[i].name, true).FirstOrDefault() as TextBox;
                    if(tb != null)
                    {
                        tb.Text = settings[i].value;
                    }
                }
            }
        }

        // Update all settings in database
        private void updateSettings_btn_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < settings.Count; i++)
            {
                // Reverse the loading process
                // Load all textboxes and nuds in settings list
                if (int.TryParse(settings[i].value, out _))
                {
                    NumericUpDown tb = this.Controls.Find(settings[i].name, true).FirstOrDefault() as NumericUpDown;
                    if (tb != null)
                    {
                        settings[i].value = Convert.ToString(tb.Value);
                    }
                }
                else
                {
                    // Non-numeric values are stored (strings) are stored in textboxes
                    TextBox tb = this.Controls.Find(settings[i].name, true).FirstOrDefault() as TextBox;
                    if (tb != null)
                    {
                        settings[i].value = Helper.TrimToLen(tb.Text, 50);
                    }
                }
            }

            // Use updated settings list to update db
            SettingsController db = new SettingsController();
            db.UpdateAllSettings(settings);
            MessageBox.Show("Settings updated");
        }
    }
}

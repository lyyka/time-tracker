using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using System.Net;
using System.Net.Mail;

using TimeTracker.Controllers;
using TimeTracker.Models;

using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace TimeTracker.Classes
{
    public class Report
    {
        Contact receiver { get; set; }
        string message { get; set; }
        EntriesFilter filter;
        List<Entry> entries { get; set; }

        public Report(Contact receiver, EntriesFilter filter, List<Entry> entries)
        {
            this.receiver = receiver;
            this.entries = entries;
            this.filter = filter;
        }

        public bool IsValid()
        {
            return receiver != null && entries.Count > 0;
        }

        public bool Send()
        {
            if (IsValid())
            {
                // Generate an Excel file with the report
                string file_name = GenerateExcel();

                // Send an email with message and excel file as an attachment
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Config.Get("MAIL_FROM"));
                mail.To.Add(receiver.email);
                mail.Subject = "Time Tracker Report";
                mail.Body = $"Attached to this email is an Excel table containing the activity (entries) report for the time period from {filter.from_date.ToLongDateString()} to {filter.to_date.ToLongDateString()}";
                if(filter.project_id > 0)
                {
                    mail.Body += " assigned to user's project " + (new ProjectsController()).FindProject(filter.project_id).project_name;
                }
                mail.Body += ".";

                Attachment attachment = new Attachment(AppDomain.CurrentDomain.BaseDirectory + file_name);
                mail.Attachments.Add(attachment);

                SmtpClient client = new SmtpClient(Config.Get("MAIL_SERVER"), Convert.ToInt32(Config.Get("MAIL_PORT")));
                client.Credentials = new NetworkCredential(Config.Get("MAIL_USERNAME"), Config.Get("MAIL_PASSWORD"));
                client.EnableSsl = true;
                client.Send(mail);
                
                attachment.Dispose(); // Release the file so we can delete it after
                client.Dispose();

                if(File.Exists(AppDomain.CurrentDomain.BaseDirectory + file_name))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + file_name);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public string GenerateExcel(string path = "")
        {
            Application excel = new Application();
            //excel.Visible = excel.DisplayAlerts = false;

            Workbook workBook = excel.Workbooks.Add(Type.Missing);
            Worksheet workSheet = (Worksheet)workBook.ActiveSheet;
            workSheet.Name = "Time tracker report";

            Range cellRange;
            
            // -- SAVE ENTRIES DATA --
            // Get all properties
            PropertyInfo[] properties = entries[0].GetType().GetProperties();
            int j = 0;

            // Set column names
            foreach (PropertyInfo prop in properties)
            {
                workSheet.Cells[1, j + 1] = prop.Name;
                j++;
            }
            workSheet.Cells[1, j + 1] = "hours worked";
            j++;
            workSheet.Cells[1, j + 1] = "earnings";

            // i + 2 is row count
            for (int i = 0; i < entries.Count; i++)
            {
                // j + 1 is col count
                j = 0;
                foreach (PropertyInfo prop in properties)
                {
                    workSheet.Cells[i + 2, j + 1] = prop.GetValue(entries[i], null);
                    j++;
                }

                // Add hours worked col
                workSheet.Cells[i + 2, j + 1] = Math.Round(((DateTime)entries[i].end_time).Subtract(entries[i].start_time).TotalHours, 3);

                j++;
                // Add earnings col
                if(entries[i].hourly_rate > 0)
                {
                    workSheet.Cells[i + 2, j + 1] = entries[i].CalculateEarnings() + entries[i].currency;
                }
                else
                {
                    workSheet.Cells[i + 2, j + 1] = "Not charged";
                }
            }

            // Auto fit all cells
            cellRange = workSheet.Range[workSheet.Cells[1,1] , workSheet.Cells[entries.Count + 1, properties.Count() + 2]];
            cellRange.EntireColumn.AutoFit();

            // Save to apps bin/Debug dir or to provided path if any
            string base_dir = AppDomain.CurrentDomain.BaseDirectory;
            if(path.Trim().Length > 0)
            {
                base_dir = path + "\\";
            }
            string filename = "Report_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".xlsx";
            workBook.SaveAs(base_dir + filename);

            // Close off the excel sheet
            workBook.Close();
            excel.Quit();

            return filename;
        }
    }
}

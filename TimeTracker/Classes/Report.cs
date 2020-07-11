using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TimeTracker.Classes;
using TimeTracker.Models;

using Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace TimeTracker.Classes
{
    public class Report
    {
        Contact receiver { get; set; }
        string message { get; set; }
        List<Entry> entries { get; set; }

        public Report(Contact receiver, List<Entry> entries)
        {
            this.receiver = receiver;
            this.entries = entries;
        }

        public bool Send()
        {
            if(receiver != null && entries.Count > 0)
            {
                // TODO: Generate an Excel file with the report
                GenerateExcel();

                // TODO: Send an email with message and excel file as an attachment
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private void GenerateExcel()
        {
            Application excel = new Application();
            excel.Visible = excel.DisplayAlerts = false;

            Workbook workBook = excel.Workbooks.Add(Type.Missing);
            Worksheet workSheet = (Worksheet)workBook.ActiveSheet;
            workSheet.Name = "Time tracker report";

            Range cellRange;
            
            // Get all properties
            PropertyInfo[] properties = entries[0].GetType().GetProperties();
            int j = 0;

            // Set column names
            foreach (PropertyInfo prop in properties)
            {
                workSheet.Cells[1, j + 1] = prop.Name;
                j++;
            }

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
            }

            cellRange = workSheet.Range[workSheet.Cells[1,1] , workSheet.Cells[entries.Count + 1, properties.Count()]];
            cellRange.EntireColumn.AutoFit();

            workBook.SaveAs(@"Report_" + DateTime.Now.ToString("yyyyMMddHHmmssffff") + ".xlsx");
            workBook.Close();
            excel.Quit();
        }
    }
}

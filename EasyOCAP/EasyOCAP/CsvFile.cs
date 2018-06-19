using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EasyOCAP
{
    public class CsvFile
    {
        private StringBuilder csv = new StringBuilder();
        private String csvPath = "C:\\test555\\test.csv";

        public void createFileCsv()
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Tester, Ploblem, Check1, Comment, Date, Time");
            File.AppendAllText(csvPath, csv.ToString());
        }

        public void insertDataToFileCsv(String gId, String ploblem, String check1, String comment, String date, String time)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine(gId + "," + ploblem +","+ check1 + "," + comment + "," + date + "," + time);
            File.AppendAllText(csvPath, csv.ToString());
        }
    }
}

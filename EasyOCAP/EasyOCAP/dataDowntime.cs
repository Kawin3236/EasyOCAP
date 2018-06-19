using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EasyOCAP
{
    public class DataDowntime
    {
        private String tester;
        private String ploblem;
        private String check1;
        private String comment;
        private DateTime dateTime;

        public string GetTester()
        {
            return Environment.MachineName;
        }
        public String GetDate()
        {
            return DateTime.Now.ToString("dd-MM-yyyy");
        }

        public String GetTime()
        {
            return DateTime.Now.ToString("HH:mm ") + DateTime.Now.ToString("tt", CultureInfo.InvariantCulture);
        }

        public void SetPloblem(String errorCase)
        {
            this.ploblem = errorCase;
        }
        public String GetPloblem()
        {
            return ploblem;
        }

        public string Ploblem { get => ploblem; set => ploblem = value; }
        public string Check1 { get => check1; set => check1 = value; }
        public string Comment { get => comment; set => comment = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }


    }
}

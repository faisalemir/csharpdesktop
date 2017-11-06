using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class GetLog
    {
        protected string sLogFormat = String.Empty;
        protected string sErrorTime = String.Empty;
        protected string errPath = String.Empty;

        public GetLog()
        {
            errPath = Environment.CurrentDirectory + ConfigurationManager.AppSettings["error"];
            sLogFormat = DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ==> ";

            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            sErrorTime = sYear + sMonth + sDay;
        }

        public void Create(string sErrMsg, string cls, string metod)
        {
            Directory.CreateDirectory(errPath);
            StreamWriter sw = new StreamWriter(errPath + sErrorTime + ".txt", true);
            string src = String.Format("[{0} -> {1}] ", cls, metod);

            sw.WriteLine(sLogFormat + src + sErrMsg);
            sw.Flush();
            sw.Close();
        }
    }
}

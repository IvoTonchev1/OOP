using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger
{
    public class Logger
    {
        public Logger(IAppender appender)
        {
            this.Appender = appender;
        }
        public IAppender Appender { get; set; }
        public void Info(string msg)
        {
            this.Log(msg, ReportLevel.Info);
        }

        public void Warn(string msg)
        {
            this.Log(msg, ReportLevel.Warn);
        }

        public void Error(string msg)
        {
            this.Log(msg, ReportLevel.Error);
        }
        public void Critical(string msg)
        {
            this.Log(msg, ReportLevel.Critical);
        }
        public void Fatal(string msg)
        {
            this.Log(msg, ReportLevel.Fatal);
        }
        private void Log(string msg, ReportLevel level)
        {
            var date = DateTime.Now;
            this.Appender.Append(msg, level, date);
            //Console.WriteLine("{0} - {1} - {2}", date, level, msg);
        }
    }
}

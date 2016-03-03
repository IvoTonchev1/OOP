using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Appenders;
using Logger.Interfaces;

namespace Logger
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(IFormatter formatter) : base(formatter)
        {           
        }

        public override void Append(string message, ReportLevel level, DateTime date)
        {
            string output = this.Formatter.Format(message, level, date);
            Console.WriteLine(output);
        }
    }
}

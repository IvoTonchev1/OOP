using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace LoggerTest
{
    class JSONFormatter : IFormatter
    {
        public string Format(string msg, Logger.ReportLevel level, DateTime date)
        {
            return string.Format("{0} - <<{1}>> - ??{2}??", msg, date, level);
        }
    }
}

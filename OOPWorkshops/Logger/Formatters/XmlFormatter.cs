using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger.Formatters
{
    public class XmlFormatter : IFormatter
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            var output = new StringBuilder();
            output.AppendLine("<log>");
            output.AppendLine("\t<message>" + msg + "</message>");
            output.AppendLine("\t<level>" + level + "</level>");
            output.AppendLine("\t<date>" + date + "</date>");
            output.AppendLine("</log>");
            return output.ToString();
        }
    }
}

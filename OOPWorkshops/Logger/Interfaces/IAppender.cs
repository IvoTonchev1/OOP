using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface IAppender
    {
        IFormatter Formatter { get; set; }
        void Append(string message, ReportLevel level, DateTime date);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Interfaces
{
    public interface IFormatter
    {
        string Format(string msg, ReportLevel level, DateTime date);
    }
}

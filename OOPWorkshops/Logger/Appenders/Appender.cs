using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Interfaces;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        private IFormatter formatter;
        public Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter
        {
            get { return this.formatter; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Formatter cannot be null.");
                }
                this.formatter = value;
            }
        }


        public abstract void Append(string message, ReportLevel level, DateTime date);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger;
using Logger.Formatters;
using Logger.Interfaces;
using Logger = Logger.Logger;


namespace LoggerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new JSONFormatter();
            IAppender appender = new ConsoleAppender(formatter);
            global::Logger.Logger logger = new global::Logger.Logger(appender);
            int a = 5;
            logger.Critical("a cannot be 5");

        }
    }
}

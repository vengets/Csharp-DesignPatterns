using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_using_Publisher_Subscriber_model.Loggers
{
    class WebLogger : ILogger
    {
        public override void log(string message)
        {
            Console.WriteLine("WebLogger :" + message);
        }
    }
}

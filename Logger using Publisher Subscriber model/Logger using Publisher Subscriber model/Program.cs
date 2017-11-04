using Logger_using_Publisher_Subscriber_model.Loggers;
using Logger_using_Publisher_Subscriber_model.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_using_Publisher_Subscriber_model
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoEncoder video = new VideoEncoder();

            FileLogger flog = new FileLogger();
            DBLogger dblog = new DBLogger();
            video.LogEncoded += flog.log;
            video.LogEncoded += dblog.log;

            video.Encode();
            Console.ReadKey();
        }
        
    }
}

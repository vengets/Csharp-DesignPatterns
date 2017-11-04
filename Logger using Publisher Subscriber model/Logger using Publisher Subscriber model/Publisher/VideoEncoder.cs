using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger_using_Publisher_Subscriber_model.Publisher
{
    public class VideoEncoder
    {
        public delegate void Logging(string message);
        public event Logging LogEncoded;
        public void Encode()
        {
            //Does encoding
            OnLogEncoded();
        }
        public virtual void OnLogEncoded()
        {
            if(LogEncoded!=null)
            {
                LogEncoded("Encoding Done!");
                
            }
        }
    }
}

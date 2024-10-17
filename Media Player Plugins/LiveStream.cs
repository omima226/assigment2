using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class LiveStream:IMedia
    {
        public void Start()
        {
            Console.WriteLine("Live Stream is playing ...........");
        }
        public void Stop()
        {
            Console.WriteLine("Live Stream is stopping ...........");
        }
        }
}

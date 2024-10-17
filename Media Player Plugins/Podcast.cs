using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class Podcast:IMedia
    {
        public void Start()
        {
            Console.WriteLine("Podcast is playing ...........");
        }
        public void Stop() 
        {
            Console.WriteLine("Podcast is stopping ...........");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class Audio:IMedia
    {
        public void Start()
        {
            Console.WriteLine("Audio is playing ...........");
        }
        public void Stop() 
        {
            Console.WriteLine("Audio is stopping ...........");
         }
    }
}

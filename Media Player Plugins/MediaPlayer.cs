using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player_Plugins
{
    internal class MediaPlayer
    {
        public void MediaPlay(IMedia media)
        {
            media.Start();
        }
        public void MediaPause(IMedia media) 
        { 
            media.Stop();
        }
    }
}

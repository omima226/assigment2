namespace Media_Player_Plugins
{
    internal class Program
    {
        static void Main(string[] args)
        {
           MediaPlayer mediaPlayer = new MediaPlayer();
            IMedia audio = new Audio();
            IMedia video = new Video();
            IMedia podcast = new Podcast();
            IMedia liveStream = new LiveStream();

            mediaPlayer.MediaPlay(audio);
            mediaPlayer.MediaPause(audio);
            Console.WriteLine();

            mediaPlayer.MediaPlay(video);
            mediaPlayer.MediaPause(video);
            Console.WriteLine();

            mediaPlayer.MediaPlay(podcast);
            mediaPlayer.MediaPause(podcast);
            Console.WriteLine();

            mediaPlayer.MediaPlay(liveStream);
            mediaPlayer.MediaPause(liveStream);
            Console.WriteLine();


        }
    }
}

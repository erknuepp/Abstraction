namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class Song : Content, IPlayable, IListenable
    {
        private TimeSpan playTime;
        public Song(string title):base(title)
        {
            playTime = new TimeSpan();
        }

        public Song(string title, TimeSpan playTime) : base(title)
        {
            this.playTime = playTime;
        }

        public string Play()
        {
            return($"The song {base.GetTitle()} is being played.");
        }

        public string Listen()
        {
            return($"The song {base.GetTitle()} is being listened to.");
        }

        public TimeSpan PlayTime => playTime;
    }
}

namespace Abstraction
{

    using System.Collections.Generic;

    internal class Album : Audio, IPlayable, IListenable
    {
        readonly ICollection<Song> _songs;
        public Album(string title) : base(title)
        {
            _songs = new List<Song>();
        }

        public Album(string title, ICollection<Song> songs) : base(title)
        {
            _songs = songs;
        }

        public string Play()
        {
            return $"The {GetTitle()} album is being played.";
        }

        public string Listen()
        {
            return $"The {GetTitle()} album is being listened to.";
        }

        /// <summary>
        /// Polymorphic implementation of Content GetTitle() that trims whitespace.
        /// </summary>
        /// <returns>String: The Album Title with whitespace trimmed.</returns>
        public override string GetTitle()
        {
            return base.GetTitle().Trim();
        }

        public int SongCount => _songs.Count;
    }
}
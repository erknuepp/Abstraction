namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal sealed class Movie : Video, IPlayable, IViewable, IListenable
    {
        public Movie(string title):base(title)
        {

        }

        public string Listen()
        {
            return($"The movie {base.GetTitle()} is being listened to.");
        }

        public string Play()
        {
            return($"The movie {base.GetTitle()} is being played.");
        }

        public string View()
        {
            return($"The movie {base.GetTitle()} is being viewed.");
        }
    }
}

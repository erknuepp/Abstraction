namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class AudioBook : Content, IPlayable, IListenable
    {
        public AudioBook(string title): base(title)
        {

        }

        public string Listen()
        {
            return ($"AudioBook {base.GetTitle()} is being listened to.");
        }

        public string Play()
        {
            return($"AudioBook {base.GetTitle()} is being played.");
        }        
    }
}

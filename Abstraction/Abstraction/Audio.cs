namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Audio : Content, IPlayable
    {
        public Audio(string title) : base(title)
        {

        }

        public string Play()
        {
            return "A piece of audio content is being played";
        }
    }
}

namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Video : Content
    {
        public Video(string title) : base(title)
        {

        }

        public string Title()
        {
            return base.GetTitle();
        }
    }
}

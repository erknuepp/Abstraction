namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Book : Text, IReadable
    {
        public Book(string title) : base(title)
        {
        }

        public string Read()
        {
            return $"The book {base.GetTitle()} is being read";
        }
    }
}

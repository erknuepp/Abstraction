namespace Abstraction
{
    using System.Collections.Generic;

    internal sealed class ContentLibrary
    {
        System.Collections.ObjectModel.ObservableCollection<Content> contents;

        public ContentLibrary()
        {
            contents = new System.Collections.ObjectModel.ObservableCollection<Content>();
        }

        public void Add(Content content)
        {
            contents.Add(content);
        }

        public System.Collections.ObjectModel.ObservableCollection<Content> Contents => contents; 
    }
}
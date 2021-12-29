namespace Abstraction
{
    using System.Collections.ObjectModel;

    internal sealed class ContentLibrary
    {
        ObservableCollection<Content> contents;

        public ContentLibrary()
        {
            contents = new ObservableCollection<Content>();
        }

        public void Add(Content content)
        {
            contents.Add(content);
        }

        public ObservableCollection<Content> Contents => contents; 
    }
}
namespace Abstraction
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    public partial class MainPage : ContentPage
    {
        ContentLibrary contentLibrary;
        public MainPage()
        {
            InitializeComponent();

            contentLibrary = new ContentLibrary();

            contentTypePicker.ItemsSource = new List<string>
            {
                "Book",
                "AudioBook",
                "Movie",
                "Album",
                "Song"
            };
        }

        public void AddContentButtonClicked(object sender, EventArgs e)
        {
            var contentType = contentTypePicker.SelectedItem as string;
            var title = contentTitle.Text;

            switch (contentType)
            {
                case ("Book"):
                    contentLibrary.Contents.Add(new Book(title));
                    break;
                case ("AudioBook"):
                    contentLibrary.Contents.Add(new AudioBook(title));
                    break;
                case ("Movie"):
                    contentLibrary.Contents.Add(new Movie(title));
                    break;
                case ("Album"):
                    contentLibrary.Contents.Add(new Album(title));
                    break;
                case ("Song"):
                    contentLibrary.Contents.Add(new Song(title));
                    break;
                default:
                    break;
            }
            contentTypePicker.SelectedIndex = -1;
            contentTitle.Text = "";
            contentLibraryListView.ItemsSource = contentLibrary.Contents;
        }

        public void PlayButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if(selectedContentItem is Movie movie)
                {
                    stateMessage.Text = movie.Play();
                }
                if (selectedContentItem is Song song)
                {
                    stateMessage.Text = song.Play();
                }
                if (selectedContentItem is AudioBook audioBook)
                {
                    stateMessage.Text = audioBook.Play();
                }
                if (selectedContentItem is Album album)
                {
                    stateMessage.Text = album.Play();
                }
            }
        }

        public void ReadButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is Book book)
                {
                    stateMessage.Text = book.Read();
                }
            }
        }

        public void ViewButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is Movie movie)
                {
                    stateMessage.Text = movie.View();
                }                
            }
        }

        public void ListenButtonClicked(object sender, EventArgs e)
        {
            var selectedContentItem = contentLibraryListView.SelectedItem;
            if (selectedContentItem != null)
            {
                if (selectedContentItem is AudioBook audioBook)
                {
                    stateMessage.Text = audioBook.Listen();
                }
                if (selectedContentItem is Song song)
                {
                    stateMessage.Text = song.Listen();
                }
                if (selectedContentItem is Album album)
                {
                    stateMessage.Text = album.Listen();
                }
            }
        }
    }
}

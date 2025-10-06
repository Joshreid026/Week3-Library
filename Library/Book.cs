namespace Library
{
    class Book
    {
        private string title;
        private string author;
        private string iSBN;

        // Title property to allow access
        // to the title private variable
        public string Title
        {
            get { return title; }  // get method
            set { title = value; } // set method
        }
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string ISBN
        {
            get { return iSBN; }
            set { iSBN = value; }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            title = bookTitle;
            author = bookAuthor;
            iSBN = bookISBN;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {title}");
            Console.WriteLine($"Book Author: {author}");
            Console.WriteLine($"Book ISBN: {iSBN}");
            Console.WriteLine();
        }
    }
}

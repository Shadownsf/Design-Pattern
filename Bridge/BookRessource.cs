namespace Bridge
{
    public class BookRessource : IRessource
    {
        private Book _book;

        public BookRessource(Book book)
        {
            this._book = book;
        }

        public string getImage()
        {
            return _book.Cover;
        }

        public string getSnippet()
        {
            return $"SYNOPSYS:\n\t{_book.Synopsys}";
        }

        public string getTitle()
        {
            return $"TITRE:\n\t{_book.Title}";
        }
    }
}
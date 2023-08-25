namespace Odev.Q1
{
    internal class Library
    {
        public List<Book> books;
        public Library() 
        {
            books = new List<Book>();
        }
        public Book BorrowBook(string name)
        {
            var bookToBorrow = books.FirstOrDefault(book => book.Title == name);
            if (bookToBorrow != null)
            {
                books.Remove(bookToBorrow);
            }
            return bookToBorrow;
        }
        public void ReturnBook(Book book)
        {
            books.Add(book);
        }
        public void RemoveBookFromLibrary(string name)
        {
            books.RemoveAll(book => book.Title == name);
        }
    }
}

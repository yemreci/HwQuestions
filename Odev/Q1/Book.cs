namespace Odev.Q1
{
    internal class Book
    {
        public Guid Id { get;}
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public Book(string title,string description, string author)
        {
            Id = Guid.NewGuid();
            Title = title;
            Description = description;
            Author = author;
        }
    }
}

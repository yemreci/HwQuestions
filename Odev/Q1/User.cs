namespace Odev.Q1
{
    internal class User
    {
        public List<Book> HeldBooks { get; set; }
        public User()
        {
            HeldBooks = new List<Book>();
        }
    }
}

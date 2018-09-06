namespace UnitOfWorkSample.Data
{
    public class BookEntity : DatabaseEntity
    {
        public string Title { get; set; }
        public int AuhtorId { get; set; }
        public AuthorEntity Author { get; set; }
    }
}

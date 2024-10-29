namespace DSCC_13540_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}

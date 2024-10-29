namespace DSCC_13540_API.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}

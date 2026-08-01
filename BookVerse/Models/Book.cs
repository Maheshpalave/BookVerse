namespace BookVerse.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public double Rating { get; set; }

        public string CoverImage { get; set; }
    }
}
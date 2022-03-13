namespace AS_lab1_gr1.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Lead { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }

        // Author
        public Author Author { get; set; }
        public int AuthorId { get; set; }

        // Category
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        // Comment
        public ICollection<Comment> Comments { get; set; }

        // Tag
        public ICollection<Tag> Tags { get; set; }

        // Match
        public Match? Match { get; set; }
        public int? MatchId { get; set; }
    }
}

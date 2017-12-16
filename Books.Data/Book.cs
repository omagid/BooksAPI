using System.ComponentModel.DataAnnotations;

namespace Books.Data
{
    public class Book : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        [Required]
        public string Author { get; set; }
        public string Content { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.Models
{
    public class Book
    {
        //Title, Author, Price, Genre.
        public string BookId { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [Required]
        [StringLength(20)]
        public string Author { get; set; }
        [Required]
        [Range(1,20)]
        public double Price { get; set; }
        [Required]
        [StringLength(20)]
        public string Genre { get; set; }
    }
}

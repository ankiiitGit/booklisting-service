using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BookListingMicroService.Models
{
    public class Book
    {
        [Key]
        public Int64 bookId { get; set; }
        [Required]
        public String title { get; set; }
        [Required]
        public String author { get; set; }
        public String genre { get; set; }
        public String bookCondition { get; set; }
        public String availability { get; set; }
    }
}

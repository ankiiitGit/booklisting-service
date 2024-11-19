namespace BookListingMicroService.Models.Dto
{
    public class BookDto
    {
        public Int64 bookId { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String genre { get; set; }
        public String bookCondition { get; set; }
        public String availability { get; set; }
    }
}

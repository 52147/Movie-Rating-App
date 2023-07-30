namespace MovieRatingApp.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public string User { get; set; }
        public int RatingValue { get; set; }
        public string Comment { get; set; }
    }
}

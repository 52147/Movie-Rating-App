namespace MovieRatingApp.Models // Replace "YourNamespace" with your actual namespace.
{
public class Movie
{
    public int MovieID { get; set; }
    public string? Title { get; set; } // Add "?" after string
    public string? Genre { get; set; } // Add "?" after string
    public string? Director { get; set; } // Add "?" after string
    public DateTime ReleaseDate { get; set; }
    public List<Rating> Ratings { get; set; } = new List<Rating>();
}
}
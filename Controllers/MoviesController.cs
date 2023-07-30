using Microsoft.AspNetCore.Mvc;
using MovieRatingApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace MovieRatingApp.Controllers
{
    public class MoviesController : Controller
    {
        // Sample data for demonstration (replace this with your actual data source)
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
            {
                MovieID = 1,
                Title = "Sample Movie 1",
                Genre = "Action",
                Director = "John Doe",
                ReleaseDate = new DateTime(2022, 1, 15),
                Ratings = new List<Rating>
                {
                    new Rating { Id = 1, User = "User1", RatingValue = 4 },
                    new Rating { Id = 2, User = "User2", RatingValue = 3 },
                    new Rating { Id = 3, User = "User3", RatingValue = 5 }
                }
            },
            new Movie
            {
                MovieID = 2,
                Title = "Sample Movie 2",
                Genre = "Comedy",
                Director = "Jane Smith",
                ReleaseDate = new DateTime(2023, 5, 20),
                Ratings = new List<Rating>
                {
                    new Rating { Id = 4, User = "User1", RatingValue = 5 },
                    new Rating { Id = 5, User = "User3", RatingValue = 4 }
                }
            }
        };

        // Action to display movie details and ratings
        public IActionResult Details(int id)
        {
            // Get the movie with the given ID from the data source
            var movie = _movies.FirstOrDefault(m => m.MovieID == id);

            if (movie == null)
            {
                return NotFound();
            }

            return View(movie);
        }

        // Action to delete a movie rating
        [HttpPost]
        public IActionResult DeleteRating(int movieId, int ratingId)
        {
            // Get the movie with the given ID from the data source
            var movie = _movies.FirstOrDefault(m => m.MovieID == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            // Find and remove the rating with the given ID from the movie's ratings
            var ratingToRemove = movie.Ratings.FirstOrDefault(r => r.Id == ratingId);

            if (ratingToRemove == null)
            {
                return NotFound();
            }

            movie.Ratings.Remove(ratingToRemove);

            // Redirect back to the movie details page after deleting the rating
            return RedirectToAction(nameof(Details), new { id = movieId });
        }
    }
}

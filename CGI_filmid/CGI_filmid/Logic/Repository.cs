using CGI_filmid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGI_filmid.Logic
{
    public class Repository
    {
        List<Movie> movieList;
        List<Category> categories;

        private Repository()
        {
            this.movieList = createSampleMovieList();
            this.categories = createSampleCategories();
        }
        
        private static Repository instance;
        public static Repository getInstance()
        {
            if (instance == null)
            {
                instance = new Repository();
            }
            return instance;
        }
     
    public static List<Movie> createSampleMovieList()
        {
            List<Movie> movies = new List<Movie>();
            movies.Add(new Movie(1, "Forrest Gump", 1994, "The presidencies of Kennedy and Johnson, the events of Vietnam, Watergate and other historical events unfold through the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", 8.0, 5));
            movies.Add(new Movie(2, "The Godfather", 1972, "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", 8.3, 4));
            movies.Add(new Movie(3, "The Matrix", 1999, "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.", 8.1, 3));
            return movies;
        }

        public static List<Category> createSampleCategories()
        {
            List<Category> categories = new List<Category>();
            categories.Add(new Category(1, "Comedy"));
            categories.Add(new Category(2, "Thriller"));
            categories.Add(new Category(3, "Action"));
            categories.Add(new Category(4, "Crime"));
            categories.Add(new Category(5, "Drama"));
            return categories;
        }

        public MovieList getMovieList()
        {
            return new MovieList(movieList, categories);
        }

        public Movie getMovie(int id)
        {
            return movieList.Find(x => x.id == id);
        }
    }
}
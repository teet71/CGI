using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CGI_filmid.Models
{
    public class MovieList
    {
        public List<Movie> movies;
        public List<Category> categories;

        public MovieList(List<Movie> movies, List<Category> categories)
        {
            this.movies = new List<Movie>();

            foreach (Movie movie in movies)
            {
                this.movies.Add(new Movie(movie.id, movie.title, movie.year, movie.rating, movie.categoryId));
            }
            this.categories = categories;
        }
    }
}
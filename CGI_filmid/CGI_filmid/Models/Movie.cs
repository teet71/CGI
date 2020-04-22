using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGI_filmid.Models
{
    public class Movie
    {
        public int id;

        public string title;

        public int year;

        public string description;

        public double rating;

        public int categoryId;

        public Movie(int id, string title, int year, string description, double rating, int categoryId)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.description = description;
            this.rating = rating;
            this.categoryId = categoryId;
        }

        public Movie(int id, string title, int year, double rating, int categoryId)
        {
            this.id = id;
            this.title = title;
            this.year = year;
            this.rating = rating;
            this.categoryId = categoryId;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CGI_filmid.Models;

namespace CGI_filmid.Logic
{
    public class Service
    {
        private Repository repository = Repository.getInstance();

        public MovieList GetMovieList()
        {
            return repository.getMovieList();
        }

        public string getMovieDetails(int id)
        {
            return repository.getMovie(id).description;
        }
    }
}
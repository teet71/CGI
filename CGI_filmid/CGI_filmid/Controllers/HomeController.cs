using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CGI_filmid.Models;

namespace CGI_filmid.Controllers
{
    public class HomeController : Controller
    {
        //GET: Film
        FilmController filmController = new FilmController();
        public ActionResult Index()
        {
            //return View((MovieList) filmController.Index(null).Data);
            return View();
        }
    }
}
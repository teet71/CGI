using System.Web.Mvc;
using CGI_filmid.Logic;

namespace CGI_filmid.Controllers
{
    public class FilmController : Controller
    {
        Service service = new Service();

        public JsonResult Index(int? id)
        {
            if (!id.HasValue)
            {
                return Json(service.GetMovieList(), JsonRequestBehavior.AllowGet);
            }
            return Json(service.getMovieDetails(id.Value), JsonRequestBehavior.AllowGet);
        }
    }
}
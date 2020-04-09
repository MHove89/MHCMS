using Microsoft.AspNetCore.Mvc;

namespace MHCMS.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace MHCMS.SampleSite.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

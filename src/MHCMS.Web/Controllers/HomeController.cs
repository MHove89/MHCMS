using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MHCMS.Web.Controllers
{
    public class HomeController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}

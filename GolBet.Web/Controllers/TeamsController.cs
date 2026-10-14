using Microsoft.AspNetCore.Mvc;

namespace GolBet.Web.Controllers
{
    public class TeamsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

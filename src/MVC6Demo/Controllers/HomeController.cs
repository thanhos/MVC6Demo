using Microsoft.AspNet.Mvc;
using MVC6Demo.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC6Demo.Controllers
{
  public class HomeController : Controller
  {
    // GET: /<controller>/
    public IActionResult Index()
    {
      HeroManager HM = new HeroManager();
      var heroes = HM.GetAll;
      return View(heroes);
    }
  }
}

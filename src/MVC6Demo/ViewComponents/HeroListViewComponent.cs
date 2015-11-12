using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;
using MVC6Demo.Models;
using System.Collections.Generic;
namespace MVC6Demo.ViewComponents
{
  //[ViewComponent(Name="HeroList")]
  public class HeroListViewComponent : ViewComponent
  {
    public async Task<IViewComponentResult> InvokeAsync(string type)
    {
      var heroes = await GetHeroesAsync(type);
      return View(heroes);
      //return View("HeroList", heroes);
    }

    private Task<IEnumerable<DOTAHero>> GetHeroesAsync(string type)
    {
      return Task.FromResult(GetHeroes(type));
    }

    private IEnumerable<DOTAHero> GetHeroes(string type)
    {
      var HM = new HeroManager();
      return HM.GetHeroesByType(type);
    }
  }
}
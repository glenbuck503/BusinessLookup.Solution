using BusinessLookup.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace TournamentOrganizer.Controllers
{
  public class HomeController : Controller
  {
    private readonly BusinessLookupContext _db;
    public HomeController(BusinessLookupContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      ViewBag.Shops = _db.Shops.ToList();
      ViewBag.Restaurants = _db.Restaurants.ToList();
      return View();
    }
  }
}
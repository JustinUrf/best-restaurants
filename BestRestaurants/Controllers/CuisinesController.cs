using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class CuisinesController : Controller
  {
    private readonly BestRestaurantsContext _db;

    public CuisinesController(BestRestaurantsContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Cuisine> model = _db.Cuisines.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Cuisine cuisine)
    {
      _db.Cuisines.Add(cuisine);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

       public ActionResult Details(int id)
    {
      Cuisine thisCuisine = _db.Cuisines
                          .Include(cuisine => cuisine.CuisineId)
                          .FirstOrDefault(cuisine => cuisine.CuisineId == id);
      return View(thisCuisine);
    }


  }
}
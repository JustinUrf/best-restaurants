using Microsoft.AspNetCore.Mvc;
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

  }
}


// using Microsoft.AspNetCore.Mvc;
// using BestRestaurants.Models;
// using System.Collections.Generic;
// using System.Linq;

// namespace BestRestaurants.Controllers
// {
//   public class RestaurantsController : Controller
//   {
//     private readonly BestRestaurantsContext _db;

//     public RestaurantsController(BestRestaurantsContext db)
//     {
//       _db = db;
//     }

//     public ActionResult Index()
//     {
//       List<Restaurant> model = _db.Restaurants.ToList();
//       return View(model);
//     }

//     public ActionResult Create()
//     {
//       return View();
//     }

//   }
// }
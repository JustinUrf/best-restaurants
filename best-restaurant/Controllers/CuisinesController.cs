using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;

namespace BestRestaurants.Controllers
{
  public class Restaurants : Controller
  {
    private readonly AnimalShelterContext _db;
    
    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

  }
}
using System.Collections.Generic;
using System;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string CuisineType { get; set; }

    public string Restaurant {get; set;}
    // Not sure if we need a list if we have database?
    // public List<Restaurants> Restaurants { get; set; }
  }
}
using System.Collections.Generic;
using System;

namespace BestRestaurants.Models
{
  public class Cuisine
  {
    public int CuisineId { get; set; }
    public string CuisineType { get; set; }

    public Restaurant Restaurant { get; set; }
    public List<Restaurant> Restaurants { get; set; }
  }
}
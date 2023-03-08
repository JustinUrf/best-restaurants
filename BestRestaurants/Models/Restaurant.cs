using System;
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }
    public List<Cuisine> Cuisines { get; set; }

    public Cuisine Cuisine {get; set;}
  }


}
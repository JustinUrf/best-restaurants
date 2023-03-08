using Microsoft.AspNetCore.Mvc;
using BestRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
namespace BestRestaurants.Controllers;


public class HomeController : Controller
{

  [Route("/")]
  public ActionResult Index() 
  {
    return View();
  }

}
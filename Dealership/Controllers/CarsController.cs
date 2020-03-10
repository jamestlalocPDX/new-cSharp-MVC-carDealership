using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace Dealership.Controllers
{
  public class CarsController : Controller
  {
    [HttpGet("/cars")]
    public ActionResult Cars() 
    { 
      List<Car> allCars = Car.GetAll();
      return View(allCars); 
    }

    [HttpGet("/cars/new")]
    public ActionResult AddCars() 
    { 
      return View(); 
    }

    [HttpPost("/addCar")]
    public ActionResult Create(string makeModel, int price, int miles, string message, string shade)
    {
      Car newCar = new Car(makeModel, price, miles, message, shade);
      return RedirectToAction("AddCars");
    }

    [HttpPost("/clearCars")]
    public ActionResult ClearCars()
    {
      Car.ClearAll();
      return RedirectToAction("Cars");
    }
  }
}
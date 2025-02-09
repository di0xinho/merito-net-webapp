using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetMeritoWebApp.Models;

namespace DotNetMeritoWebApp.Controllers;

public class CarController : Controller
{
    private readonly ILogger<CarController> _logger;

    public CarController(ILogger<CarController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var carsList = new List<CarViewModel>();

        CarViewModel car1 = new CarViewModel{Name = "GLA", Color = "Black", Brand = "Renault" };
        CarViewModel car2 = new CarViewModel{Name = "X5", Color = "Silver", Brand = "BMW" };
        CarViewModel car3 = new CarViewModel{Name = "Roadster", Color = "Gold", Brand = "Fiat" };

        carsList.Add(car1);
        carsList.Add(car2);
        carsList.Add(car3);

        return View(carsList);
    }
}

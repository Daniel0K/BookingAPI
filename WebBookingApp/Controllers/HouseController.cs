using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using WebBookingApp.models;

namespace WebBookingApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HouseController : Controller
{
    private readonly ILogger<HouseController> _logger;

    public HouseController(ILogger<HouseController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetHouses")]
    public IEnumerable<House> Get()
    {
        var data = new[]
        {
            new House()
            {
                Id = 1,
                X = 100,
                Y = 100,
                Bookings = new []
                {
                    new Booking() {StartDate = new DateTime(2022, 01, 02), EndDate = new DateTime(2022, 01, 02)},
                },
                IsActive = false,
                IsNotConfirmed = false,
                Name = "Россия",
                Address = "Калининградская",
                Desc = "Отличная улица"
            }
        };

        return data;
    }
}
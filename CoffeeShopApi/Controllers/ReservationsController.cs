﻿using CoffeeShopApi.Data;
using CoffeeShopApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private CoffeeShopDbContext _coffeeShopDbContext;

        public ReservationsController(CoffeeShopDbContext coffeeShopDbContext)
        {
            _coffeeShopDbContext = coffeeShopDbContext;
        }

        [HttpPost]
        public IActionResult Post(Reservation reservation)
        {
            _coffeeShopDbContext.Reservations.Add(reservation);
            _coffeeShopDbContext.SaveChanges();
            return StatusCode(StatusCodes.Status201Created);
        }
    }
}

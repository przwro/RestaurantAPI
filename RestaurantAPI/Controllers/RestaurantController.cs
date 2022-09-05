using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : ControllerBase
    {
        private readonly RestaurantDbContext dbContext;

        public RestaurantController(RestaurantDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Restaurant>> GetAll()
        {
            var restuarants = dbContext.Restaurants.ToList();

            return Ok(restuarants);
        }

        [HttpGet("{id}")]
        public ActionResult<Restaurant> Get([FromRoute] int id)
        {
            var restaurant = dbContext.Restaurants.FirstOrDefault(r => r.Id == id);

            if(restaurant is null)
            {
                return NotFound();
            }

            return Ok(restaurant);
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLookup.Models;

namespace BusinessLookup.Controllers
{
  [Route("restaurants")]
  [ApiController]
  public class RestaurantsController : ControllerBase
  {
    private readonly BusinessLookupContext _db;

    public RestaurantsController(BusinessLookupContext db)
    {
      _db = db;
    }

[HttpGet]
public ActionResult<IEnumerable<Restaurant>> Get(string name, string food, string number)
{
    var query = _db.Restaurants.AsQueryable();

    if (name != null)
    {
    query = query.Where(entry => entry.Name == name);
    }

    if (food != null)
    {
    query = query.Where(entry => entry.Food == food);
    }

    if (number != null)
    {
    query = query.Where(entry => entry.Number == number);
    }

    
   

    return query.ToList();
}


    
    [HttpGet("{id}")]
    public async Task<ActionResult<Restaurant>> GetRestaurant(int id)
    {
        var restaurant = await _db.Restaurants.FindAsync(id);

        if (restaurant == null)
        {
            return NotFound();
        }

        return restaurant;
    }


    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Restaurant restaurant)
    {
      if (id != restaurant.RestaurantId)
      {
        return BadRequest();
      }

      _db.Entry(restaurant).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!RestaurantExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    
    [HttpPost]
    public async Task<ActionResult<Restaurant>> Post(Restaurant restaurant)
    {
      _db.Restaurants.Add(restaurant);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetRestaurant), new { id = restaurant.RestaurantId }, restaurant);
    }

 
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRestaurant(int id)
    {
      var restaurant = await _db.Restaurants.FindAsync(id);
      if (restaurant == null)
      {
        return NotFound();
      }

      _db.Restaurants.Remove(restaurant);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool RestaurantExists(int id)
    {
      return _db.Restaurants.Any(e => e.RestaurantId == id);
    }
  }
}
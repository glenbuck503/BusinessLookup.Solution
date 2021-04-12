using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BusinessLookup.Models;

namespace BusinessLookup.Controllers
{
  [Route("shops")]
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private readonly BusinessLookupContext _db;

    public ShopsController(BusinessLookupContext db)
    {
      _db = db;
    }

   
[HttpGet]
public ActionResult<IEnumerable<Shop>> Get(string name, string goods, string number)
{
    var query = _db.Shops.AsQueryable();

    if (name != null)
    {
    query = query.Where(entry => entry.Name == name);
    }

    if (goods != null)
    {
    query = query.Where(entry => entry.Goods == goods);
    }

    if (number != null)
    {
    query = query.Where(entry => entry.Number == number);
    }

    
   

    return query.ToList();
}


   
    [HttpGet("{id}")]
    public async Task<ActionResult<Shop>> GetShop(int id)
    {
        var shop = await _db.Shops.FindAsync(id);

        if (shop == null)
        {
            return NotFound();
        }

        return shop;
    }

    
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Shop shop)
    {
      if (id != shop.ShopId)
      {
        return BadRequest();
      }

      _db.Entry(shop).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ShopExists(id))
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
    public async Task<ActionResult<Shop>> Post(Shop shop)
    {
      _db.Shops.Add(shop);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetShop), new { id = shop.ShopId }, shop);
    }

  
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShop(int id)
    {
      var shop = await _db.Shops.FindAsync(id);
      if (shop == null)
      {
        return NotFound();
      }

      _db.Shops.Remove(shop);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ShopExists(int id)
    {
      return _db.Shops.Any(e => e.ShopId == id);
    }
  }
}
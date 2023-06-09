using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AmericasParksApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace AmericasParksApi.Controllers.v2
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("2.0")]
  public class ParksController : ControllerBase
  {
    private readonly AmericasParksApiContext _db;

    public ParksController(AmericasParksApiContext db)
    {
      _db = db;
    }

    // GET api/park
    [HttpGet]
    [EnableCors("Policy1")]
    public async Task<List<Park>> Get(string name, string type, string location, string dateEstablished, int pageNumber, int pageSize)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (dateEstablished != null)
      {
        query = query.Where(entry => entry.DateEstablished == dateEstablished);
      }

      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      if (location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      return await query.ToListAsync();
    }

    // GET: api/park/5
    [HttpGet("{id}")]
    [EnableCors("Policy1")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if (park == null)
      {
        return NotFound();
      }

      return park;
    }

    [HttpGet("random")]
    [EnableCors("Policy1")]
    public async Task<ActionResult<Park>> GetRandomPark()
    {
      List<Park> parks = await _db.Parks.ToListAsync();
      int random = new Random().Next(parks.Count);
      return parks[random];
    }

    // POST: api/Parks
    [HttpPost]
    [EnableCors("Policy1")]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT: api/Parks/5
    [HttpPut("{id}")]
    [EnableCors("Policy1")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    // DELETE: api/Parks/5
    [HttpDelete("{id}")]
    [EnableCors("Policy1")]
    public async Task<IActionResult>DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }
      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
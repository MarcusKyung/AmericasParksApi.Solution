using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AmericasParksApi.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace AmericasParksApi.Controllers.v1
{
  [ApiController]
  [Route("api/v{version:apiVersion}/[controller]")]
  [ApiVersion("1.0")]
  public class ParksController : ControllerBase
  {
    private readonly AmericasParksApiContext _db;

    public ParksController(AmericasParksApiContext db)
    {
      _db = db;
    }

    // GET api/reviews
    [HttpGet]
    public async Task<List<Park>> Get(string name, string type, string location, int pageNumber, int pageSize)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
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
  }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SarahBdayApi.Models;

namespace SarahBdayApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AttendantsController : ControllerBase
{
    private readonly SarahBdayApiContext _db;
    public AttendantsController(SarahBdayApiContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Attendant>>> Get()
    {
        return await _db.Attendants.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Attendant>> GetAttendant(int id)
    {
        Attendant attendant = await _db.Attendants.FindAsync(id);

        if (attendant == null)
        {
            return NotFound();
        }

        return attendant;
    }

    [HttpPost]
    public async Task<ActionResult<Attendant>> Post(Attendant attendant)
    {
        _db.Attendants.Add(attendant);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAttendant), new { id = attendant.AttendantId }, attendant);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Attendant attendant)
    {
        if (id != attendant.AttendantId)
        {
            return BadRequest();
        }

        _db.Attendants.Update(attendant);

        try
        {
            await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!AttendantExists(id))
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

    [HttpDelete ("{id}")]
    public async Task<IActionResult> DeleteAttendant(int id)
    {
        Attendant attendant = await _db.Attendants.FindAsync(id);
        if (attendant == null)
        {
            return NotFound();
        }

        _db.Attendants.Remove(attendant);
        await _db.SaveChangesAsync();

        return NoContent();
    }

    private bool AttendantExists(int id)
    {
        return _db.Attendants.Any(e => e.AttendantId == id);
    }
}

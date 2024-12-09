using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YalabenaApi.Data;
using YalabenaApi.Models;

namespace YalabenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItinerariesController : ControllerBase
    {
        private readonly YalabenaDbContext _context;

        public ItinerariesController(YalabenaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Itinerary>>> GetItineraries()
        {
            return await _context.Itineraries.Include(i => i.User).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Itinerary>> GetItinerary(int id)
        {
            var itinerary = await _context.Itineraries.Include(i => i.User).FirstOrDefaultAsync(i => i.ItineraryID == id);
            if (itinerary == null)
            {
                return NotFound();
            }
            return itinerary;
        }

        [HttpPost]
        public async Task<ActionResult<Itinerary>> CreateItinerary(Itinerary itinerary)
        {
            _context.Itineraries.Add(itinerary);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetItinerary), new { id = itinerary.ItineraryID }, itinerary);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItinerary(int id, Itinerary itinerary)
        {
            if (id != itinerary.ItineraryID)
            {
                return BadRequest();
            }

            _context.Entry(itinerary).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItinerary(int id)
        {
            var itinerary = await _context.Itineraries.FindAsync(id);
            if (itinerary == null)
            {
                return NotFound();
            }

            _context.Itineraries.Remove(itinerary);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}

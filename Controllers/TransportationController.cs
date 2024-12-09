using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YalabenaApi.Data;
using YalabenaApi.Models;

namespace YalabenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportationController : ControllerBase
    {
        private readonly YalabenaDbContext _context;

        public TransportationController(YalabenaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transportation>>> GetTransportations()
        {
            return await _context.Transportations.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transportation>> GetTransportation(int id)
        {
            var transportation = await _context.Transportations.FindAsync(id);
            if (transportation == null)
            {
                return NotFound();
            }
            return transportation;
        }

        [HttpPost]
        public async Task<ActionResult<Transportation>> CreateTransportation(Transportation transportation)
        {
            _context.Transportations.Add(transportation);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetTransportation), new { id = transportation.Transport_Id }, transportation);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTransportation(int id, Transportation transportation)
        {
            if (id != transportation.Transport_Id)
            {
                return BadRequest();
            }

            _context.Entry(transportation).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransportation(int id)
        {
            var transportation = await _context.Transportations.FindAsync(id);
            if (transportation == null)
            {
                return NotFound();
            }

            _context.Transportations.Remove(transportation);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}

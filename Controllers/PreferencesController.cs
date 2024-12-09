using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YalabenaApi.Data;
using YalabenaApi.Models;
namespace YalabenaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PreferencesController : ControllerBase
    {
        private readonly YalabenaDbContext _context;

        public PreferencesController(YalabenaDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Preference>>> GetPreferences()
        {
            return await _context.Preferences_Users.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Preference>> GetPreference(int id)
        {
            var preference = await _context.Preferences_Users.FindAsync(id);
            if (preference == null)
            {
                return NotFound();
            }
            return preference;
        }

        [HttpPost]
        public async Task<ActionResult<Preference>> CreatePreference(Preference preference)
        {
            _context.Preferences_Users.Add(preference);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPreference), new { id = preference.Prre_Id }, preference);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePreference(int id, Preference preference)
        {
            if (id != preference.Prre_Id)
            {
                return BadRequest();
            }

            _context.Entry(preference).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePreference(int id)
        {
            var preference = await _context.Preferences_Users.FindAsync(id);
            if (preference == null)
            {
                return NotFound();
            }

            _context.Preferences_Users.Remove(preference);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }

}

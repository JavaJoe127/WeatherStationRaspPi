using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeatherStation.Models;

namespace WeatherStation.Pages.WeatherStats
{
    public class EditModel : PageModel
    {
        private readonly WeatherStationContext _context;

        public EditModel(WeatherStationContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.WeatherStats WeatherStats { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WeatherStats = await _context.WeatherStats.FirstOrDefaultAsync(m => m.Id == id);

            if (WeatherStats == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(WeatherStats).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherStatsExists(WeatherStats.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WeatherStatsExists(Guid id)
        {
            return _context.WeatherStats.Any(e => e.Id == id);
        }
    }
}

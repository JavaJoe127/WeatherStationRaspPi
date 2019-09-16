using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeatherStation.Models;

namespace WeatherStation.Pages.WeatherStats
{
    public class DeleteModel : PageModel
    {
        private readonly WeatherStationContext _context;

        public DeleteModel(WeatherStationContext context)
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

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            WeatherStats = await _context.WeatherStats.FindAsync(id);

            if (WeatherStats != null)
            {
                _context.WeatherStats.Remove(WeatherStats);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

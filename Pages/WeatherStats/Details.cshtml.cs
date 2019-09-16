using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeatherStation.Models;

namespace WeatherStation.Pages.WeatherStats
{
    public class DetailsModel : PageModel
    {
        private readonly WeatherStationContext _context;

        public DetailsModel(WeatherStationContext context)
        {
            _context = context;
        }

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
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WeatherStation.Models;

namespace WeatherStation.Pages.WeatherStats
{
    public class IndexModel : PageModel
    {
        private readonly WeatherStationContext _context;

        public IndexModel(WeatherStationContext context)
        {
            _context = context;
        }

        public IList<Models.WeatherStats> WeatherStats { get;set; }

        public async Task OnGetAsync()
        {
            WeatherStats = await _context.WeatherStats.ToListAsync();
        }
    }
}

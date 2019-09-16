using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeatherStation.Models;

namespace WeatherStation.Pages.WeatherStats
{
    public class CreateModel : PageModel
    {
        private readonly WeatherStationContext _context;

        public CreateModel(WeatherStationContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Models.WeatherStats WeatherStats { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.WeatherStats.Add(WeatherStats);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
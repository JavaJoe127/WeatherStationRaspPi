using Microsoft.EntityFrameworkCore;

namespace WeatherStation.Models
{
    public class WeatherStationContext : DbContext
    {
        public WeatherStationContext (DbContextOptions<WeatherStationContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherStats> WeatherStats { get; set; }
    }
}

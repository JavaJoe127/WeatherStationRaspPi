using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherStation.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WeatherStationContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WeatherStationContext>>()))
            {
                // look for any records.
                if (context.WeatherStats.Any())
                {
                    return; // DB has records.
                }

                context.WeatherStats.AddRange(
                    new WeatherStats
                    {
                        DateStamp = DateTime.Now.AddMinutes(-2),
                        TempFahrenheit = 999,
                        TempCelsius = 999,
                        Humidity = 999,
                        Pressure = 999
                    },

                    new WeatherStats
                    {
                        DateStamp = DateTime.Now.AddMinutes(-1),
                        TempFahrenheit = 999,
                        TempCelsius = 999,
                        Humidity = 999,
                        Pressure = 999
                    },

                    new WeatherStats
                    {
                        DateStamp = DateTime.Now,
                        TempFahrenheit = 999,
                        TempCelsius = 999,
                        Humidity = 999,
                        Pressure = 999
                    }
                );
                context.SaveChanges();
            }

        }
    }
}

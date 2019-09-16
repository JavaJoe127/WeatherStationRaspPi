using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherStation.Models
{
    public class WeatherStats
    {
        public Guid Id { get; set; }

        [Display(Name = "DateTime Stamp")]
        [DataType(DataType.DateTime)]
        public DateTime DateStamp { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Temp Fahrenheit")]
        public decimal TempFahrenheit { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Temp Celsius")]
        public decimal TempCelsius { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Display(Name = "Pressure (inHg)")]
        public decimal Pressure { get; set; }
        public int Humidity { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherStation.Conversions
{
    public class Temperature
    {
        private const double CONV_MULTIPLIER = 1.8;
        private const double CONV_ADD = 32.0;

        public static decimal ToFahrenheit(double celsius)
        {
            double ret = ((CONV_MULTIPLIER * celsius) + CONV_ADD);
            return Rounding.RoundToSignificantFigures(ret, 6);
        }

        public static decimal ToCelsius(double fahrenheit)
        {
            double ret = ((fahrenheit - CONV_ADD) / CONV_MULTIPLIER);
            return Rounding.RoundToSignificantFigures(ret, 6);
        }
    }
}

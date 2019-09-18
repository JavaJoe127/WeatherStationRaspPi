using NUnit.Framework;
using WeatherStation.Conversions;

namespace WeatherStationTests
{
    public class WeatherStationTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Round_Number_Down_Test()
        {
            const decimal retExpect = 11.4M;
            double beginNumber = 11.449;
            int power = 3;

            var retValue = Rounding.RoundToSignificantFigures(beginNumber, power);
            Assert.That(retValue == retExpect, "retValue = {0}", retValue.ToString());
        }

        [Test]
        public void Round_Number_Up_Test()
        {
            const decimal retExpect = 11.5M;
            double beginNumber = 11.49;
            int power = 3;

            var retValue = Rounding.RoundToSignificantFigures(beginNumber, power);
            Assert.That(retValue == retExpect, "retValue = {0}", retValue.ToString());
        }

        [Test]
        public void Convert_Fahrenheit_to_Celsius_Test()
        {
            const decimal retExpect = 0;
            double beginTempF = 32;

            var retValue = Temperature.ToCelsius(beginTempF);
            Assert.That(retValue == retExpect, "retValue = {0}", retValue.ToString());
        }

        [Test]
        public void Convert_Celsius_to_Fahrenheit_Test()
        {
            const decimal retExpect = 32;
            double beginTempC = 0;

            var retValue = Temperature.ToFahrenheit(beginTempC);
            Assert.That(retValue == retExpect, "retValue = {0}", retValue.ToString());
        }
    }
}
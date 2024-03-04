using System;

namespace WeatherStationV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Barometer barometer = new Barometer();

            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            barometer.Pressure = 979;
            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            barometer.Pressure = 980;
            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            barometer.Pressure = 1000;
            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            barometer.Pressure = 1020;
            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            barometer.Pressure = 1040;
            Console.WriteLine(barometer.Pressure);
            Console.WriteLine(barometer.WeatherDescription);

            // The LAST line of code should be ABOVE this line
        }
    }
}
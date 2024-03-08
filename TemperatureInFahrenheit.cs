using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FewMoreConcepts1
{
    public class TemperatureInFahrenheit
    {
        public void Temp()
        {
            int fahrenheit = 94;
            int celsius = 94 - 32;
            Console.WriteLine(celsius);
            decimal division = (decimal)5 / (decimal)9;
            Console.WriteLine(division);

            decimal ConvertTemp = celsius * division;
            Console.WriteLine(ConvertTemp);
            Console.WriteLine($"The temperature is {ConvertTemp} Celsius");

            decimal celsius1 = (fahrenheit - (decimal)32) * ((decimal)5 / (decimal)9);
            decimal celsius2 = (fahrenheit - 32m) * (5m / 9m);

            Console.WriteLine("The temperature is " + celsius + " Celsius.");
            Console.WriteLine("The temperature is " + celsius1 + " Celsius.");
            Console.WriteLine("The temperature is " + celsius2 + " Celsius.");
            Console.WriteLine("Windows" + 1 + 1 );

            int result = 3 + 1 * 5 / 2;
            Console.WriteLine(result);
            Console.WriteLine(5 / 10);

        }
    }
}

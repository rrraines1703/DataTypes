using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gas;
            double mpg;
            string inputMiles;
            string inputGas;

            Console.WriteLine("How many miles have you driven?");
            inputMiles = Console.ReadLine();
            miles = double.Parse(inputMiles);

            Console.WriteLine("How many gallons of gas have you used?");
            inputGas = Console.ReadLine();
            gas = double.Parse(inputGas);

            mpg = miles / gas;

            Console.WriteLine("Your car got " + mpg + " miles-per-gallon");
        }
    }
}

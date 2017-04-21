using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus18
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars;

            Car Car1 = new Car();
            Car Car2 = new Car("Chevy", "Impala", 1990, 16700.00);

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.WriteLine("How many cars are you entering: ");
            numOfCars = int.Parse(Console.ReadLine());

            Console.WriteLine("You are entering {0} cars", numOfCars);
            Console.WriteLine($"Car make: {Car1.CarMake} Car Model: {Car1.CarModel} Make Year: {Car1.CarYear} Price: {Car1.CarPrice}");
        }
    }
}

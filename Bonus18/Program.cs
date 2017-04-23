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

            Console.Title = "Grand Circus Mototrs Admin Console";

            Console.WriteLine("Welcome to the Grand Circus Motors admin console!");
            Console.WriteLine("How many cars are you entering: ");
            numOfCars = int.Parse(Console.ReadLine());

            Car[] ListOfCars = new Car[numOfCars];

            //Prompts user for the make, model, year, and price of each car.  
            GetCarInfo(numOfCars, ListOfCars);

            //Create a table of cars.
            GetTableOfCars(numOfCars, ListOfCars);

        }

            public static void GetTableOfCars(int numOfCars, Car[] ListOfCars)
        {
            Console.WriteLine("Current inventory: ");
            for (int i =0; i < numOfCars; i++)
                Console.WriteLine($"{ListOfCars[i].CarMake}\t{ListOfCars[i].CarModel}\t{ListOfCars[i].CarYear}\t{ListOfCars[i].CarPrice}");
        }

        public static void GetCarInfo(int numOfCars, Car[] ListOfCars)
        {
            for (int i = 0; i < numOfCars; i++)
            {
                ListOfCars[i] = new Car();
                Console.Write($"Enter Car #{i + 1} Make: ");
                ListOfCars[i].CarMake = Console.ReadLine();

                Console.Write($"Enter Car #{i + 1} Model: ");
                ListOfCars[i].CarModel = Console.ReadLine();

                Console.Write($"Enter Car #{i + 1} Year: ");
                ListOfCars[i].CarYear = GetIntegerInRange(1885, 2018);

                Console.Write($"Enter Car #{i + 1} Price: ");
                ListOfCars[i].CarPrice = GetDoubleInRange(0, 999999.9);

                Console.WriteLine();
            }
        }

        public static int GetValidInteger()
        {
            int input; 
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input...");
            }
            return input; 
        }

        public static int GetIntegerInRange(int min, int max)
        {
            int input = GetValidInteger();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                Console.ForegroundColor = ConsoleColor.White;
                input = GetValidInteger();
            }
            return input;
        }

        public static double GetValidDouble()
        {
            double input; 
            while (!double.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Please enter a valid input!");
            }
            return input;
        }

        public static double GetDoubleInRange(double min, double max)
        {
            double input = GetValidDouble();
            while (input < min || input > max)
            {
                Console.WriteLine("Please enter an integer between {0} and {1}.", min, max);
                Console.ForegroundColor = ConsoleColor.White;
                input = GetValidDouble();
            }
            return input;
        }
      }
        
  }
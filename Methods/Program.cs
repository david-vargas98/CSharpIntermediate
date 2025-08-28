using Methods.Models;
using System.Collections.Concurrent;

namespace Methods
{
    internal class Program
    {
        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20); // Default constructor
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");

                point.Move(null); // first overload
                Console.WriteLine($"1st overload, point is at ({point.X}, {point.Y})");

                point.Move(100, 200);
                Console.WriteLine($"2nd overload, point is at ({point.X}, {point.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error ocurred.");
            }
        }
        
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2)); // easier way
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));
        }
        static void Main(string[] args)
        {
            // Parse approach, program CRASHES
            //So we need to handle the exception
            try
            {
                var num = int.Parse("asdv");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed.");
            }

            // tryParse approach
            int number;
            var result = int.TryParse("asdv", out number);

            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }
    }
}

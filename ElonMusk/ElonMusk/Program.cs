using System;
using System.Runtime.ConstrainedExecution;

namespace ElonMusk
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiating object
            Car car = new Car();
            Car car2 = new Car();

            // Setting car colour property
            car.Colour = "Yellow";
            car2.Colour = "Red";

            // Setting car battery property
            car.Battery = 100;
            car2.Battery = 100;

            // Loops 101 times to check if everything works as planned
            for (int i = 0; i < 101; i++)
            {
                car.Drive();
                Console.WriteLine();
                car2.Drive();
                Console.WriteLine();
            }
        }
    }
}
using System;
using System.Runtime.ConstrainedExecution;

namespace ElonMusk
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Car car2 = new Car();

            car.Colour = "Yellow";
            car2.Colour = "Red";

            car.Battery = 100;
            car2.Battery = 100;

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
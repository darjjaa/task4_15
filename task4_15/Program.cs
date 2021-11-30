using System;
using System.IO;

namespace task4_15
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("AUTO", 59, 5);
            Console.WriteLine(auto);
            auto.EnginePower = 75;
            Console.WriteLine(auto);
            auto.NumberOfSeats = 2;
            Console.WriteLine(auto);

            Car car = new Car ("CAR", 90, 7, 2012);
            Console.WriteLine("Текущий год: "+ car.T+"\n");
            Console.WriteLine(car);
            car.EnginePower = 80;
            Console.WriteLine(car);
            car.P = 2005;
            Console.WriteLine(car);
            car.NumberOfSeats = 5;
            Console.WriteLine(car);
        }
    }
}
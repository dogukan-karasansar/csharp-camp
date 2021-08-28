using System;

namespace csharpCamp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] cars = { "bmw", "opel", "mercedes" };
            for(int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            foreach(string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}

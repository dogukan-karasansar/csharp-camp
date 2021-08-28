using System;

namespace csharpCamp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Name: ");
            Console.WriteLine();
            name = Console.ReadLine();
            Console.Write("Age: ");
            Console.WriteLine();
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mr. " + name + " you are " + age + " years old");
        }
    }
}

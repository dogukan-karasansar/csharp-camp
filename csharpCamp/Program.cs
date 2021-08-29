using System;

namespace csharpCamp
{
    class MainClass
    {
        

        public static void Main(string[] args)
        {
            Car opel = new Car("Astra", 2011, "Siyah");
            Person person = new Person();
            person.name = "Doğukan";
            person.Age = 19;
            Console.WriteLine(person.name);
            
            Console.WriteLine(opel.color);        

        }
    }
}

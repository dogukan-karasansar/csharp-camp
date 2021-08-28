using System;

namespace csharpCamp
{
    class MainClass
    {
        public static bool CalculateLicense(int age)
        {
            bool status;
            
            if(age >= 18)
            {
                status = true;
            } else
            {
                status = false;
            }
            return status;
        }

        public static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Yaşınızı Girin: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (CalculateLicense(age))
            {
                Console.WriteLine("Ehliyet Alabilir");
            } else
            {
                Console.WriteLine("Ehlitey Alamaz");
            }
            
           
        }
    }
}

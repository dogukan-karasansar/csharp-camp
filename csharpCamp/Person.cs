using System;
namespace csharpCamp
{
    public class Person
    {
        public string name
        { get; set; }

        private int age;
        public int Age
        { get => age; set => age = value; }

        public Person()
        {
        }
    }
}

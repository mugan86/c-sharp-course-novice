using System;

namespace Constructors
{
    class Person {
        
        public string Name;

        public Person() {
            Name = "Anartz Mugika";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pOne = new Person();
            Console.WriteLine(pOne.Name);
            Person pTwo = new Person();
            pTwo.Name = "Mikel";
            Console.WriteLine(pTwo.Name);
        }
    }
}

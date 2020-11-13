using System;

namespace Constructors
{
    class Person {
        
        public string Name;
        public string LastName;
        public int Age;

        public Person() {
            Name = "Anartz";
            LastName = "Mugika";
            Age = 34;
        }

        public Person(string name, string lastname) {
            Name = name;
            LastName = lastname;
            Age = 18;
        }
        public Person(string name, string lastname, int age) {
            Name = name;
            LastName = lastname;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person pOne = new Person();
            Console.WriteLine( pOne.Name + " " + pOne.LastName + " " + pOne.Age);
            Person pTwo = new Person("Mikel", "Martinez", 45);
            Console.WriteLine(pTwo.Name + " " + pTwo.LastName + " " + pTwo.Age);
            Person pThree = new Person("Aitor", "Aitor");
            Console.WriteLine(pThree.Name + " " + pThree.LastName + " " + pThree.Age);
        }
    }
}

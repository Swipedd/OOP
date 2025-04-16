using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace les4
{
    public class Lion : Animal
    {
        public Lion(string name, int age)
        {
            Name = name;
            Species = "Lion";
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating meat.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} roars.");
        }
    }

    public class Elephant : Animal
    {
        public Elephant(string name, int age)
        {
            Name = name;
            Species = "Elephant";
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating plants.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} trumpets.");
        }
    }

    public class Giraffe : Animal
    {
        public Giraffe(string name, int age)
        {
            Name = name;
            Species = "Giraffe";
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating leaves.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} moos.");
        }
    }

    public class Monkey : Animal
    {
        public Monkey(string name, int age)
        {
            Name = name;
            Species = "Monkey";
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating fruits.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} screeches.");
        }
    }

    public class Zebra : Animal
    {
        public Zebra(string name, int age)
        {
            Name = name;
            Species = "Zebra";
            Age = age;
        }

        public override void Eat()
        {
            Console.WriteLine($"{Name} is eating grass.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} neighs.");
        }
    }
}

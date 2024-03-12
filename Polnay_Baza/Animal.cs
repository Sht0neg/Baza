using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polnay_Baza
{
    abstract class Animal
    {
        private string name;

        public string Name { get => name; set => name = value; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Gav-Gav");
        }
    }

    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("May-May");
        }
    }

    class Parrot : Animal
    {
        public Parrot(string name) : base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Car-Car");
        }
    }
}

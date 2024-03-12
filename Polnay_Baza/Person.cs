using Polnay_Baza;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Empioyeed work = new("Андрей", 23, "Вкусно и Точка");
//Person work = new("Андрей", 23);
//work.Age = 10;
//Console.WriteLine(work.Age);

namespace Polnay_Baza
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = (value >= 0 && value < 130) ? value : age; }
    }

    class Empioyeed : Person
    {
        private string company;
        public Empioyeed(string name, int age, string company) : base(name, age)
        {
            this.company = company;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BazaDz2
{
    internal class User
    {
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; private set => age = (value >= 0 && value <= 130) ? value : age; }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}

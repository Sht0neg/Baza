using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza_F
{
    internal class Employee
    {
        private string name;
        private string salary;

        protected string Name { get => name; set => name = value; }
        protected string Salary { get => salary; set => salary = value; }

        public Employee()
        {
        }

        protected Employee(string name, string salary)
        {
            this.Name = name;
            this.Salary = salary;
        }

        virtual public void Work() {
            Console.WriteLine("Сотрудник работает!");
        }
    }

    internal class Manager : Employee {

        private int bonus;

        public int Bonus { get => bonus; set => bonus = value; }

        public Manager()
        {
        }

        public Manager(int bonus, string name, string salary) : base(name, salary)
        {
            Bonus = bonus;
        }
        public override void Work()
        {
            Console.WriteLine("Наблюдает");
        }
    }

    internal class Developer : Employee {
        private string programmingLanguage;
        public string ProgrammingLanguage { get => programmingLanguage; set => programmingLanguage = value; }

        public Developer()
        {
        }

        public Developer(string programmingLanguage, string name, string salary) : base(name, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void Work()
        {
            Console.WriteLine("Что-то делает");
        }
    }

}

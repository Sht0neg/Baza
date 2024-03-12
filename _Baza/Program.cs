using Company;
using System.Drawing;


Person person = new Person("Mark", 2);
Person person1 = person;
Person person2 = person with { name = "Ivan"};
void changeCar(Car car) {
    car.Color = "Green";
}


struct Person {
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Print() {
        Console.WriteLine($"{name} {age}");
    }
}

class Car(string mark, string color) {
    public string Mark { get => mark; set => mark = value; }
    public string Color { get => color; set => color = value; }
}
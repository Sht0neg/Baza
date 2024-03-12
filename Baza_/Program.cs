
Point point = new Point { x = 18, y = 19 };
(float x, float y) = point;
Console.WriteLine($"A({x};{y})");

// See https://aka.ms/new-console-template for more information
class Person {
    public int age;
    public String name;

    public void Print() {
        Console.WriteLine($"Имя: {this.name}, возраст: {this.age}");
    }

    public Person(int age, string name) {
        this.age = age;
        this.name = name;
    }

    public Person(string name) : this(0, name) { }
}

class Company(string titel, int peopleCount) {
    public void Print() {
        Console.WriteLine("Компания {0} численность в {1} человек", titel, peopleCount);
    }
}

class Point {
    public float x;
    public float y;

    public void Deconstruct(out float x, out float y) {
        x = this.x;
        y = this.y;
    }

}
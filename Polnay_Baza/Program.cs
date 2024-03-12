using Polnay_Baza;

internal class Programs
{
    public static void Main(string[] args)
    {
        Figure[] figures = { new Circle("red", 4.5f), new Rectangle("blue", 4.5f, 6.7f), new Triangle("pink", 4.5f, 6.7f, 5.5f, 3) };
        foreach (Figure i in figures) {
            Console.WriteLine($"Цвет: {i.Color}, S = {i.Area()}, P = {i.Perimetr()}");
        }

        Animal[] animals = { new Dog("Reks"), new Cat("Barsik"), new Parrot("Cesha") };
        foreach (Animal i in animals) {
            i.Say();
        }
    }
}
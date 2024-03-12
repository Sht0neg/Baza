using BazaDz2;
using BazaDz2_;

User u = new User("Lox", 20);
User u2 = new("Lox2", -10);

Console.WriteLine(u2.Age);

AccessManager ac = new AccessManager(18);

Console.WriteLine(ac.Check(u));
Console.WriteLine(ac.Check(u2));

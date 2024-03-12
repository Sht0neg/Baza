// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
string[] names = new string[5];
int[] marks = [1, 2, 5, 6];
foreach (int i in marks)
{
    Console.WriteLine($"Your mark: {i}");
}

void printHello(string msg) { 
    Console.WriteLine($"Hello, {msg}");
}

void printGoodbye() => Console.WriteLine("Goodbye");

string[] createList(params string[] args)
{
    string[] list = new string[args.Length];
    for (int i = 0; i < args.Length; i++)
    {
        list[i] = args[i];
    }
    return list;
}
*/
/*int a, b, c, d, e;
Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());
e = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum: {a + b + c + d + e}, Max: {Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))))}, Min: {Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))))}, Pr: {a * b * c * d * e}");
int f = Convert.ToInt32(Console.ReadLine());
string f1 = Convert.ToString(f);
Console.WriteLine(Convert.ToInt32($"{f1[5]}{f1[4]}{f1[3]}{f1[2]}{f1[1]}{f1[0]}"));
int g = Convert.ToInt32(Console.ReadLine());
int g0 = 0;
int g1 = 1;
Console.Write($"{g0}, {g1}");
while (true) {
    int gl = g1 + g0;
    if (gl > g) {
        break;
    }
    g0 = g1;
    g1 = gl;
    Console.Write($", {gl}");
}
Console.WriteLine();
*/
/*
int h = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
for (int i = h; i <= k; i++) {
    string temp = "";
    for (int j = 0; j < i; j++) {
        temp += Convert.ToString(i);
    }
    Console.WriteLine($"{temp}");
}
int n = Convert.ToInt32(Console.ReadLine());
string sym = Console.ReadLine();
Console.WriteLine("Если хотите вывести знаки по горизонтале введите 1, а если по вертикале 2");
int chan = Convert.ToInt32(Console.ReadLine());
if (chan == 1)
{
    string temp = "";
    for (int i = 0; i < n; i++)
    {
        temp += sym;
    }
    Console.WriteLine($"{temp}");
}
else if (chan == 2) {
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(sym);
    }
}
*/



public class Person {
    public string name;
    public int age { get; set; }
    public void Print() {
        Console.WriteLine($"FirstName: {this.name}, age: {this.age}");
    }
}


/*
int[] arr = new int[] { 3, 4, 5 };
plussArray(arr);
foreach(int num in arr){
    Console.WriteLine(num);
}

int a = 12;
swapDigit(ref a);
Console.WriteLine(a);
void plussArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++) {
        numbers[i] += 1;
    }
}

void swapDigit(ref int a) { 
    a = a % 10 * 10 + a / 10;
}
*/
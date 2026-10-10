
partial class Program
{
    static void DataStructures()
    {

        User person1 = new User { Name = "Ana" };
        User person2 = person1;

        person2.Name = "Luis";

        Console.WriteLine(person1.Name); // Luis



        Point point1 = new Point { X = 10, Y = 20 };
        Point point2 = point1;

        point2.X = 100;

        Console.WriteLine(point1.X); // 10
        Console.WriteLine(point2.X); // 100


        Profesor profesor1 = new Profesor("Ana", 30);
        Profesor profesor2 = new Profesor("Ana", 30);

        Console.WriteLine(profesor1 == profesor2); // True

    }
}

class User
{
    public string? Name { get; set; }

    public void SayHello()
    {
        Console.WriteLine($"Hola, soy {Name}");
    }
}

struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}


record Profesor(string Name, int Age);

partial class Program
{

    public static void InheritanceAttribute()
    {
        HogartStudent student = new HogartStudent() { Name = "Harry Potter", House = "Gryffindor" };
        HogartProfessor profesor = new HogartProfessor() { Name = "Severus Snape", Subject = "Pociones" };


        student.Greet();
        student.ShowHouse();

        profesor.Greet();
        profesor.MySubject();
    }

}


// Clase padre
class Character
{
    public string? Name { get; set; }

    public virtual void Greet()
    {
        WriteLine($"Hola, soy {Name}");
    }
}



class HogartStudent : Character
{
    public string? House { get; set; }

    public override void Greet()
    {
        WriteLine($"Hola, soy {Name} y soy estudiante");
    }

    public void ShowHouse()
    {
        WriteLine($"Pertenezco a la casa {House} en Howard");
    }
}


class HogartProfessor : Character
{
    public string? Subject { get; set; }
    public override void Greet()
    {
        WriteLine($"Hola, soy {Name} y soy profesor");
    }

    public void MySubject()
    {
        WriteLine($"Enseño {Subject} en Hogwarts");
    }
}
partial class Program
{
    static void Properties()
    {
        Animal animal = new Animal("Bosque");
        animal.Species = "Lobo";
        animal.Age = 5;
        WriteLine($"Donde vive: {animal.Habitad}, qué animal es: {animal.Species}, qué categoria tiene: {animal.Category}");

    }
}

class Animal
{
    public string? Species { get; set; } = "Desconocida";
    public string? Category { get; } = "Vertebrado";
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("La edad no puede ser negativa");
            }
            age = value;
        }
    }

    public string Habitad { get; }

    public Animal(string habitad)
    {
        Habitad = habitad;
    }

}
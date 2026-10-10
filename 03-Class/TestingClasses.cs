partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new Vehicle();
        toyota.Brand = "Toyota";
        toyota.Model = "Corola";
        toyota.Year = 2021;
        toyota.ShowInfo();

        Vehicle honda = new Vehicle { Brand = "Honda", Model = "Civic", Year = 2025 };
        honda.ShowInfo();


        Vehicle renault = new Vehicle("Renault", "Duster", 2024);
        renault.ShowInfo();





    }
}

class Vehicle
{
    // Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    // Constructor
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle()
    { }

    // Metodos
    public void ShowInfo()
    {
        WriteLine($"Este vehiculo es un {Brand} {Model} del año {Year}");
    }
}
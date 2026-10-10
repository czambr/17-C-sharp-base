partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        WriteLine(car.ShowInfo());
        // car.ShowMessage();

        // car.ShowMessage("Cambiando de modelo...");

        // car.ChangeModel("Patrol");
        // WriteLine(car.ShowInfo());

        // Car.GeneralInfo();

        // Un constructor
        Car sportCar = new Car("Ferrary", 2020);
        WriteLine(sportCar.ShowInfo());

        // Constructor sintaxis simplicada
        Car collectionCar = new Car { Model = "Cadillac", Year = 1980 };
        WriteLine(collectionCar.ShowInfo());

        // Listas de objetos
        List<Car> cars = new()
        {
            new Car(){Model="Duster", Year=2021},
            new Car(){Model="Stepway", Year=2019},
            new Car(){Model="Captur", Year=2025},
            new Car(){Model="Chevrolet", Year=2026},
        };

        WriteLine("------------------------------");
        WriteLine("Para el listado de automoviles");
        foreach (var item in cars)
        {
            WriteLine(item.ShowInfo());
        }



    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    // Constructor por defecto
    public Car()
    { }

    // Constructor con parámetros
    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    // Destructor (~)
    // Se ejecuta automaticamente luego de ser eliminado por el recolector de basura
    // Ademas, sirve también para a liberar recursos 
    ~Car()
    {
        WriteLine("Destructor llamado. Recurso liberado !!");
    }


    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automovil: {Model}, Año:{Year}";
    }

    public void ShowMessage() => WriteLine("Este es un automovil");
    public void ShowMessage(string message) => WriteLine(message);

    public static void GeneralInfo()
    {
        WriteLine("El automovil es uno de los transportes más utilizados");
    }
}
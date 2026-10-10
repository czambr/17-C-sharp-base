
/*
=============
🏆 Ejercicio 
=============
*/
// 1. Crear una clase "Bus" con las siguientes propiedades:
//    - Brand (public)
//    - Model (public)
//    - Year (public)
//    - Price (public)
//    - TotalKilometers (public)
//
// 2. Implementar un constructor para inicializar los valores.
// 3. Agregar un método "Drive(int kilometers)" que aumente el kilometraje.
// 5. Agregar un método "ShowPrice()" que nos devuelva el precio del bus.
// 6. Crear una clase "Fleet" que administre una lista de buses.
//    - Método para agregar buses a la flota.
//    - Método mostrar el listado de buses.
//
// 7. Instanciar al menos tres objetos de la clase Bus, agregarlos a la Fleet y simular la conducción de 5000.
// 8. Mostrar los detalles de la flota antes y después de la conducción.

partial class Program
{
    static void ProductSalesDemo()
    {

        // Inventory inventory = new();
        // Product laptop = new Product("Laptop", 1200.99, 5);
        // Product mouse = new Product("Mouse", 100, 10);

        // inventory.AddProduct(laptop);
        // inventory.AddProduct(mouse);
        // inventory.ShowInventory();

        // laptop.Sell(1);
        // inventory.ShowInventory();

        Fleet fleetInventory = new Fleet();
        Bus mazda = new Bus("Mazada", "Mercedez", 12300, 350);
        Bus chevrolet = new Bus("Chevrolet", "Hino", 1400, 750);
        fleetInventory.AddBus(mazda);
        fleetInventory.AddBus(chevrolet);

        fleetInventory.ShowFleet();
        mazda.Drive(200);

        fleetInventory.ShowFleet();

    }

    class Product
    {
        public string? Name { get; set; }
        public double? Price { get; set; }
        public int? Stock { get; set; }

        public Product(string name, double price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void ShowInfo()
        {
            WriteLine($"Producto: {Name}, Price:{Price:C}, Stock:{Stock}");
        }


        public bool Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
                WriteLine($"Venta realizada: {quantity} unidades de {Name}");
                return true;
            }

            WriteLine($"Stock insuficiente para: {Name}");
            return false;
        }

    }


    class Inventory
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowInventory()
        {
            WriteLine();
            WriteLine("----Inventario de productos---");
            foreach (var product in products)
            {
                product.ShowInfo();
            }
        }
    }

}


class Bus
{
    public string? Brand { set; get; }
    public string? Model { set; get; }
    public double? Price { set; get; }
    public double? TotalKilometers { set; get; }

    public Bus(string brand, string model, double price, double totalKilometers)
    {
        Brand = brand;
        Model = model;
        Price = price;
        TotalKilometers = totalKilometers;
    }

    public void Drive(double distance)
    {
        TotalKilometers += distance;
        WriteLine($"\nDespues de manejar: {distance} km");
    }

    public void ShowPrice()
    {
        WriteLine($"El precio del bus es:{Price:C}");
    }
}

class Fleet
{
    private List<Bus> BusList = new List<Bus>();

    public void AddBus(Bus bus)
    {
        BusList.Add(bus);
    }

    public void ShowFleet()
    {
        WriteLine();
        WriteLine("----Inventario de buses---");
        foreach (var bus in BusList)
        {
            WriteLine($"Marca: {bus.Brand}, Modelo: {bus.Model}, Kilometraje: {bus.TotalKilometers}");
        }
    }
}

partial class Program
{
    static public void InventoryManager()
    {
        string[] products = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [100.50, 250.50, 45.50];


        Console.WriteLine("-----------------------");
        Console.WriteLine("1. Comprar Producto");
        Console.WriteLine("2. Salir");
        Console.WriteLine("-----------------------");
        Console.WriteLine("Ingrese la opcion");
        int option = int.Parse(Console.ReadLine()!);

        if (option == 1)
        {

            Console.WriteLine();
            Console.WriteLine("-----------------------");
            Console.WriteLine("Inventario de productos");
            Console.WriteLine("-----------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Producto: {products[i]} - Stock:{stock[i]} - Precio:{prices[i]:C}");
            }


            Console.WriteLine("\nIngrese el producto que desa comprar:");
            string? searchedProduct = Console.ReadLine();

            Console.WriteLine("\nIngrese la cantidad que desea comprar:");
            int quantity = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantity <= stock[i])
                    {
                        double total = (double)(quantity * prices[i]);
                        stock[i] -= quantity;
                        Console.WriteLine($"Compra exitosa. Su total es: {total:C}");
                        Console.WriteLine($"El stock restante para el producto {products[i]} es {stock[i]}");
                    }
                    else
                    {
                        Console.WriteLine("No hay suficiente stock disponible");
                    }

                }
            }
        }
        else if (option == 2)
        {
            Console.WriteLine("Gracias por su visita");
        }
        else
        {
            Console.WriteLine("Opcion invalida");
        }

    }

}

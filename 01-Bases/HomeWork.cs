partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Total generado: {totalAmount:C}");
        Console.WriteLine(unitPrice);
    }

    static void SalaryCalculator()
    {

        Console.WriteLine("Calculadora de salario");
        Console.WriteLine();

        Console.Write("Ingrese su nombre: ");
        string? nombre = Console.ReadLine();

        Console.Write("Ingrese su número de horas trabajadas: ");
        double hoursJob = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el salario por horas: ");
        int salaryByHour = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"El salario para {nombre} es: {hoursJob * salaryByHour}");


    }
}
partial class Program
{
    static void ShowNumericTypes()
    {

        int integerNumber = 42;

        // double: manejar decimales de hasta 64 bits
        double doubleNumber = 3.1416d;

        // Float: Para decimales, pero menos preciso que el double
        float floatingNumber = 274f;

        // Long: Numero mayor
        // Desde la verion 7: permite poner separadores como  "_"
        long longNumber = 300_200_100L;

        // Decimal
        // Calculos financieros
        decimal monetaryNumber = 99.99m;


        Console.WriteLine($"Entero: {integerNumber}");
        Console.WriteLine($"double: {doubleNumber}");
        Console.WriteLine($"flotante: {floatingNumber}");
        Console.WriteLine($"largo: {longNumber}");
        Console.WriteLine($"monetario: {monetaryNumber}");

    }
}
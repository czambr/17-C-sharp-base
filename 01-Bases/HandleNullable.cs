partial class Program
{
    static void HandleNullable()
    {
        string firstName = "Carlos";
        string? lastName = null;

        Console.WriteLine($"Primer Nombre: {firstName}");
        if (lastName != null)
        {
            Console.WriteLine($"Apellido: {lastName}");
        }
        else
        {
            Console.WriteLine("Apellido no especificado");
        }

        Console.WriteLine($"Apellido:  {lastName ?? "Apellido no especificado!!!"}");

        string? text = null;
        Console.WriteLine($"El texto tiene: {text?.Length} caracteres");




    }
}

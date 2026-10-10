partial class Program
{
    static public void Operators()
    {
        int number = 15;
        bool isEven = (number % 2) == 0;
        bool isGratherThanThen = number > 10;

        if (isEven && isGratherThanThen)
        {
        }
        else if (!isEven && isGratherThanThen)
        {
            Console.WriteLine($"El numero {number} es Impar y es mayor que 10");
        }
        else
        {
            Console.WriteLine($"El numero {number} no cumple con las condiciones");
        }

        // Operador ternario
        int age = 21;
        string category = age > 18 ? "Adulto" : "Menor";
        Console.WriteLine($"La persona con edad {age} es {category}");
    }
}
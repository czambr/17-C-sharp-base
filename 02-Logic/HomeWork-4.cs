partial class Program
{

    static void PrintDuplicationTable(int number, int tableLimit = 10)
    {

        WriteLine($"La taala de multiplicar del numero {number} es desde el 1 hasta {tableLimit}");
        WriteLine();
        for (int i = 1; i <= tableLimit; i++)
        {
            WriteLine($"{number} x {i} = {number * i}");
        }

        WriteLine();

    }

    // 🏆 Ejercicio:
    // Crear un método llamado `PrintFactorialTable` que reciba un número 
    // y muestre el factorial de todos los números desde 1 hasta el número ingresado.
    // Ejemplo: PrintFactorialTable(5);
    // 1! = 1
    // 2! = 2
    // 3! = 6
    // 4! = 24
    // 5! = 120
    static void PrintFactorialTable(int number)
    {
        WriteLine($"El factorial del numero {number} es desde 1 hasta {number}");
        // Tu código aquí
        for (int i = 1; i <= number; i++)
        {
            WriteLine($"{i}! = {CalculateFactorial(i)}");

        }
    }

    static int CalculateFactorial(int number)
    {

        int factorial = 1;
        for (int i = 1; i <= number; i++)
        {

            factorial *= i;

        }

        return factorial;
    }
}
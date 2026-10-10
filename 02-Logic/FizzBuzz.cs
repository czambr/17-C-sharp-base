
// 🏆 Ejercicio:
// Implementar un programa que recorra los números del 1 al 100.
// Consideraciones:
// Aplicar la lógica de FizzBuzz:
// - Si un número es divisible por 3, imprimir "Fizz".
// - Si un número es divisible por 5, imprimir "Buzz".
// - Si un número es divisible por 3 y 5, imprimir "FizzBuzz".
// - En cualquier otro caso, imprimir el número.
// 💡 Pista:
// - El orden de las condiciones es clave.
// Pi

partial class Program
{
    static void FizzBuzz()
    {

        for (int i = 1; i <= 100; i++)
        {

            bool isDivisbleByFive = (i % 5) == 0;
            bool isDivisibleByThree = (i % 3) == 0;

            string message = i.ToString();

            if (isDivisbleByFive && isDivisibleByThree)
            {
                message = "FizzBuzz";
            }
            else if (isDivisibleByThree)
            {
                message = "Fizz";
            }
            else if (isDivisbleByFive)
            {
                message = "Buzz";
            }

            WriteLine(message);


        }
    }
}
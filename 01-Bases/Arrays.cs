partial class Program
{
    static public void Arrays()
    {
        int[] numbers = new int[2];
        numbers[0] = 1;
        numbers[1] = 2;

        Console.WriteLine(numbers);

        int[] numbers2 = [1, 23, 435, 54654, 564];
        Console.WriteLine(numbers2.ToString());
        Console.WriteLine($"El tamano del arreglo es: {numbers2.Length}");

        //  Accesos desde el final
        Console.WriteLine($"El ultimo elemento ddel arreglo es: {numbers2[^1]}");
        Console.WriteLine($"El Penultimo elemento ddel arreglo es: {numbers2[^2]}");

        // Sub arreglos
        int[] firstThree = numbers2[..2];
        int[] fromIndexTwo = numbers2[2..];
        Console.WriteLine($"Los primeros 2 elementos del arreglo:");
        foreach (var item in firstThree)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine($"Desde el indice 2 al final");
        foreach (var item in fromIndexTwo)
        {
            Console.WriteLine(item);
        }


    }
}

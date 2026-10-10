

partial class Program
{
    static void Loops()
    {

        // While
        // int counter = 1;
        // while (counter <= 5)
        // {
        //     WriteLine($"Iteracion: {counter}");
        //     counter++;
        // }


        // // Do While: Se garantiza que el bloque se ejecute almenos una vez
        // // La condicion se evalua despues de la ejecución
        // int number = 1;
        // do
        // {
        //     WriteLine($"Numero: {number}");
        //     number++;
        // } while (number < 3);

        // Bucle iterativo
        for (int i = 0; i < 5; i++)
        {
            WriteLine($"Iteración: {i}");
        }

        for (int i = 10; i >= 0; i -= 2)
        {
            WriteLine(i);
        }

        // For each
        string[] fruits = ["Manzana", "Pera", "Coco", "Piña"];
        foreach (var fruta in fruits)
        {
            WriteLine(fruta);
        }

        List<string> names = ["Pedro", "Luis", "Juan"];
        foreach (var item in names)
        {
            WriteLine(item);
        }


    }
}
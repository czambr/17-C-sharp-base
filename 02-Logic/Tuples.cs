partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (43, "Hola");
        WriteLine(myTuple);
        WriteLine($"Numero: {myTuple.Item1}, Texto: {myTuple.Item2}");

        (int Number, string Text) myOtherTuple = (43, "Hola");
        WriteLine(myOtherTuple);
        WriteLine($"Numero: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");


        var operations = Operations(10, 20);
        WriteLine($"Suma: {operations.Sum}, Resta: {operations.Substraction}");

        (int sum, int substraction) = Operations(25, 10);
        WriteLine($"Suma: {sum}, Resta: {substraction}");

    }

    static (int Sum, int Substraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}
partial class Program
{
    static void DataTypes()
    {
        int interger = 42;
        double decimalNumber = 3.141;
        bool isTrue = true;
        char character = 'C';
        string text = "Hola mundo";

        Console.WriteLine($"""
            Entero: {interger},
            Decimal: {decimalNumber}
            Boolean: {isTrue}
            Caracter: {character}
            String: {text}
        """);


    }
}
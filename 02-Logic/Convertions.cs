partial class Program
{
    static void Conversions()
    {

        int number = 42;
        double decimalNumber = number;

        WriteLine($"decimal: {number}, decimalNumber: {decimalNumber}");


        // Conversiones explicitas: 
        // Puede haber perdida de datos o incompatibilidad con datos
        double explicitDecimalNumber = 42.5;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine(integerNumber);


        // Casteo
        // De strings a number
        // No se realizan redondeos, solo trunca el valor.
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine(parsedNumber);

        // -- Convert
        // Puede redondear
        double anotherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        WriteLine(convertedNumber); // Redondear

        int castedNumber = (int)anotherDecimalNumber;
        WriteLine(castedNumber);


    }
}
partial class Program
{

    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    static string EvaluateNumber(int number)
    {
        return number > 0 ?
            "Positivo" : number < 0
                    ? "Negativo" : "Cero";
    }

    static void Function()
    {
        var area = CalculateArea(4.5, 3.4);
        WriteLine($"El area es: {area}");

        var evaluateNumber = EvaluateNumber(45);
        WriteLine($"El numero evaluado es: {evaluateNumber}");
    }


}
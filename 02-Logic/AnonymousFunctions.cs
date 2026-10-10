partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine(Square(5));
        WriteLine(lambdaSquare(10));

        List<int> numbers = [1, 2, 3, 4, 5, 6, 7];
        var eventNumbers = numbers.Where(n => n % 2 == 0);

        foreach (var eventNumber in eventNumbers)
        {
            WriteLine(eventNumber);
        }

    }

    static Func<int, int> Square = delegate (int number)
    {
        return number * number;
    };

    static Func<int, int> lambdaSquare = x => x * x;
}
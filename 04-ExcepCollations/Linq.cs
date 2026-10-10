partial class Program
{
    static List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
        new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
        new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
        new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
        new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
        new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

    static void Linq()
    {
        // LinqBase();
        LinqBasicSearch();
    }

    static private void LinqBase()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // Sintaxis de consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;
        // Sintaxis de metodo
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);

        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }
    }

    // Consulta simples
    static private void LinqBasicSearch()
    {

        WriteLine("Personajes que pertenecen The Avangers");
        var avangersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        var avengersMethod = characters.Where(c => c.Team == "Avengers");

        foreach (var ch in avengersMethod)
        {
            WriteLine($"{ch.Alias} {ch.Name}");
        }

        var upperCaseNameQuery = from c in characters
                                 select c.Name?.ToUpper()
                                        ;
        var upperCaseNameMethod = characters.Select(ch => ch.Name?.ToUpper());

        // WriteLine(" ============= Nombres en mayusculas =========");
        // foreach (var ch in upperCaseNameMethod)
        // {
        //     WriteLine(ch);
        // }


        var sortedQuery = from c in characters
                          orderby c.Name descending
                          select c;

        var sortedMethod = characters.OrderByDescending(c => c.Name);
        // WriteLine(" ============= Nombres Ordenados de manera DESC =========");
        // foreach (var ch in sortedMethod)
        // {
        //     WriteLine($"{ch.Name}");
        // }

        var firstThreeQuery = (from c in characters
                               select c).Take(3);
        var firstThreeMethod = characters.Take(3);
        WriteLine(" ============= Obteniendo los 3 primeros =========");
        foreach (var ch in firstThreeMethod)
        {
            WriteLine($"{ch.Name}");
        }


    }

}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}


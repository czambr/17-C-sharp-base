partial class Program
{
    static public void ListDictionary()
    {
        ListHandler();
        DictionaryHandler();

    }

    static public void ListHandler()
    {
        List<string> names = new List<string> { "Ana", "Carlos", "Juan" };
        names.Add("Francisco");

        Console.WriteLine($"Total de nombres: {names.Count}");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"Ana esta en la lista?: {isPresent}");

    }

    static public void DictionaryHandler()
    {

        Dictionary<int, string> students = new Dictionary<int, string>
        {
            {1, "Ana"},
            {2, "felipe"},
            {3, "Elena"}
        };

        foreach (var student in students)
        {
            Console.WriteLine($"id: {student.Key} name: {student.Value}");
        }
    }
}

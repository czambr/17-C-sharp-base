partial class Program
{
    static void Collections()
    {

        // Listas
        // List<string> names = ["Luis", "Pedro", "Pablo"];
        // names.Add("Anna");
        // ShowNames(names);

        // names.Remove("Luis");
        // WriteLine(" --- Despues de remover a Luis ---");
        // ShowNames(names);


        // Diccionarios
        // Dictionary<int, string> students = new()
        // {
        //     { 1, "Ana"},
        //     {2, " Carlos"},
        //     {3, "Pablo"},
        // };

        // students.Add(4, "Roberto");
        // ShowStudents(students);

        // WriteLine("Despues de remover a Anna...");
        // students.Remove(1);
        // ShowStudents(students);

        // Hashset
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Melisa");
        users.Add("Maria");
        users.Add("Luis");
        foreach (var user in users)
        {
            WriteLine(user);
        }

    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            WriteLine($"Llave: {student.Key}, Valor: {student.Value}");
        }
    }

    private static void ShowNames(List<string> names)
    {
        foreach (string name in names)
        {
            WriteLine(name);
        }
    }
}
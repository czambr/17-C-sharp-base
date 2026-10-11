using System.Text.Json;

namespace ManageJsonFile
{
    class Character
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Alias { get; set; }
        public string? Team { get; set; }
    }
    partial class Program
    {
        public static void ManageJsonFile()
        {
            List<Character> characters =
            [
              new Character { Id = 1, Name = "Peter Parker", Alias = "Spider", Team = "Avengers" },
              new Character { Id = 2, Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
              new Character { Id = 3, Name = "Steve Rogers", Alias = "Capitán América", Team = "Avengers" }
            ];

            string filePath = "./05-Files/data/chracters.json";

            var characterJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });

            File.WriteAllText(filePath, characterJson);
            WriteLine("Se ha escrito el archvio json");


            // lectura de archvio
            var characterFromFile = File.ReadAllText(filePath);
            var charactersList = JsonSerializer.Deserialize<List<Character>>(characterFromFile)!;
            foreach (var character in charactersList)
            {
                WriteLine($"Id: {character.Id}, Name: {character.Name}, Alias: {character.Alias}, Team: {character.Team}");
            }
        }
    }
}
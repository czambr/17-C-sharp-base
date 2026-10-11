partial class Program
{
    static void DirectoryExample()
    {
        var directoryPath = "./05-Files/data";
        Directory.CreateDirectory($"{directoryPath}/DirEjemplo");

        if (Directory.Exists($"{directoryPath}/DirEjemplo"))
        {
            WriteLine("El directorio ya existe");
        }

        Directory.Delete($"{directoryPath}/DirEjemplo", recursive: true);
    }
}
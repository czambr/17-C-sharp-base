partial class Program
{
    static void PathExample()
    {
        var filePath = "./05-Files/data/Ejemplo.txt";

        var fileName = Path.GetFileName(filePath);
        var fileExatension = Path.GetExtension(filePath);
        var directoryName = Path.GetDirectoryName(filePath);
        var combinedPath = Path.Combine("C:", "User", "Documents", "Ejemplo.txt");
        var fullFilePath = Path.GetFullPath(filePath);


        WriteLine($"Nombre del archivo: {fileName}");
        WriteLine($"Nombre de la extension: {fileExatension}");
        WriteLine($"Nombre del directorio: {directoryName}");
        WriteLine($"Ruta combinada: {combinedPath}");
        WriteLine($"Ruta completa del archivo: {fullFilePath}");


    }
}
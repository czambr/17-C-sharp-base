partial class Program
{
    static void WriteFileExample()
    {
        var filePath = "./05-Files/data/EjemploEscritura.txt";

        var content = "Primera linea ahora modificada";
        var streamWriter = new StreamWriter(filePath, append: true);
        streamWriter.WriteLine(content);
        streamWriter.WriteLine("La hora actual es: " + DateTime.Now.ToString("HH:mm:ss"));

        streamWriter.Dispose(); // Cerrar el archivo

        WriteLine("Archivo creado exitosamente");

    }
}
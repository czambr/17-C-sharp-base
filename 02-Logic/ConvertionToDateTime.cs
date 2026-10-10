using System.Globalization;

partial class Program
{
    static void ConvertionToDateTiem()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-EC");

        int friends = int.Parse("101");
        DateTime birthDay = DateTime.Parse("2 March 2025");
        double cost = 25.50;

        WriteLine($"Tengo el {friends} amigos para invitar a mi fiesta");
        WriteLine($"La celebración de mi cumpleaños será {birthDay}");
        WriteLine($"Fromato largo: {birthDay:D}");
        WriteLine($"El costo de la entrada será: {cost:C}");

    }


}
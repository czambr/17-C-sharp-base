
partial class Program
{
    static void ShowTime()
    {

        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;


        DateTime nowWeekAgo = now.AddDays(-7);
        DateTime customDate = new(2025, 03, 02);


        DayOfWeek weekDay = now.DayOfWeek;


        Console.WriteLine($"Fecha y hora actual: {now}");
        Console.WriteLine($"Fecha actual: {today}");
        Console.WriteLine($"Hace una semana, la fecha {now} era: {nowWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha custom: {customDate}");
        Console.WriteLine($"Dia de la semana actual: {weekDay}");

    }
}
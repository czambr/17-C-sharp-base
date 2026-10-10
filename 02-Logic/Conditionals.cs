
partial class Program
{
    static void Conditionals()
    {

        int age = 19;
        // if (age >= 18)
        // {
        //     WriteLine("Eres mayor de edad");
        // }
        // else
        // {
        //     WriteLine("Eres menor de edad");
        // }

        // if ternario
        string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
        WriteLine(message);

        int tempeture = 30;
        string messageTemp = "";
        if (tempeture > 35)
        {
            messageTemp = "Hace mucho calor";
        }
        else if (tempeture >= 20)
        {
            messageTemp = "Es agradable";
        }
        else
        {
            messageTemp = "Hace frio";
        }
        WriteLine(messageTemp);


        // Switch
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Lunes");
                break;
            case 2:
                WriteLine("Martes");
                break;
            default:
                WriteLine("Dia no valido");
                break;
        }

        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miercoles",
            _ => "Dia no valido"
        };

        WriteLine(dayMessage);

    }
}
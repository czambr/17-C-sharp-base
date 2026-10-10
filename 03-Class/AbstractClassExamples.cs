partial class Program
{
    static void AbstractClassExamples()
    {
        WashingMachine myWasher = new WashingMachine() { Brand = "Samsung" };
        Microwave myMicrowave = new Microwave() { Brand = "LG" };

        myWasher.ShowBrand();
        myWasher.TurnOn();

        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();



    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }

    public abstract void TurnOn();

    public void ShowBrand()
    {
        WriteLine($"La marca del electrodoméstico es: {Brand}");
    }

}





class WashingMachine : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("La lavadora ha inicializado el ciclo de lavado ...");
    }

}

class Microwave : HomeAppliance
{
    public override void TurnOn()
    {
        WriteLine("El Microondas está calentando la comida...");
    }

}

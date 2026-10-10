partial class Program
{
    static void Visibility()
    {

        Jedi jedi = new Jedi();
        jedi.PowerLevel = 5000;
        jedi.LightSaberColor = "Azul";

        // jedi.UseForce();
        // WriteLine(jedi.PublicField);
        // jedi.RevealSecrets();

        Sith sith = new Sith();
        sith.PowerLevel = 4000;
        sith.LightSaberColor = "red";
        sith.UseForce();
    }

}

interface IForceUser
{
    int PowerLevel { get; set; }
    string? LightSaberColor { get; set; }

    void UseForce();
}


class Jedi : IForceUser
{

    // Todos tienen accesos al campo, dentro y fuera de la clase
    public string PublicField = "Soy un Jedi y mi poder conocido";

    // Solo dentro de clase se tienen acceso a este campo
    private string PrivatedField = "Mis pensamientos mas profuntos son privados";

    // Solo es accesible dentro de clase y en clases derivadas
    protected string ProtectedField = "El lado oscuro no debe conocer mis secretos";


    public int PowerLevel { get; set; }
    public string? LightSaberColor { get; set; }

    public void UseForce()
    {
        WriteLine($"Soy un Jedi con un sable de Luz {LightSaberColor} y mi nivel de poder: {PowerLevel}");
    }

    private void Meditate()
    {
        WriteLine("Estoy en profunda meditación con la furza");
    }

    protected void Train()
    {
        WriteLine("Estoy entrenando para convertirme en el mejor Jedi");
    }

    public void RevealSecrets()
    {
        WriteLine(PrivatedField);
        WriteLine(ProtectedField);
        Meditate();
    }
}


class Sith : Jedi, IForceUser
{

    public new void UseForce()
    {
        {
            WriteLine($"Soy un Sith con un sable de Luz {LightSaberColor} y mi nivel de poder: {PowerLevel}");
        }

    }
    public void ShowProtected()
    {
        WriteLine(ProtectedField);
        Train();
    }
}
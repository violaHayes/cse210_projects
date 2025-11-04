class Program
{
    static void Main()
    {
        // Console.Write("Bonjour le something ");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        mercury._name = "Venus";
        mercury._diameter = 1232344.343;

        mercury.DisplayPlanetInformation();
    }
}
class Program
{
    static void Main()
    {
        // Console.Write("Bonjour le something ");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 1234.343;

        // mercury.DisplayPlanetInformation();

        Planet venus = new Planet();
        mercury._name = "Venus";
        mercury._diameter = 1232344.343;

        // venus.DisplayPlanetInformation();

        
        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 98765;

        SolarSystem solarSystem = new SolarSystem();

        solarSystem._solarSystem.Add{mercury};
        solarSystem._solarSystem.Add{venus};
        solarSystem._solarSystem.Add{earth};
        solarSystem.DisplayPlanetInformation();


    }
}
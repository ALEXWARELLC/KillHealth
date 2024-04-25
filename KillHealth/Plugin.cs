using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace KillHealth;

public class Plugin : Plugin<Configuration>
{
    public override string Name { get; } = "KillHealth";
    public override string Author { get; } = "CypherTheProtogen";
    public override Version Version { get; } = new Version(1, 0, 0);
    public override string Prefix => "killhealth";

    Events.EventHandler EVHandler; // Ignore the nullable.

    public override void OnEnabled()
    {
        EVHandler = new Events.EventHandler(Config);

        Exiled.Events.Handlers.Player.Died += EVHandler.PerformKillHandler;
    }

    public override void OnDisabled()
    {
        Exiled.Events.Handlers.Player.Died -= EVHandler.PerformKillHandler;
    }
}

public class Configuration : IConfig
{
    public bool IsEnabled { get; set; } = true;
    public bool Debug { get; set; } = false;
    public int HealthToAdd { get; set; } = 100;
}
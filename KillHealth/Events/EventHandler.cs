using Exiled.Events.EventArgs.Player;

namespace KillHealth.Events;

internal class EventHandler
{
    internal EventHandler(Configuration config) => LocalConfig = config;

    Configuration LocalConfig;
    public void PerformKillHandler(DiedEventArgs ev)
    {
        ev.Attacker.Health += LocalConfig.HealthToAdd;
    }
}

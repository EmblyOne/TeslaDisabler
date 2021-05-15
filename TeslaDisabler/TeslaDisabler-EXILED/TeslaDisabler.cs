using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Player = Exiled.Events.Handlers.Player;
namespace TeslaDisabler
{
     public class TeslaDisabler : Plugin<Config>
     {
        public override string Author { get; } = "Space";
        public override string Name { get; } = "Tesla Disabler";
        public override string Prefix { get; } = "TeslaDisabler";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        public EventHandlers EventHandler;

        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);
            Player.TriggeringTesla += EventHandler.OnTriggeringTesla;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {

            Player.TriggeringTesla -= EventHandler.OnTriggeringTesla;
            EventHandler = null;
            base.OnDisabled();
        }
    }
}

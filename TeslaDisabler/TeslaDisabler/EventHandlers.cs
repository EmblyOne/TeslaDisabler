using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs; 

namespace TeslaDisabler
{
    public class EventHandlers
    {
         public Config config;

        public TeslaDisabler plugin;
        public EventHandlers(TeslaDisabler plugin) => this.plugin = plugin;
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
         {


            if (ev.Player.Team == Team.SCP && plugin.Config.SCP )
            {
                ev.IsTriggerable = false;

            }
            
            
            if (ev.Player.Team == Team.MTF && plugin.Config.MTF)
            {
                ev.IsTriggerable = false; 
            }
            if (ev.Player.Team == Team.RSC && plugin.Config.RSC)
            {
                ev.IsTriggerable = false;
            }
            if (ev.Player.IsGodModeEnabled  && plugin.Config.gm)  
            {
                ev.IsTriggerable = false; 
            } 
            if (ev.Player.IsCuffed == true && plugin.Config.Cuffed ) 
            {
                ev.IsTriggerable = false; 
            }
            if (ev.Player.Team == Team.CHI && plugin.Config.Chaos)
            {
                ev.IsTriggerable = false;
            }
            if (ev.Player.Team == Team.TUT && plugin.Config.Tutorials)   
            {
                ev.IsTriggerable = false;
            }
            if (ev.Player.Team == Team.CDP && plugin.Config.Classd)
            {
                ev.IsTriggerable = false;
            }
        }
    }
}

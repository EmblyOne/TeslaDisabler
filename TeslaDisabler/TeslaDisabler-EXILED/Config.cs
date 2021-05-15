using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace TeslaDisabler
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled ")]
        public bool IsEnabled { get; set; } = true;

        [Description("Enable disabling tesla for Class-D Personal")]
        public bool Classd { get; set; } = true;

        [Description("Enable disabling tesla for Chaos Insurgency")]
        public bool Chaos { get; set; } = true;

        [Description("Enable disabling tesla for Cuffed Players")]
        public bool Cuffed { get; set; } = true;

        [Description("Enable disabling tesla for Scientists")]
        public bool RSC { get; set; } = true;

        [Description("Enable disabling tesla for Tutorials")]
        public bool Tutorials { get; set; } = true;

        [Description("Enable disabling tesla for Players with God Mode")]
        public bool gm { get; set; } = true;

        [Description("Enable disabling tesla for Mobile Task Force")]
        public bool MTF { get; set; } = true; 


    }
}

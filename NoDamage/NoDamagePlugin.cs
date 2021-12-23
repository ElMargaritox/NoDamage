using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using SDG.Unturned;
using Steamworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace NoDamage
{
    public class NoDamagePlugin : RocketPlugin<Configuration.Configuration>
    {
        public static NoDamagePlugin Instance { get; set; }

        protected override void Load()
        {
            Logger.Log("Plugin By Margarita#8172");
            DamageTool.damagePlayerRequested += DamageTool_damagePlayerRequested;
        }

        private void DamageTool_damagePlayerRequested(ref DamagePlayerParameters parameters, ref bool shouldAllow)
        {
            if (parameters.cause == EDeathCause.PUNCH & Configuration.Instance.BlockDamagePunch) shouldAllow = false;
            if (parameters.cause == EDeathCause.GUN & Configuration.Instance.BlockDamageGuns) shouldAllow = false;
            if (parameters.cause == EDeathCause.VEHICLE & Configuration.Instance.BlockDamageVehicle) shouldAllow = false;
            if (parameters.cause == EDeathCause.MELEE & Configuration.Instance.BlockDamageMelee) shouldAllow = false;
            if (parameters.cause == EDeathCause.ZOMBIE & Configuration.Instance.BlockDamageZombie) shouldAllow = false;
        }



        protected override void Unload()
        {
            DamageTool.damagePlayerRequested -= DamageTool_damagePlayerRequested;
        }
    }
}

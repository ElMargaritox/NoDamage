using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDamage.Configuration
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool BlockDamageGuns;
        public bool BlockDamageMelee;
        public bool BlockDamagePunch;
        public bool BlockDamageVehicle;
        public bool BlockDamageZombie;
        public void LoadDefaults()
        {
            BlockDamageGuns = false;
            BlockDamageMelee = false;
            BlockDamagePunch = true;
            BlockDamageVehicle = false;
            BlockDamageZombie = true;
        }
    }
}

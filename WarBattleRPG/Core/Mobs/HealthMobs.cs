using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Interfaces;

namespace WarBattleRPG.Core.Mobs
{
    public class HealthMobs
    {
        public double BaseHealthMobs { get; set; }
        public void UpgradeHealthMobs(IMob mob)
        {
            BaseHealthMobs += mob.LevelMobs.Level * 100;
        }
    }
}

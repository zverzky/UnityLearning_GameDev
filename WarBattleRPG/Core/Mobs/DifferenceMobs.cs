using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Interfaces;

namespace WarBattleRPG.Core.Mobs
{
    public class DifferenceMobs
    {
        public double BasePhysicalDifferenceMobs { get; set; }
        public double BaseMagicDifferenceMobs { get; set; }
        public double BaseEventDifferenceMobs { get; set; }
        public void UpgradeDifferenceMobs(IMob mob) 
        {
            BasePhysicalDifferenceMobs += mob.LevelMobs.Level * 100;
            BaseMagicDifferenceMobs += mob.LevelMobs.Level * 100;
            BaseEventDifferenceMobs += mob.LevelMobs.Level * 100;
        }
    }
}

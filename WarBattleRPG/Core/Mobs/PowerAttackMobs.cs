using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Enums;
using WarBattleRPG.Core.Interfaces;
using ZverzkyGame.Core.Characters;

namespace WarBattleRPG.Core.Mobs
{
    public class PowerAttackMobs
    {
        public double BasePowerAttackMobs {  get; set; }
        public SpecificationAttack SpecificationAttackMobs { get; set; }
        public TypeAttack TypeAttack { get; set; }
        public void UpgradePowerAttackMobs(IMob mob)
        {
            BasePowerAttackMobs += mob.LevelMobs.Level * 100;
        }

    }
}

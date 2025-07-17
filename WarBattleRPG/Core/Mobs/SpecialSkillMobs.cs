using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Enums;
using ZverzkyGame.Core.Characters;

namespace WarBattleRPG.Core.Mobs
{
    public class SpecialSkillMobs
    {
        public TypeAttack Typeattack { get; set; }
        public double BasepowerAttackMob { get; set; }
        public int CountAttack { get; set; }
        public void GradePowerAttackOnLevel(Mobs mob)
        {
            mob.SpecialSkillMobs.BasepowerAttackMob += 30 + mob.LevelMobs.Level / 100;
        }
    }
}

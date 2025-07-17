using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Mobs;
using ZverzkyGame.Core.Interfaces;

namespace WarBattleRPG.Core.Interfaces
{
    public interface IMob
    {
        string NameMob { get; }
        PowerAttackMobs PowerAttackMobs { get; }
        SpecialSkillMobs SpecialSkillMobs { get; }
        HealthMobs HealthMobs { get; }
        DifferenceMobs DifferenceMobs { get; }
        LevelMobs LevelMobs { get; }
        void Attack(ICharacter target);
        void TakeDamage(double damage);
        void SpecialDamage(double damage);
    }

}

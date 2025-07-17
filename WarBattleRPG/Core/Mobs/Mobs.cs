using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Interfaces;
using ZverzkyGame.Core.Interfaces;

namespace WarBattleRPG.Core.Mobs
{
    public class Mobs : IMob
    {
        public string NameMob {  get; set; }

        public PowerAttackMobs PowerAttackMobs { get; set; }

        public SpecialSkillMobs SpecialSkillMobs { get; set; }

        public HealthMobs HealthMobs { get; set; }

        public DifferenceMobs DifferenceMobs { get; set; }

        public LevelMobs LevelMobs { get; set; }

        public void Attack(ICharacter target)
        {
            throw new NotImplementedException();
        }

        public void SpecialDamage(double damage)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }
    }
}

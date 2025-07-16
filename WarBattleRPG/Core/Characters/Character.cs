using WarBattleRPG.Core.Enums;
using WarBattleRPG.Core.GameManager.PowerAttack;
using ZverzkyGame.Core.GameManager.Difference;
using ZverzkyGame.Core.GameManager.Experience;
using ZverzkyGame.Core.GameManager.Health;
using ZverzkyGame.Core.GameManager.Levels;
using ZverzkyGame.Core.GameManager.PowerAttack;
using ZverzkyGame.Core.Interfaces;

namespace ZverzkyGame.Core.Characters
{
    public class Character : ICharacter
    {
        private string name;
        private PowerAttack powerAttack;
        private SpecificationAttack specificationattack;
        private SpecialSkill specialskilpowerattack;
        private Health health;
        private Difference difference;
        private Level level;
        private Expirience expirience;
        



        public string Name => name;

        public PowerAttack PowerAttack => powerAttack;
        public SpecificationAttack SpecificationAttack => specificationattack;
        public SpecialSkill SpecialSkill => specialskilpowerattack;

        public Health Health => health;

        public Difference Difference => difference;

        public Level Level => level;

        public Expirience Expirience => expirience;


        public virtual void Attack(ICharacter target)
        {
            if (this.PowerAttack.CountAttack % 4 == 0) 
            {
                double damage = this.SpecialSkill.BasepowerAttackChar;
                target.SpecialDamage(damage);
                this.SpecialSkill.CountAttack += 1;
            }
            double attackpower = this.PowerAttack.BasepowerAttackChar;
            target.TakeDamage(attackpower);
            this.PowerAttack.CountAttack += 1;
        }

        public virtual void SpecialDamage(double damage)
        {
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Magic)
            {
                double effectiveDamage = difference.EffectiveMagicalDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                } 
            }
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Phisical)
            {
                double effectiveDamage = difference.EffectivePhysicalDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                }
            }
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Event)
            {
                double effectiveDamage = difference.EffectiveEventDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                }
            }

        }

        public virtual void TakeDamage(double damage)
        {
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Magic)
            {
                double effectiveDamage = difference.EffectiveMagicalDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                }
            }
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Phisical)
            {
                double effectiveDamage = difference.EffectivePhysicalDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                }
            }
            if (this.PowerAttack.Typeattack == WarBattleRPG.Core.Enums.TypeAttack.Event)
            {
                double effectiveDamage = difference.EffectiveEventDifference(damage);
                health.CurrentHealthChar -= effectiveDamage;
                if (health.CurrentHealthChar < 0)
                {
                    health.CurrentHealthChar = 0;
                }
            }
            
        }
    }
}

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
        private Health health;
        private Difference difference;
        private Level level;
        private Expirience expirience;



        public string Name => name;

        public PowerAttack PowerAttack => powerAttack;

        public Health Health => health;

        public Difference Difference => difference;

        public Level Level => level;

        public Expirience Expirience => expirience;

        public void Attack(ICharacter target)
        {
            if (this.PowerAttack.CountAttack % 4 == 0) 
            {
                SpecialSkill(target);
            }
            double attackpower = this.PowerAttack.BasepowerAttackChar;
            target.TakeDamage(attackpower);
            this.PowerAttack.CountAttack += 1;
        }

        public void SpecialSkill(ICharacter target)
        {
            if (target.Health.CurrentHealthChar > target.Health.BasehealthChar/2) 
                target.Health.CurrentHealthChar = target.Health.CurrentHealthChar / 2;
            else 
            {
                target.Health.CurrentHealthChar = target.Health.CurrentHealthChar - 
                    target.Health.BasehealthChar;
                if (target.Health.CurrentHealthChar <= 0) target.Health.CurrentHealthChar = 0;
            }

        }

        public void TakeDamage(double damage)
        {
            double effectiveDamage = difference.EffectivePhysicalDifference(damage);
            health.CurrentHealthChar -= effectiveDamage;
            if (health.CurrentHealthChar < 0)
            {
                health.CurrentHealthChar = 0;
            }
        }
    }
}

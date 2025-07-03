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
            throw new NotImplementedException();
        }

        public void SpecialSkill(ICharacter target)
        {
            throw new NotImplementedException();
        }

        public void TakeDamage(double damage)
        {
            throw new NotImplementedException();
        }
    }
}

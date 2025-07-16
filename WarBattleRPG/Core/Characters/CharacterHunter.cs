using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;
using ZverzkyGame.Core.Interfaces;

namespace WarBattleRPG.Core.Characters
{
    public class CharacterHunter: Character
    {
        public CharacterHunter() 
        {
            Console.WriteLine("Создан новый персонаж класса Hunter");
        }
        public override void Attack(ICharacter target)
        {
            base.Attack(target);
        }
        public override void SpecialDamage(double damage)
        {
            base.SpecialDamage(damage);
        }
        public override void TakeDamage(double damage)
        {
            base.TakeDamage(damage); 
        }
    }
}

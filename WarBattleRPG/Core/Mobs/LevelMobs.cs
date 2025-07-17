using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;

namespace WarBattleRPG.Core.Mobs
{
    public class LevelMobs
    {
        public double Level { get; set; }
        public double BaseExp { get; set; }
        public double get_experience(Character character) 
        {
            if (character.Level.level < this.Level) 
            {
                BaseExp *= 2; 
            }
            if (character.Level.level == this.Level) 
            {
                BaseExp = BaseExp;
            }
            if (character.Level.level > this.Level) 
            {
                if (character.Level.level - this.Level >= 5)
                {
                    BaseExp = 0;
                }
                else BaseExp = BaseExp/2;
            }
            return BaseExp;
        }
    }
}

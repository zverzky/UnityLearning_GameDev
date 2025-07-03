using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;
using ZverzkyGame.Core.GameManager.Experience;

namespace ZverzkyGame.Core.GameManager.Levels
{
    public class Level
    {
        public double level { get; set; }
        public void LevelUp(Expirience expirience)
        {
            if (expirience.expirience >= expirience.needexpiriencetolevelup && level < 100)
            {
                level += 1;
                expirience.expirience -= expirience.needexpiriencetolevelup; 
                expirience.UPneedexpiriencetolevelup(this);
            }
        }
        public void GradeStatsOnLevel(Character character)
        {
            character.PowerAttack.GradePowerAttackOnLevel(character);
            character.Health.GradeHealthOnLevel(character);
            character.Difference.GradeDifferenceOnLevel(character);

        }
    }
}

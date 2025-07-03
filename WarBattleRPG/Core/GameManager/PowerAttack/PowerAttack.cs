using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;

namespace ZverzkyGame.Core.GameManager.PowerAttack
{
    public class PowerAttack
    {
        public double powerAttackChar { get; set; }

        public void GradePowerAttackOnLevel(Character character) 
        {
            character.PowerAttack.powerAttackChar += character.Level.level / 100;   
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarBattleRPG.Core.Enums;
using ZverzkyGame.Core.Characters;

namespace ZverzkyGame.Core.GameManager.PowerAttack
{
    public class PowerAttack
    {
        public TypeAttack Typeattack {  get; set; }
        public double BasepowerAttackChar { get; set; }
        public int CountAttack {  get; set; }

        public void GradePowerAttackOnLevel(Character character) 
        {
            character.PowerAttack.BasepowerAttackChar += 30 + character.Level.level / 100;   
        }

    }
}

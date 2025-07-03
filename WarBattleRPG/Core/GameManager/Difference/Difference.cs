using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;
using static System.Net.Mime.MediaTypeNames;

namespace ZverzkyGame.Core.GameManager.Difference
{
    public class Difference
    {
        private double basephysicalDifference { get; set; }
        private double basemagicalDifference { get; set; }
        private double baseeventDifference { get; set; }

        public double EffectivePhysicalDifference(double damage) 
        {
            double effectiveDamage = damage * (1 - basephysicalDifference / 100);
            return effectiveDamage;
        }
        public double EffectiveMagicalDifference(double damage)
        {
            double effectiveDamage = damage * (1 - basemagicalDifference / 100);
            return effectiveDamage;
        }
        public double EffectiveEventDifference(double damage)
        {
            double effectiveDamage = damage * (1 - baseeventDifference / 100);
            return effectiveDamage;
        }
        public void GradeDifferenceOnLevel(Character character)
        {
            character.Difference.basephysicalDifference += character.Level.level / 100;
            character.Difference.basemagicalDifference += character.Level.level / 100;
            character.Difference.baseeventDifference += character.Level.level / 100;
        }
    }
}

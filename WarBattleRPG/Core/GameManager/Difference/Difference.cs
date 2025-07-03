using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ZverzkyGame.Core.GameManager.Difference
{
    public class Difference
    {
        public double physicalDifference { get; }
        public double magicalDifference { get; }
        public double eventDifference { get; }

        public double EffectivePhysicalDifference(double damage) 
        {
            double effectiveDamage = damage * (1 - physicalDifference / 100);
            return effectiveDamage;
        }
        public double EffectiveMagicalDifference(double damage)
        {
            double effectiveDamage = damage * (1 - magicalDifference / 100);
            return effectiveDamage;
        }
        public double EffectiveEventDifference(double damage)
        {
            double effectiveDamage = damage * (1 - eventDifference / 100);
            return effectiveDamage;
        }
    }
}

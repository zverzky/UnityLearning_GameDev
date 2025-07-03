using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.GameManager.Levels;

namespace ZverzkyGame.Core.GameManager.Experience
{
    public class Expirience
    {
        public double expirience { get; set; }
        public double needexpiriencetolevelup { get; set; }
        public void UPneedexpiriencetolevelup(Level level) 
        {
            needexpiriencetolevelup += level.level * 50;
        }
    }
}

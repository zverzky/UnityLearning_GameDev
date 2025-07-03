using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZverzkyGame.Core.Characters;

namespace ZverzkyGame.Core.GameManager.Health
{
    public class Health
    {
        public double BasehealthChar { get; set; }
        public double CurrentHealthChar { get; set; }

        public void GradeHealthOnLevel(Character character)
        {
            character.Health.BasehealthChar += character.Level.level / 100;
            character.Health.CurrentHealthChar = character.Health.BasehealthChar;
        }
    }
}
 
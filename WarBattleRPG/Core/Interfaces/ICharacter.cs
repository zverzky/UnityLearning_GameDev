using WarBattleRPG.Core.GameManager.PowerAttack;
using ZverzkyGame.Core.GameManager.Difference;
using ZverzkyGame.Core.GameManager.Experience;
using ZverzkyGame.Core.GameManager.Health;
using ZverzkyGame.Core.GameManager.Levels;
using ZverzkyGame.Core.GameManager.PowerAttack;
using static System.Net.Mime.MediaTypeNames;

namespace ZverzkyGame.Core.Interfaces;

public interface ICharacter
{
    string Name { get; }
    PowerAttack PowerAttack { get; }
    SpecialSkill SpecialSkill { get; }
    Health Health { get; }
    Difference Difference { get; }
    Level Level { get; }
    Expirience Expirience { get; }
    void Attack(ICharacter target);
    void TakeDamage(double damage);
    void SpecialDamage(double damage);
}

using StarWars.GameObject;

namespace StarWars.Characters.Players
{
    public class BattleDroid : Player
    {
        private const int BattleDroidDamage = 100;
        private const int BattleDroidHealth = 100;
        private const int BattleDroidArmor = 30;

        public BattleDroid(Position position, char symbol, string name) : base(position, symbol, BattleDroidDamage, BattleDroidHealth, name, 0, BattleDroidArmor)
        {
        }
    }
}
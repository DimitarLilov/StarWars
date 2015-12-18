using StarWars.GameObject;

namespace StarWars.Characters.Enemies
{
    public class StormTrooper : Character
    {
        private const int StormTrooperDamage = 100;
        private const int StormTrooperHealth = 100;
        public StormTrooper(Position position, char symbol, string name) : base(position, symbol, StormTrooperDamage, StormTrooperHealth, name)
        {
        }
    }
}
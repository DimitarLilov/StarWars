using StarWars.GameObject;

namespace StarWars.Characters.Enemies
{
    public class SIthAPprentice : Character
    {
        private const int SIthAPprenticeDamage = 300;
        private const int SIthAPprenticeHealth = 300;
        private const int SithApprenticeArmor = 15;
        public SIthAPprentice(Position position, char symbol, string name) : base(position, symbol, SIthAPprenticeDamage, SIthAPprenticeHealth, name, SithApprenticeArmor)
        {
        }
    }
}
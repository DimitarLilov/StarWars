using StarWars.GameObject;

namespace StarWars.Characters.Enemys
{
    public class SIthAPprentice : Character
    {
        private const int SIthAPprenticeDamage = 300;
        private const int SIthAPprenticeHealth = 300;

        public SIthAPprentice(Position position, char symbol, string name) : base(position, symbol, SIthAPprenticeDamage, SIthAPprenticeHealth, name)
        {
        }
    }
}
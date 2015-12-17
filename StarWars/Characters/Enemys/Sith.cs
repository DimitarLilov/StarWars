using StarWars.GameObject;

namespace StarWars.Characters.Enemys
{
    public class Sith : Character
    {
        private const int SithDamage = 400;
        private const int SithHealth = 400;
        public Sith(Position position, char symbol, string name) : base(position, symbol, SithDamage, SithHealth, name)
        {
        }
    }
}

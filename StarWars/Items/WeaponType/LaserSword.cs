using StarWars.GameObject;

namespace StarWars.Items.WeaponType
{
    public class LaserSword : Weapon
    {
        private const int LaserSwordDamageRestore = 30;
        public LaserSword(Position position) : base(position, LaserSwordDamageRestore)
        {
        }

        public override string ToString()
        {
            return "LaserSword";
        }

    }
}

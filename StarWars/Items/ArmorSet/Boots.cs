using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Boots : Armor
    {
        private const int BootsArmorRestore = 5;
        public Boots(Position position) : base(position, BootsArmorRestore)
        {
        }
    }
}

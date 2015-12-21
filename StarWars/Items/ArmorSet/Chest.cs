using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Chest: Armor
    {
        private const int ChestArmorRestore = 7;
        public Chest(Position position) : base(position,  ChestArmorRestore)
        {
        }
    }
}

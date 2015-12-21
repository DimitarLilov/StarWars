using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Pants : Armor
    {
        private const int PantsArmorRestore = 12;
        public Pants(Position position) : base(position, PantsArmorRestore)
        {
        }
    }
}

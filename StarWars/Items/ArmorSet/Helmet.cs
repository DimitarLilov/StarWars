using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Helmet : Armor
    {
        private const int HelmetArmorRestore = 15;
        public Helmet(Position position) : base(position, HelmetArmorRestore)
        {
        }
    }
}

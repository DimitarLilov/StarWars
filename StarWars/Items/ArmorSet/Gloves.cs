using StarWars.GameObject;

namespace StarWars.Items.ArmorSet
{
    public class Gloves : Armor
    {
        private const int GloversArmorRestore = 10;
        public Gloves(Position position) : base(position, GloversArmorRestore)
        {
        }
    }
}

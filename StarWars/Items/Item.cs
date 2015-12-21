namespace StarWars.Items
{
    using StarWars.GameObject;
    public abstract class Item : GameObject
    {
        public Item(Position position, char symbol) : base(position, symbol)
        {

        }

       
    }
}
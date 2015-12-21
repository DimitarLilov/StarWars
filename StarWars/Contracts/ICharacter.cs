using StarWars.GameObject;

namespace StarWars.Contracts
{
    public interface ICharacter : IAttack, IDestroyable
    {
        string Name { get; }
        Position Position { get; }
    }
}



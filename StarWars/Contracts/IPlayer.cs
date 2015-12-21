namespace StarWars.Contracts
{
    public interface IPlayer : ICharacter, IMoveable
    {
        int Experience { get; }
        int Level { get; set; }
        void LevelUP();
    }
}
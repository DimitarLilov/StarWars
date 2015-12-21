using StarWars.Characters;


namespace StarWars.Contracts
{

    public interface IAttack
    {
        int Damage { get; }

        void Attack(Character enemy);
    }
}

using System;
using StarWars.GameObject;

namespace StarWars.Items
{
    public abstract class Weapon : Item
    {
        private int damageRestore;
        private const char SymbolWeapon = 'W';
        public Weapon(Position position, int damageRestore) : base(position, SymbolWeapon)
        {
            this.DamageRestore = damageRestore;
        }

        public int DamageRestore
        {
            get
            {
                return this.damageRestore;

            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Damage restore cannot be negative.");
                }
                this.damageRestore = value;
            }
        }
    }
}

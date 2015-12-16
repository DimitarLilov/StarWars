using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWars.Items
{
    public abstract class Weapon
    {
        private int weaponDamage;

        public int WeaponDamage 
        {
            get { return this.weaponDamage; }
            set { this.weaponDamage = value; } 
        }

        public WeaponTypes WeaponType { get; set; }
    }
}

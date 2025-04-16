using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les6
{
    public abstract class FireArm : IRangedWeapon
    {
        protected int AmmunitionCapacity;
        protected int AmmunitionDamage;
        protected int Loaded;

        public FireArm(int capacity, int damage)
        {
            AmmunitionCapacity = capacity;
            AmmunitionDamage = damage;
            Loaded = capacity;
        }

        public abstract void Reload();

        public int shoot()
        {
            if (Loaded > 0)
            {
                Loaded--;
                return AmmunitionDamage;
            }
            else
            {
                Reload();
                return 0;
            }
        }
    }
}

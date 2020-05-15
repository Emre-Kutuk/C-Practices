using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    abstract class Character
    {
        public IWeaponBehaviour weapon;

        public Character() { }

        public void Fight()
        {
            weapon.UseWeapon();
        }
    }
}

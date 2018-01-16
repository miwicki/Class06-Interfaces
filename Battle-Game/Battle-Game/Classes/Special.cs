using LAB06Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces
{
    class SpecialAbility : IDamage, IHeal
    {
        public int Damage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Restore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void RestoreHealth()
        {
            throw new NotImplementedException();
        }
    }
}
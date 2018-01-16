using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces.Interfaces
{
    interface IDamage
    {
        int Damage { get; set; }

        void Attack();
    }
}
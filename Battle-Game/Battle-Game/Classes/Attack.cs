using LAB06Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces
{
    class Attackers : IDamage
    {
        public int Health { get; set; }

        public void Attack()
        {
            Random random = new Random();
            int damage = random.Next(0, 11);
            Health = Health - damage;
            ;
        }

    }
}
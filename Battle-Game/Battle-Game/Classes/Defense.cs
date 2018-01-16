using LAB06Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06Interfaces
{
    class Defenders : IHeal
    {
        public int Health { get; set; }

        public void RestoreHealth()
        {
            Random random = new Random();
            int restore = random.Next(0, 6);
            Health = Health + restore;
            Console.Write("");
            Console.WriteLine("");
        }

    }
}
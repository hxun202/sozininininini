using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Knife : Weapon
    {
        public Knife()
        {
            damage = 10;
            range = 1;
        }

        public override void Attack()
        {
            Console.WriteLine("Knife Stab");
        }
    }
}

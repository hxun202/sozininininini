using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Character
    {
        private List<Weapon> weapons;
        private int currentCount;

        public Character()
        {
            weapons = new List<Weapon>();
            currentCount = 0;
        }

        public void Acquire(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public void Swap()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Spacebar)
                {
                    currentCount = currentCount + 1;

                    if (weapons.Count <= currentCount)
                    {
                        currentCount = 0;
                    }
                }
            }
        }

        public void Use()
        {
            if(Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.A)
                {
                    weapons[currentCount].Attack();
                }
            }
        }
    }
}

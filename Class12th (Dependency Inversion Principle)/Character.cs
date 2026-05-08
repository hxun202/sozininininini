

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
                    currentCount = currentCount + 1;

            if(weapons.Count <= currentCount)
            {
                currentCount = 0;
            }

        }

        public void Use()
        {
 
                    weapons[currentCount].Attack();
             
        }
    }

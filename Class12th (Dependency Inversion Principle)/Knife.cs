
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


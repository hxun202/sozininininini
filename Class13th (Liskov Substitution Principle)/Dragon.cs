
    internal class Dragon : Enemy, IFlyable
    {
        public Dragon()
        {
            health = 200;
        }

        public override void Attack()
        {
            Console.WriteLine("Dragon Attack");
        }

        public void Fly()
        {
            Console.WriteLine("50m high - altitude flight");
        }

        public override void Patrol()
        {
            Console.WriteLine("move int all direction");
        }
    }


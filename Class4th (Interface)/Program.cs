 internal class Program
    {
        static void Main(string[] args)
        {
        #region 인터 페이스
        // 객체가 외부에 제공해야 하는 기능을 정의하고,
        // 구현을 분리하기 위한 참조 타입입니다.

        ISelectable[] selectables = { new Frame(), new Switch(), new Clock() };

        int select = 0;

        while (true)
        {
            Console.Write("0 : Frame, 1 : Switch, 2 : Clock\n");

            Console.WriteLine("Plesase select an option : ");

            if (int.TryParse(Console.ReadLine(), out select) == false)
            {
                Console.WriteLine("Invalid Input...\n");

                continue;
            }

            if (select >= 0 && select < selectables.Length)
            {
                selectables[select].Select();

                if (selectables[select] is IActivatable activatable)
                {
                    Console.WriteLine("This item can be Used\n");

                    Console.WriteLine("0 : Use, 1 : do not use\n");

                    Console.WriteLine("Plesase select an option : ");

                    if (int.TryParse(Console.ReadLine(), out select) == false)
                    {
                        Console.WriteLine("\nInvalid Input...\n");

                        continue;
                    }

                    if (select >= 0 && select < 2)
                    {
                        Console.WriteLine();

                        activatable.Activate();
                    }
                    else
                    {
                        Console.WriteLine();

                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Exception");
            }

            Console.WriteLine();
        }
        #endregion);
    }
}


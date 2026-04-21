using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Barracks
{
    private int count = 0;
    private Soldier[] soldiers = new Soldier[5];

    public void Create(int select)
    {
        Soldier soldier = null;

        int createCount = 0;

        Console.Write("Select a Soldier : ");

        select = int.Parse(Console.ReadLine());
        if ()
        {


            switch (select)
            {
                case 1:
                    soldier = new Knight();
                    break;
                case 2:
                    soldier = new Archer();
                    break;
                case 3:
                    soldier = new Guard();
                    break;
                default:
                    Console.WriteLine("Exception");
                    break;
            }

            count++;
        }
        else if ()
        {
            Console.WriteLine(" ");
        }
    }
}

        public void Battle()
        {
            foreach(Soldier element in soldiers)
            {
              if(element != null)
              {
             element.Attack();
               }
            }
        }

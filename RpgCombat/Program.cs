using RpgCombat.Entities;
using System;

namespace RpgCombat
{
    class Program
    {
        static void Main(string[] args)
        {
            MeleeFighter character1 = new MeleeFighter("Jon Snow");
            RangeFighter character2 = new RangeFighter("Ramsey Bolton");
            character1.Level = 10;
            character2.Level = 3;
            Console.WriteLine(character1.ToString());
            Console.WriteLine(character2.ToString());
            int distance = 15;
            Console.WriteLine();

            Console.WriteLine($"{character2.Name} attacks {character1.Name}" );
            if (distance <= character2.MaxRange)
            {
                character2.DealDamage(character1, 100);
                Console.WriteLine("It's Effective!!");
            }
            else
            {
                Console.WriteLine("It's not Effective!! Out Of Range!");
            }
                
            
            Console.WriteLine(character1.ToString());
            Console.WriteLine(character2.ToString());
            Console.WriteLine();

            character2.HealItself();
            Console.WriteLine($"{character2.Name} healed himself.");
            Console.WriteLine();
            Console.WriteLine($"{character2.Name} attacks himself.");
            character2.DealDamage(character2, 1000);



            Console.WriteLine(character1.ToString());
            Console.WriteLine(character2.ToString());
        }
    }
}

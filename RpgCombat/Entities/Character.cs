using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgCombat.Entities
{
    class Character
    {        
        public string Name { get; set; }
        public double Health { get; set; }
        public int Level { get; set; }
        public bool Alive { get; set; }

        public Character(string name)
        {
            Name = name;
            Health = 1000;
            Level = 1;
            Alive = true;
        }

        public void DealDamage(Character character, double damage)
        {
            if (Name == character.Name)
            {
                Console.WriteLine("A L E R T  ! ! ! !  \nYou cannot harm yourself."); 
            }
            else
            {
                //Check if damage is greater than Health
                if (damage > character.Health)
                {
                    character.Health = 0;
                    character.Alive = false;
                    Console.WriteLine($"{character.Name} is dead !!!");
                }
                else
                {
                    if (Level - character.Level >= 5)
                        damage = damage * 1.5;

                    if (character.Level - Level >= 5)
                        damage = damage * 0.5;

                    character.Health -= damage;
                }                
            }            
        }

        public void Heal(Character character)
        {
            if (character.Alive)
            {
                //Check quantity to be heal.
                double totalToHeal = 1000 - character.Health;

                //Add the amount to be filled to Health
                character.Health += totalToHeal;
            }
            else
            {
                Console.WriteLine("The Character is DEAD. Impossible to heal.");
            }
            
        }

        public void HealItself()
        {
            //Check quantity to be heal.
            double totalToHeal = 1000 - Health;

            //Add the amount to be filled to Health
            Health += totalToHeal;
        }

        public override string ToString()
        {
            return "DATASHEET:" +
                $"{Name}, Level:{Level}, Health:{Health}";
        }
    }
}

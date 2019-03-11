using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Die> dice = new List<Die>();
            //Create 5 Dice
            for(int i = 0; i < 5; i++)
            {
                dice.Add(new Die());
            }
            //Print roll values
            foreach(Die d in dice)
            {
                Console.WriteLine("Rolled " + d.Value);
            }
            // Die dice1 = new Die();
            // dice1.Roll();

            //Console.WriteLine("Rolled " + dice1.Value);
            Console.ReadKey();
        }
    }
}

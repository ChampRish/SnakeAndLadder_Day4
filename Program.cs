using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem_Day4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int noStart = 0;

            Random random = new Random();
            int dice = random.Next(0, 1);
            if (dice == noStart)
            {
                Console.WriteLine("Player at Starting Position");
            }
            else
            {
                Console.WriteLine("Player move forword");
            }
            Console.ReadLine();
            UC2_RollingDice.RollingDice();
            Console.ReadLine();
            UC3_CheckOption.CheckOption();
            Console.ReadLine();
            UC4_RepeatPlayer.RepeatPlayer();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem_Day4
{
    internal class UC2_RollingDice
    {
        public static void RollingDice()
        {
            int dice;
            Random random = new Random();
            dice = random.Next(1, 7);
            Console.WriteLine("No. of shown in Dice is : " + dice);
        }
    }
}

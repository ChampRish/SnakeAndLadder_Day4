using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem_Day4
{
    internal class UC3_CheckOption
    {
        public static void CheckOption()
        {
            int noPlay = 0;
            int ladder = 1;
            int snake = 2;
            Random random = new Random();
            int checkOpt = random.Next(0, 3);
            if (checkOpt == noPlay)
            {
                Console.WriteLine("Player at Starting Position");
            }
            else if (checkOpt == ladder)
            {
                Console.WriteLine("Player reach to ladder");
            }
            else
            {
                Console.WriteLine("Player cut by Snake");
            }
        }
    }
}
